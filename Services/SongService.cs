using Microsoft.Extensions.Options;
using SpookifyApi.Configuration;
using SpookifyApi.Models;
using SpookifyApi.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SpookifyApi.Services;

public class SongService
{
    private readonly ISongRepository _songRepository;
    private readonly string _songFilesPath;

    public SongService(ISongRepository songRepository, IOptions<FileSettings> fileSettings)
    {
        _songRepository = songRepository;
        _songFilesPath = fileSettings.Value.AudioFilesAbsPath;
    }

    // Check if songModel is valid
    private void ValidateSongModel(SongModel songModel, string errorString)
    {
        var validationContext = new ValidationContext(songModel);
        var validationResults = new List<ValidationResult>();
        if (!Validator.TryValidateObject(songModel, validationContext, validationResults, true))
        {
            throw new ValidationException(errorString + '-' + validationResults);
        }
    }

    public async Task<int> Add(SongModel songModel)
    {
        ValidateSongModel(songModel, "Validation failed when trying to add song.");
        try
        {
            return await _songRepository.Add(songModel);
        }
        catch (Exception e)
        {
            throw new Exception("Failed to add song.", e);
        }
    }

    public async Task<bool> Update(SongModel songModel)
    {
        ValidateSongModel(songModel, "Validation failed when trying to update song.");
        try
        {
            return await _songRepository.Update(songModel);
        }
        catch (Exception e)
        {
            throw new Exception("Failed to update song.", e);
        }
    }

    public async Task<bool> Delete(int songId)
    {
        try
        {
            return await _songRepository.Delete(songId);
        }
        catch (Exception e)
        {
            throw new Exception("Failed to delete song.", e);
        }
    }

    public async Task<SongModel> Get(int songId)
    {
        try
        {
            return await _songRepository.Get(songId);
        }
        catch (Exception e)
        {
            throw new Exception("Failed to get song.", e);
        }
    }

    public async Task<string> GetFilePath(int songId)
    {
        try
        {
            var song = await Get(songId);
            return song != null ? $"{_songFilesPath}/{song.Filename}" : null;
        }
        catch (Exception e)
        {
            throw new Exception("Failed to get song file path.", e);
        }
    }

    public async Task<IEnumerable<SongModel>> Get()
    {
        try
        {
            return await _songRepository.Get();
        }
        catch (Exception e)
        {
            throw new Exception("Failed to get songs.", e);
        }
    }
}