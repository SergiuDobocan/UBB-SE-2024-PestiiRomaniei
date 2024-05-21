using NUnit.Framework;
using Moq;
using SpookifyApi.Models;
using SpookifyApi.Repositories;
using SpookifyApi.Services;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace SpookifyApi.Tests.Services
{
    [TestFixture]
    public class StatServiceTests
    {
        private Mock<IStatRepository> _mockStatRepository;
        private StatService _statService;

        [SetUp]
        public void SetUp()
        {
            _mockStatRepository = new Mock<IStatRepository>();
            _statService = new StatService(_mockStatRepository.Object);
        }

        [Test]
        public async Task Add_ValidStatModel_CallsRepositoryAdd()
        {
            // Arrange
            var statModel = new StatModel { SongID = 1, Streams = 100 };
            _mockStatRepository.Setup(repo => repo.Add(It.IsAny<StatModel>())).ReturnsAsync(1);

            // Act
            var result = await _statService.Add(statModel);

            // Assert
            _mockStatRepository.Verify(repo => repo.Add(It.IsAny<StatModel>()), Times.Once);
            Assert.That(1, Is.EqualTo(result));
        }

        [Test]
        public async Task Update_ValidStatModel_CallsRepositoryUpdate()
        {
            // Arrange
            var statModel = new StatModel { StatID = 1, SongID = 1, Streams = 150 };
            _mockStatRepository.Setup(repo => repo.Update(It.IsAny<StatModel>())).ReturnsAsync(true);

            // Act
            var result = await _statService.Update(statModel);

            // Assert
            _mockStatRepository.Verify(repo => repo.Update(It.IsAny<StatModel>()), Times.Once);
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task IncrementStreams_ValidSongId_IncrementsStreams()
        {
            // Arrange
            int songId = 1;
            var statModel = new StatModel { StatID = 1, SongID = songId, Streams = 100 };
            _mockStatRepository.Setup(repo => repo.Get()).ReturnsAsync(new List<StatModel> { statModel });
            _mockStatRepository.Setup(repo => repo.Update(It.IsAny<StatModel>())).ReturnsAsync(true);

            // Act
            var result = await _statService.IncrementStreams(songId);

            // Assert
            _mockStatRepository.Verify(repo => repo.Update(It.IsAny<StatModel>()), Times.Once);
            Assert.That(101, Is.EqualTo(result));
        }

        [Test]
        public async Task Delete_ValidStatId_CallsRepositoryDelete()
        {
            // Arrange
            int statId = 1;
            _mockStatRepository.Setup(repo => repo.Delete(It.IsAny<int>())).ReturnsAsync(true);

            // Act
            var result = await _statService.Delete(statId);

            // Assert
            _mockStatRepository.Verify(repo => repo.Delete(It.IsAny<int>()), Times.Once);
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task Get_ValidStatId_CallsRepositoryGet()
        {
            // Arrange
            int statId = 1;
            var statModel = new StatModel { StatID = statId, SongID = 1, Streams = 100 };
            _mockStatRepository.Setup(repo => repo.Get(It.IsAny<int>())).ReturnsAsync(statModel);

            // Act
            var result = await _statService.Get(statId);

            // Assert
            _mockStatRepository.Verify(repo => repo.Get(It.IsAny<int>()), Times.Once);
            Assert.That(result, Is.Not.Null);
            Assert.That(statId, Is.EqualTo (result.StatID));
        }

        [Test]
        public async Task GetStreams_ValidSongId_ReturnsStreams()
        {
            // Arrange
            int songId = 1;
            var statModel = new StatModel { StatID = 1, SongID = songId, Streams = 100 };
            _mockStatRepository.Setup(repo => repo.Get()).ReturnsAsync(new List<StatModel> { statModel });

            // Act
            var result = await _statService.GetStreams(songId);

            // Assert
            Assert.That(100, Is.EqualTo(result));
        }

        [Test]
        public async Task GetAll_CallsRepositoryGetAll()
        {
            // Arrange
            var stats = new List<StatModel>
            {
                new StatModel { StatID = 1, SongID = 1, Streams = 100 },
                new StatModel { StatID = 2, SongID = 2, Streams = 200 }
            };
            _mockStatRepository.Setup(repo => repo.Get()).ReturnsAsync(stats);

            // Act
            var result = await _statService.Get();

            // Assert
            _mockStatRepository.Verify(repo => repo.Get(), Times.Once);
            Assert.That(2, Is.EqualTo(result.Count()));
        }

        // Additional tests for error handling, invalid inputs, etc.
    }
}
