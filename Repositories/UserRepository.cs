// <copyright file="UserRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using System.Data;
using SpookifyApi.Models;
using Microsoft.Data.SqlClient;
namespace SpookifyApi.Repositories
{


    /// <summary>
    /// User Repository class.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// Constructor.
        /// </summary>
        /// <param name="configuration"> Configuration for the DB connection. </param>
        /// <param name="testConnectionString">Test DB connection string. </param>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public UserRepository(IConfiguration configuration, string testConnectionString = "")
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            if (configuration == null)
            {
                this.connectionString = testConnectionString;
            }
            else
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                this.connectionString = configuration.GetConnectionString("DefaultConnection");
#pragma warning restore CS8601 // Possible null reference assignment.
            }
        }

        /// <summary>
        /// Add new user to the repo.
        /// </summary>
        /// <param name="userModel"> The user to add in the repo. </param>
        /// <returns> integer. </returns>
        public async Task<int> Add(UserModel userModel)
        {
            await using var connection = new SqlConnection(this.connectionString);
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

        /// <summary>
        /// Update user from repo.
        /// </summary>
        /// <param name="userModel">The user to update in the repo. </param>
        /// <returns> boolean. </returns>
        public async Task<bool> Update(UserModel userModel)
        {
            await using var connection = new SqlConnection(this.connectionString);
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

        /// <summary>
        /// Delete user from repo.
        /// </summary>
        /// <param name="userId">The id of the user to delete. </param>
        /// <returns> boolean. </returns>
        public async Task<bool> Delete(int userId)
        {
            await using var connection = new SqlConnection(this.connectionString);
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

        /// <summary>
        /// Get user from repo.
        /// </summary>
        /// <param name="userId">The id of the user to find. </param>
        /// <returns> The found user as UserModel. </returns>
        public async Task<UserModel> Get(int userId)
        {
            await using var connection = new SqlConnection(this.connectionString);
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Users WHERE UserId = @id";
            command.Parameters.AddWithValue("id", userId);

            await using var reader = await command.ExecuteReaderAsync();
            if (!await reader.ReadAsync())
            {
#pragma warning disable CS8603 // Possible null reference return.
                return null;
#pragma warning restore CS8603 // Possible null reference return.
            }

            return new UserModel
            {
                UserId = reader.GetInt32(0),
                Username = reader.GetString(1),
                Password = reader.GetString(2),
                Role = (UserRole)Enum.Parse(typeof(UserRole), reader.GetString(3)),
            };
        }

        /// <summary>
        /// Get all users from the repo.
        /// </summary>
        /// <returns>List of users from the repo. </returns>
        public async Task<IEnumerable<UserModel>> GetAll()
        {
            await using var connection = new SqlConnection(this.connectionString);
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
                    Role = (UserRole)Enum.Parse(typeof(UserRole), reader.GetString(3)),
                });
            }

            return users;
        }

        /// <summary>
        /// Find if user exists.
        /// </summary>
        /// <param name="username"> The username of the user to find. </param>
        /// <param name="password"> The matching password of the user to find. </param>
        /// <returns> boolean. </returns>
        public async Task<bool> UserExists(string username, string password) // might be usefull for login page???
        {
            await using var connection = new SqlConnection(this.connectionString);
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);

#pragma warning disable CS8605 // Unboxing a possibly null value.
            var result = (int)await command.ExecuteScalarAsync();
#pragma warning restore CS8605 // Unboxing a possibly null value.
            return result > 0;
        }
    }
}
