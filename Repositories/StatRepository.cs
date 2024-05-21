using System.Data;
using Microsoft.Data.SqlClient;
using SpookifyApi.Models;

namespace SpookifyApi.Repositories;

public class StatRepository : IStatRepository
{
    private readonly string _connectionString;
    
    public StatRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    
    public async Task<int> Add(StatModel statModel)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText =
            "INSERT INTO stats (SongID, Streams) VALUES (@songId, @streams)";
        command.Parameters.AddWithValue("songId", statModel.SongID);
        command.Parameters.AddWithValue("streams", statModel.Streams);

        try
        {
            var result = await command.ExecuteNonQueryAsync();
            if (result == 1)
            {
                command.CommandText = "SELECT IDENT_CURRENT('stats')";
                return Convert.ToInt32(await command.ExecuteScalarAsync());
            }
            return 0;
        }
        catch (SqlException e)
        {
            Console.WriteLine(e);
            return 0;
        }
    }
    
    public async Task<bool> Update(StatModel statModel)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText =
            "UPDATE stats SET SongID = @songId, Streams = @streams WHERE StatID = @id";
        command.Parameters.AddWithValue("songId", statModel.SongID);
        command.Parameters.AddWithValue("streams", statModel.Streams);
        command.Parameters.AddWithValue("id", statModel.StatID);

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
    
    public async Task<bool> Delete(int statId)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "DELETE FROM stats WHERE StatID = @id";
        command.Parameters.AddWithValue("id", statId);

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
    
    public async Task<StatModel> Get(int statId)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT * FROM stats WHERE StatID = @id";
        command.Parameters.AddWithValue("id", statId);

        var reader = await command.ExecuteReaderAsync();
        if (!await reader.ReadAsync())
        {
            return null;
        }

        return new StatModel
        {
            StatID = reader.GetInt32(0),
            SongID = reader.GetInt32(1),
            Streams = reader.GetInt32(2)
        };
    }
    
    public async Task<IEnumerable<StatModel>> Get()
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT * FROM stats";

        var reader = await command.ExecuteReaderAsync();
        var stats = new List<StatModel>();
        while (await reader.ReadAsync())
        {
            stats.Add(new StatModel
            {
                StatID = reader.GetInt32(0),
                SongID = reader.GetInt32(1),
                Streams = reader.GetInt32(2)
            });
        }

        return stats;
    }
}