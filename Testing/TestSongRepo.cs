using NUnit.Framework;
using Moq;
using Microsoft.Data.SqlClient;
using System.Data;
using SpookifyApi.Models;
using SpookifyApi.Repositories;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace SpookifyApi.Tests.Repositories
{
    [TestFixture]
    public class SongRepositoryTests
    {
        private Mock<IConfiguration> _mockConfiguration;
        private SongRepository _songRepository;
        private Mock<SqlConnection> _mockConnection;
        private Mock<SqlCommand> _mockCommand;
        private Mock<SqlDataReader> _mockReader;

        [SetUp]
        public void SetUp()
        {
            _mockConfiguration = new Mock<IConfiguration>();
            _mockConfiguration.Setup(config => config.GetConnectionString("DefaultConnection")).Returns("TestConnectionString");

            _mockConnection = new Mock<SqlConnection>("TestConnectionString");
            _mockCommand = new Mock<SqlCommand>();
            _mockReader = new Mock<SqlDataReader>();

            _songRepository = new SongRepository(_mockConfiguration.Object);
        }

        [Test]
        public async Task Add_ValidSongModel_ReturnsNewSongId()
        {
            // Arrange
            var songModel = new SongModel { Name = "Test", Artist = "Test Artist", Album = "Test Album", Filename = "test.mp3" };
            _mockCommand.Setup(cmd => cmd.ExecuteNonQueryAsync()).ReturnsAsync(1);
            _mockCommand.Setup(cmd => cmd.ExecuteScalarAsync()).ReturnsAsync(10); // Simulate returning a new SongID

            // Act
            var result = await _songRepository.Add(songModel);

            // Assert
            Assert.That(10, Is.EqualTo(result));
        }

        [Test]
        public async Task Update_ValidSongModel_ReturnsTrue()
        {
            // Arrange
            var songModel = new SongModel { SongID = 1, Name = "Updated", Artist = "Updated Artist", Album = "Updated Album", Filename = "updated.mp3" };
            _mockCommand.Setup(cmd => cmd.ExecuteNonQueryAsync()).ReturnsAsync(1); // Simulate successful update

            // Act
            var result = await _songRepository.Update(songModel);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task Delete_ValidSongId_ReturnsTrue()
        {
            // Arrange
            int songId = 1;
            _mockCommand.Setup(cmd => cmd.ExecuteNonQueryAsync()).ReturnsAsync(1); // Simulate successful delete

            // Act
            var result = await _songRepository.Delete(songId);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task Get_ValidSongId_ReturnsSongModel()
        {
            // Arrange
            int songId = 1;
            _mockReader.SetupSequence(reader => reader.ReadAsync()).ReturnsAsync(true).ReturnsAsync(false);
            _mockReader.Setup(reader => reader.GetInt32(0)).Returns(songId);
            _mockReader.Setup(reader => reader.GetString(1)).Returns("Test");
            _mockReader.Setup(reader => reader.GetString(2)).Returns("Test Artist");
            _mockReader.Setup(reader => reader.GetString(3)).Returns("Test Album");
            _mockReader.Setup(reader => reader.GetString(4)).Returns("test.mp3");

            // Act
            var result = await _songRepository.Get(songId);

            // Assert
            Assert.That(result, Is.True);

            Assert.That(songId, Is.EqualTo(result.SongID));
        }

        [Test]
        public async Task GetAll_ReturnsListOfSongModels()
        {
            // Arrange
            _mockReader.SetupSequence(reader => reader.ReadAsync()).ReturnsAsync(true).ReturnsAsync(true).ReturnsAsync(false);
            _mockReader.Setup(reader => reader.GetInt32(0)).Returns(1);
            _mockReader.Setup(reader => reader.GetString(1)).Returns("Test");
            _mockReader.Setup(reader => reader.GetString(2)).Returns("Test Artist");
            _mockReader.Setup(reader => reader.GetString(3)).Returns("Test Album");
            _mockReader.Setup(reader => reader.GetString(4)).Returns("test.mp3");

            // Act
            var result = await _songRepository.Get();

            // Assert
            var resultList = result as List<SongModel>;
            Assert.That(resultList, Is.True);
            Assert.That(2, Is.EqualTo(resultList.Count));

        }

    }
}
