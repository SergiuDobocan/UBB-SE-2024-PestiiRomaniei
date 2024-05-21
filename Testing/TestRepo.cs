using SpookifyApi.Models;
using SpookifyApi.Controllers;
using SpookifyApi.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdminAPI
{
    [TestClass]
    public class RepositoryTests
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private UserRepository repo;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private string connectionString = "Server=DESKTOP-JTOCU1R\\SQLEXPRESS;Database=issdb2;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection? connection;

        [TestInitialize]
        public async Task TestInitialize_TableCreation_ThrowsException()
        {
            connection = new SqlConnection(connectionString);
            await connection.OpenAsync();
            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "CREATE TABLE Users (UserId INT PRIMARY KEY IDENTITY, Username VARCHAR(100) NOT NULL, Password VARCHAR(100) NOT NULL, Role VARCHAR(50) NOT NULL); " +
                                  "INSERT INTO Users (Username, Password, Role) VALUES ('TheBabby', 'thebabby', 'Artist'), ('sergiu', 'sergiu', 'Normal'), ('admin', 'admin', 'Admin');";
            await command.ExecuteNonQueryAsync();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            repo = new UserRepository(null, connectionString);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [TestMethod]
        public async Task AddUser_ModelWrong_ThrowsException()
        {
            UserModel newUser = new UserModel { Username = "newUser", Password = "password123", Role = UserRole.Normal };
            int userId = await repo.Add(newUser);
            Assert.IsTrue(userId > 0);
        }

        [TestMethod]
        public async Task UpdateUser_ModelWrong_ThrowsException()
        {
            UserModel updateUser = new UserModel { UserId = 1, Username = "UpdatedUser", Password = "updatedPassword", Role = UserRole.Admin };
            bool result = await repo.Update(updateUser);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task DeleteUser_UserIdNotFound_ThrowsException()
        {
            int userIdToDelete = 1;
            bool result = await repo.Delete(userIdToDelete);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task GetUser_NoUserFound_ThrowsException()
        {
            int userIdToGet = 1;
            UserModel user = await repo.Get(userIdToGet);
            Assert.IsNotNull(user);
            Assert.AreEqual(userIdToGet, user.UserId);
        }

        [TestMethod]
        public async Task GetAllUsers_UserNotFound_ThrowsException()
        {
            IEnumerable<UserModel> users = await repo.GetAll();
            Assert.IsNotNull(users);
            Assert.IsTrue(users.Any());
        }

        [TestMethod]
        public async Task UserExists_UserNotFound_ThrowsException()
        {
            string username = "TheBabby";
            string password = "thebabby";
            bool exists = await repo.UserExists(username, password);
            Assert.IsTrue(exists);
        }

        [TestCleanup]
        public async Task TestCleanup()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var command = connection.CreateCommand();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            command.CommandType = CommandType.Text;
            command.CommandText = "DROP TABLE Users";
            await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();
        }
    }
}