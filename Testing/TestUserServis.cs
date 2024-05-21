using SpookifyApi.Configuration;
using SpookifyApi.Models;
using SpookifyApi.Repositories;
using SpookifyApi.Service;
using SpookifyApi.Controllers;
using SpookifyApi.Configuration;

using Azure.Core.Pipeline;
using Microsoft.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace TestAdminAPI
{
    [TestClass]
    public class ServiceTests
    {
        private UserRepository? repo;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private UserService serviceUsers;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private string _connectionString = "Server=DESKTOP-JTOCU1R\\SQLEXPRESS;Database=issdb2;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection? connection;
        [TestInitialize]
        public async Task TestInitialize_TableCreation_ThrowsException()
        {
            connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "CREATE TABLE Users ( UserId INT PRIMARY KEY IDENTITY,    Username VARCHAR(100) NOT NULL, Password VARCHAR(100) NOT NULL, Role VARCHAR(50) NOT NULL);INSERT INTO Users (Username, Password, Role) VALUES ('TheBabby', 'thebabby', 'Artist');INSERT INTO Users (Username, Password, Role) VALUES ('sergiu', 'sergiu', 'Normal');INSERT INTO Users (Username, Password, Role) VALUES ('admin', 'admin', 'Admin');";
            var result = await command.ExecuteNonQueryAsync();
            if (result > 0)
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                repo = new UserRepository(null, _connectionString);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
                serviceUsers = new UserService(repo);
            }
            else
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                repo = null;
                serviceUsers = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            }
        }

        //--------------------------------------------------------GET
        [TestMethod]
        public void TestServiceGetUser_UserNotFound_ThrowsException()
        {
            Assert.IsTrue(1 == serviceUsers.Get(1).Id);
        }

        //--------------------------------------------------------ADD
        [TestMethod]
        public async Task TestServiceAdd_ModelWrong_ThrowsException()
        {
            var userModel = new UserModel
            {
                Username = "testuser",
                Password = "testpassword",
                Role = UserRole.Artist
            };

            var addedUserId = await serviceUsers.Add(userModel);
            Assert.IsTrue(addedUserId > 0);
        }

        //--------------------------------------------------------UPDATE
        [TestMethod]
        public async Task TestServiceUpdate_ModelWrong_ThrowsException()
        {
            var userId = 1;
            var userToUpdate = await serviceUsers.Get(userId);
            userToUpdate.Username = "updatedusername";
            userToUpdate.Password = "updatedpassword";
            userToUpdate.Role = UserRole.Normal;

            var isUpdated = await serviceUsers.Update(userToUpdate);

            Assert.IsTrue(isUpdated);
        }

        //--------------------------------------------------------DELETE
        [TestMethod]
        public async Task TestServiceDelete_UserIdNotFound_ThrowsException()
        {
            // Arrange
            var userIdToDelete = 1; // Assuming user with Id = 1 exists

            // Act
            var isDeleted = await serviceUsers.Delete(userIdToDelete);

            // Assert
            Assert.IsTrue(isDeleted);
        }

        //--------------------------------------------------------GET ALL
        [TestMethod]
        public async Task TestServiceGetAll_UserNotFound_ThrowsException()
        {
            // Act
            var allUsers = await serviceUsers.GetAll();

            // Assert
            Assert.IsNotNull(allUsers);
            Assert.IsTrue(((List<UserModel>)allUsers).Count > 0);
        }

        //--------------------------------------------------------USER EXISTS
        private const string ExistingUsername = "admin";
        private const string ExistingPassword = "admin";

        [TestMethod]
        public async Task TestServiceUserExists_ExistingUser()
        {
            // Act
            var userExists = await serviceUsers.UserExists(ExistingUsername, ExistingPassword);

            // Assert
            Assert.IsTrue(userExists, "Existing user not found.");
        }

        [TestMethod]
        public async Task TestServiceUserExists_NonExistingUser()
        {
            // Non-existing user credentials
            const string nonExistingUsername = "nonexistinguser";
            const string nonExistingPassword = "nonexistingpassword";

            // Act
            var userExists = await serviceUsers.UserExists(nonExistingUsername, nonExistingPassword);

            // Assert
            Assert.IsFalse(userExists, "Non-existing user found.");
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