using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.IO;

public class ApiService {
    private readonly HttpClient _client;
    private readonly string _destinationFolderPath;

    public ApiService(string baseUrl, string destinationFolder) {
        _destinationFolderPath = destinationFolder;
        _client = new HttpClient {
            BaseAddress = new Uri(baseUrl)
        };
        Console.WriteLine("Base address: " + baseUrl);
    }

    public async Task<bool> AddSongAsync(Song song) {
        var response = await _client.PostAsJsonAsync("Songs", new
        {
            name = song.name,
            album = song.album,
            artist = song.artist,
            filename = song.filename
        });
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateSongAsync(Song song) {
        var response = await _client.PutAsJsonAsync("Songs", song);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteSongAsync(int songId) {
        var response = await _client.DeleteAsync($"Songs/{songId}");
        return response.IsSuccessStatusCode;
    }

    public async Task<Song> GetSongAsync(int songId) {
        return await _client.GetFromJsonAsync<Song>($"Songs/{songId}");
    }

    public async Task<List<Song>> GetAllSongsAsync() {
        return await _client.GetFromJsonAsync<List<Song>>("Songs");
    }

    public async Task<bool> DownloadSongFileAsync(Song song) {
        try {
            // Make the HTTP request to get the song file as a stream
            var response = await _client.GetAsync($"Songs/{song.songID}/file", HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            Directory.CreateDirectory(_destinationFolderPath);

            // Construct the local file path
            var localFilePath = Path.Combine(_destinationFolderPath, song.filename);  // Assumes file is in mp3 format

            // Open a stream for the file to be written to 
            // unless file already exists
            if (File.Exists(localFilePath))
            {
                Console.WriteLine("File already exists");
                return true;
            }
            else
            { 
                using (var fileStream = new FileStream(localFilePath, FileMode.Create, FileAccess.Write, FileShare.None)) 
                {
                    await response.Content.CopyToAsync(fileStream);
                } 
            }

            return true;
        } catch (Exception ex) {
            // Log the error or handle it accordingly
            Console.WriteLine($"An error occurred: {ex.Message}");
            return false;
        }

    }
}

public class Song {
    public int songID { get; set; }
    public string name { get; set; }
    public string album { get; set; }
    public string artist { get; set; }
    public int streams { get; set; }
    public string filename { get; set; }

}