using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SpookifyApi.Configuration;
using SpookifyApi.Models;
using SpookifyApi.Repositories;
using SpookifyApi.Services;

namespace SpookifyApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SongsController : ControllerBase
{
    private readonly SongService _songService;
    private readonly StatService _statService;

    public SongsController(SongService songService, StatService statService)
    {
        _songService = songService;
        _statService = statService;
    }

    [HttpPost]
    public async Task<IActionResult> Add(SongInputModel songModelInput)
    {
        try
        {
            var result = await _songService.Add(songModelInput.ToSongModel());
            // if the song was added successfully, add a stat entry for it
            if (result == 0)
            {
              return BadRequest("Failed to add song.");
            }
            result = await _statService.Add(new StatModel
            {
                SongID = result,
                Streams = 0
            }); // todo rollback :)
            return result > 0 ? Ok() : BadRequest();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update(SongModel songModel)
    {
        try
        {
            var result = await _songService.Update(songModel);
            return result ? Ok() : BadRequest();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{songId}")]
    public async Task<IActionResult> Delete(int songId)
    {
        try
        {
            // first delete the associated stat, then the song
            var result = await _statService.DeleteBySongId(songId);
            if (!result)
            {
                return BadRequest();
            }
            result = await _songService.Delete(songId); // todo rollback 2
            return result ? Ok() : BadRequest();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{songId}")]
    public async Task<IActionResult> Get(int songId)
    {
        try
        {
            var song = await _songService.Get(songId);
            // append the streams to the song object
            var streams = await _statService.GetStreams(songId);
            var response = new
            {
                song.SongID,
                song.Name,
                song.Artist,
                song.Album,
                song.Filename,
                streams
            }; // streams appended to this endpoint
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var songList = await _songService.Get();
            // append the streams to the song object
            var response = new List<object>();
            foreach (var song in songList) // not ideal but anyway
            {
                var streams = await _statService.GetStreams(song.SongID);
                response.Add(new
                {
                    song.SongID,
                    song.Name,
                    song.Artist,
                    song.Album,
                    song.Filename,
                    streams
                });
            }

            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }

        try
        {
            var songs = await _songService.Get();
            return songs != null ? Ok(songs) : NotFound();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{id}/file")]
    public async Task<IActionResult> DownloadSongFile(int id)
    {
        // get the song filename from the repository
        var song = await _songService.Get(id);
        if (song == null)
        {
            return NotFound("Song not found.");
        }

        var filePath = await _songService.GetFilePath(id);
        if (!System.IO.File.Exists(filePath))
        {
            return NotFound("File not found.");
        }

        try
        {
            var memoryStream = new MemoryStream();
            await using (var stream = new FileStream(filePath, FileMode.Open))
            {
                await stream.CopyToAsync(memoryStream);
            }

            memoryStream.Position = 0;

            await _statService.IncrementStreams(id);

            // get content type, not sure why this is needed
            var provider = new Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(filePath, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            return File(memoryStream, contentType, song.Filename);
        }
        catch (Exception e)
        {
            return BadRequest(e.ToString);
        }
    }
}