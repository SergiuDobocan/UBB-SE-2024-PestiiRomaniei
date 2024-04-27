using System.Data;
using Microsoft.Data.SqlClient;
using SpookifyApi.Models;

namespace SpookifyApi.Repositories;

public class SongRepository : ISongRepository
{
    private readonly string _connectionString;

    public SongRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public async Task<int> Add(SongModel songModel)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText =
            "INSERT INTO songs (Name, Artist, Album, Filename) VALUES (@name, @artist, @album, @filename)";
        command.Parameters.AddWithValue("name", songModel.Name);
        command.Parameters.AddWithValue("artist", songModel.Artist);
        command.Parameters.AddWithValue("album", songModel.Album);
        command.Parameters.AddWithValue("filename", songModel.Filename);
        try
        {
            var result = await command.ExecuteNonQueryAsync();
            if (result == 1)
            {
                command.CommandText = "SELECT IDENT_CURRENT('Songs')";
                return Convert.ToInt32(await command.ExecuteScalarAsync());
            }
            return 0;
        }
        catch (SqlException e)
        {
            Console.WriteLine(e);
            return 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return 0;
        }
    }

    public async Task<bool> Update(SongModel songModel)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText =
            "UPDATE songs SET Name = @name, Artist = @artist, Album = @album, Filename = @filename WHERE SongID = @id";
        command.Parameters.AddWithValue("name", songModel.Name);
        command.Parameters.AddWithValue("artist", songModel.Artist);
        command.Parameters.AddWithValue("album", songModel.Album);
        command.Parameters.AddWithValue("filename", songModel.Filename);
        command.Parameters.AddWithValue("id", songModel.SongID);

        try
        {
            var result = await command.ExecuteNonQueryAsync();
            return result > 0;
        }
        catch (SqlException e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public async Task<bool> Delete(int songId)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "DELETE FROM songs WHERE SongID = @id";
        command.Parameters.AddWithValue("id", songId);

        try
        {
            var result = await command.ExecuteNonQueryAsync();
            return result > 0;
        }
        catch (SqlException e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public async Task<SongModel> Get(int songId)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT * FROM songs WHERE SongID = @id";
        command.Parameters.AddWithValue("id", songId);

        await using var reader = await command.ExecuteReaderAsync();
        if (!await reader.ReadAsync())
        {
            return null;
        }

        return new SongModel
        {
            SongID = reader.GetInt32(0),
            Name = reader.GetString(1),
            Artist = reader.GetString(2),
            Album = reader.GetString(3),
            Filename = reader.GetString(4)
        };
    }

    public async Task<IEnumerable<SongModel>> Get()
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT * FROM songs";

        await using var reader = await command.ExecuteReaderAsync();
        var songs = new List<SongModel>();
        while (await reader.ReadAsync())
        {
            songs.Add(new SongModel
            {
                SongID = reader.GetInt32(0),
                Name = reader.GetString(1),
                Artist = reader.GetString(2),
                Album = reader.GetString(3),
                Filename = reader.GetString(4)
            });
        }

        return songs;
    }
}