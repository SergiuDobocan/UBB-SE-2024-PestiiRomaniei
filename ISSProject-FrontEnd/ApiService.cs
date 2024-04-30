using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.IO;

public class ApiService
{
    private readonly HttpClient _client;
    private readonly string _destinationFolderPath;

    public ApiService(string baseUrl, string destinationFolder)
    {
        _destinationFolderPath = destinationFolder;
        _client = new HttpClient
        {
            BaseAddress = new Uri(baseUrl)
        };
        Console.WriteLine("Base address: " + baseUrl);
    }

    public async Task<bool> AddUserAsync(User user)
    {
        var response = await _client.PostAsJsonAsync("Users", new
        {
            name = user.username,
            password = user.password,
            role= user.role
        });
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateUserAsync(User user)
    {
        var response = await _client.PutAsJsonAsync("Users", user);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteUserAsync(int userId)
    {
        var response = await _client.DeleteAsync($"Users/{userId}");
        return response.IsSuccessStatusCode;
    }

    public async Task<User> GetUserAsync(int userId)
    {
        return await _client.GetFromJsonAsync<User>($"Users/{userId}");
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _client.GetFromJsonAsync<List<User>>("Users");
    }

    /*
    public async Task<bool> DownloadSongFileAsync(User user)
    {
        try
        {
            // Make the HTTP request to get the song file as a stream
            var response = await _client.GetAsync($"Users/{song.songID}/file", HttpCompletionOption.ResponseHeadersRead);
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
        }
        catch (Exception ex)
        {
            // Log the error or handle it accordingly
            Console.WriteLine($"An error occurred: {ex.Message}");
            return false;
        }

    }
    */
}

public class User
{
    public int userID { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string role { get; set; }

}