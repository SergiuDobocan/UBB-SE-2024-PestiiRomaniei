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
    public class StatRepositoryTests
    {
        private Mock<IConfiguration> _mockConfiguration;
        private StatRepository _statRepository;
        private Mock<SqlConnection> _mockConnection;
        private Mock<SqlCommand> _mockCommand;
        private Mock<SqlDataReader> _mockReader;

        [SetUp]
        public void SetUp()
        {
            _mockConfiguration = new Mock<IConfiguration>();
            _mockConfiguration.Setup(config => config.GetConnectionString("DefaultConnection")).Returns("TestConnectionString");
            _statRepository = new StatRepository(_mockConfiguration.Object);

            _mockConnection = new Mock<SqlConnection>("TestConnectionString");
            _mockCommand = new Mock<SqlCommand>();
            _mockReader = new Mock<SqlDataReader>();
        }

        [Test]
        public async Task Add_ValidStatModel_ReturnsNewStatId()
        {
            // Arrange
            var statModel = new StatModel { SongID = 1, Streams = 100 };
            _mockCommand.Setup(cmd => cmd.ExecuteNonQueryAsync()).ReturnsAsync(1);
            _mockCommand.Setup(cmd => cmd.ExecuteScalarAsync()).ReturnsAsync(10); // Simulate returning a new StatID

            // Act
            var result = await _statRepository.Add(statModel);

            // Assert
            Assert.That(10, Is.EqualTo(result));
        }

        [Test]
        public async Task Update_ValidStatModel_ReturnsTrue()
        {
            // Arrange
            var statModel = new StatModel { StatID = 1, SongID = 1, Streams = 150 };
            _mockCommand.Setup(cmd => cmd.ExecuteNonQueryAsync()).ReturnsAsync(1); // Simulate successful update

            // Act
            var result = await _statRepository.Update(statModel);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task Delete_ValidStatId_ReturnsTrue()
        {
            // Arrange
            int statId = 1;
            _mockCommand.Setup(cmd => cmd.ExecuteNonQueryAsync()).ReturnsAsync(1); // Simulate successful delete

            // Act
            var result = await _statRepository.Delete(statId);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task Get_ValidStatId_ReturnsStatModel()
        {
            // Arrange
            int statId = 1;
            _mockReader.SetupSequence(reader => reader.ReadAsync()).ReturnsAsync(true).ReturnsAsync(false);
            _mockReader.Setup(reader => reader.GetInt32(It.IsAny<int>())).Returns(statId);
            _mockReader.Setup(reader => reader.GetInt32(It.IsAny<int>())).Returns(1);
            _mockReader.Setup(reader => reader.GetInt32(It.IsAny<int>())).Returns(100);

            // Act
            var result = await _statRepository.Get(statId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(statId, Is.EqualTo(result.StatID));
        }

        [Test]
        public async Task GetAll_ReturnsListOfStatModels()
        {
            // Arrange
            _mockReader.SetupSequence(reader => reader.ReadAsync()).ReturnsAsync(true).ReturnsAsync(true).ReturnsAsync(false);
            _mockReader.Setup(reader => reader.GetInt32(It.IsAny<int>())).Returns(1);
            _mockReader.Setup(reader => reader.GetInt32(It.IsAny<int>())).Returns(1);
            _mockReader.Setup(reader => reader.GetInt32(It.IsAny<int>())).Returns(100);

            // Act
            var result = await _statRepository.Get();

            // Assert
            var resultList = result as List<StatModel>;
            Assert.That(result, Is.Not.Null);
            Assert.That(2, Is.EqualTo(resultList.Count));
        }

    }
}
