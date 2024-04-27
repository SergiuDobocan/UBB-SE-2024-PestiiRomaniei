using AdminAPI.Models;
using Microsoft.Data.SqlClient;

using System.Data;

namespace AdminAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<int> Add(UserModel userModel)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
            command.Parameters.AddWithValue("username", userModel.Username);
            command.Parameters.AddWithValue("password", userModel.Password);
            command.Parameters.AddWithValue("role", userModel.Role.ToString()); // Assuming Role is an enum

            try
            {
                var result = await command.ExecuteNonQueryAsync();
                if (result == 1)
                {
                    command.CommandText = "SELECT IDENT_CURRENT('Users')";
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


        public async Task<bool> Update(UserModel userModel)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Users SET Username = @username, Password = @password, Role = @role WHERE UserId = @id";
            command.Parameters.AddWithValue("username", userModel.Username);
            command.Parameters.AddWithValue("password", userModel.Password);
            command.Parameters.AddWithValue("role", userModel.Role.ToString());
            command.Parameters.AddWithValue("id", userModel.UserId);

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


        public async Task<bool> Delete(int userId)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Users WHERE UserId = @id";
            command.Parameters.AddWithValue("id", userId);

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

        public async Task<UserModel> Get(int userId)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Users WHERE UserId = @id";
            command.Parameters.AddWithValue("id", userId);

            await using var reader = await command.ExecuteReaderAsync();
            if (!await reader.ReadAsync())
            {
                return null;
            }

            return new UserModel
            {
                UserId = reader.GetInt32(0),
                Username = reader.GetString(1),
                Password = reader.GetString(2),
                Role = (UserRole)Enum.Parse(typeof(UserRole), reader.GetString(3))
            };
        }

        public async Task<IEnumerable<UserModel>> GetAll()
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Users";

            await using var reader = await command.ExecuteReaderAsync();
            var users = new List<UserModel>();
            while (await reader.ReadAsync())
            {
                users.Add(new UserModel
                {
                    UserId = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Role = (UserRole)Enum.Parse(typeof(UserRole), reader.GetString(3))
                });
            }

            return users;
        }

        public async Task<bool> UserExists(string username, string password) ///might be usefull for login page???
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);

            var result = (int)await command.ExecuteScalarAsync();
            return result > 0;
        }



    }
}
