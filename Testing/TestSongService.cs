using NUnit.Framework;
using Moq;
using SpookifyApi.Models;
using SpookifyApi.Repositories;
using SpookifyApi.Services;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Collections.Generic;
using SpookifyApi.Configuration;

namespace SpookifyApi.Tests.Services
{
    [TestFixture]
    public class SongServiceTests
    {
        private Mock<ISongRepository> _mockSongRepository;
        private SongService _songService;
        private string _songFilesPath = "/mock/path";

        [SetUp]
        public void SetUp()
        {
            _mockSongRepository = new Mock<ISongRepository>();
            var mockFileSettings = Options.Create(new FileSettings { AudioFilesAbsPath = _songFilesPath });
            _songService = new SongService(_mockSongRepository.Object, mockFileSettings);
        }

        [Test]
        public async Task Add_ValidSongModel_CallsRepositoryAdd()
        {
            // Arrange
            var songModel = new SongModel { Name = "Test", Artist = "Artist", Album = "Album", Filename = "test.mp3" };
            _mockSongRepository.Setup(repo => repo.Add(It.IsAny<SongModel>())).ReturnsAsync(1);

            // Act
            var result = await _songService.Add(songModel);

            // Assert
            _mockSongRepository.Verify(repo => repo.Add(It.IsAny<SongModel>()), Times.Once);
            Assert.That(1, Is.EqualTo(result));
        }

        [Test]
        public async Task Update_ValidSongModel_CallsRepositoryUpdate()
        {
            // Arrange
            var songModel = new SongModel { SongID = 1, Name = "Updated", Artist = "Artist", Album = "Album", Filename = "updated.mp3" };
            _mockSongRepository.Setup(repo => repo.Update(It.IsAny<SongModel>())).ReturnsAsync(true);

            // Act
            var result = await _songService.Update(songModel);

            // Assert
            _mockSongRepository.Verify(repo => repo.Update(It.IsAny<SongModel>()), Times.Once);
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task Delete_ValidSongId_CallsRepositoryDelete()
        {
            // Arrange
            int songId = 1;
            _mockSongRepository.Setup(repo => repo.Delete(It.IsAny<int>())).ReturnsAsync(true);

            // Act
            var result = await _songService.Delete(songId);

            // Assert
            _mockSongRepository.Verify(repo => repo.Delete(It.IsAny<int>()), Times.Once);
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task Get_ValidSongId_CallsRepositoryGet()
        {
            // Arrange
            int songId = 1;
            var songModel = new SongModel { SongID = songId, Name = "Test", Artist = "Artist", Album = "Album", Filename = "test.mp3" };
            _mockSongRepository.Setup(repo => repo.Get(It.IsAny<int>())).ReturnsAsync(songModel);

            // Act
            var result = await _songService.Get(songId);

            // Assert
            _mockSongRepository.Verify(repo => repo.Get(It.IsAny<int>()), Times.Once);
            Assert.That(result, Is.Not.Null);
            Assert.That(songId, Is.EqualTo(result.SongID));
        }

        [Test]
        public async Task GetFilePath_ValidSongId_ReturnsFilePath()
        {
            // Arrange
            int songId = 1;
            var songModel = new SongModel { SongID = songId, Name = "Test", Artist = "Artist", Album = "Album", Filename = "test.mp3" };
            _mockSongRepository.Setup(repo => repo.Get(It.IsAny<int>())).ReturnsAsync(songModel);

            // Act
            var result = await _songService.GetFilePath(songId);

            // Assert
            Assert.That($"{_songFilesPath}/{songModel.Filename}",Is.EqualTo( result));
        }

        [Test]
        public async Task GetAll_CallsRepositoryGetAll()
        {
            // Arrange
            var songs = new List<SongModel>
            {
                new SongModel { SongID = 1, Name = "Test1", Artist = "Artist1", Album = "Album1", Filename = "test1.mp3" },
                new SongModel { SongID = 2, Name = "Test2", Artist = "Artist2", Album = "Album2", Filename = "test2.mp3" }
            };
            _mockSongRepository.Setup(repo => repo.Get()).ReturnsAsync(songs);

            // Act
            var result = await _songService.Get();

            // Assert
            _mockSongRepository.Verify(repo => repo.Get(), Times.Once);
            Assert.That(songs.Count(),  Is.EqualTo(result.Count()));
        }

    }
}
