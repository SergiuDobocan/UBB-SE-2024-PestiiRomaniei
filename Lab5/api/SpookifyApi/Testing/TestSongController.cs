using NUnit.Framework;
using Moq;
using SpookifyApi.Controllers;
using SpookifyApi.Services;
using SpookifyApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System;

namespace SpookifyApi.Tests.Controllers
{
    [TestFixture]
    public class SongsControllerTests
    {
        private Mock<SongService> _mockSongService;
        private Mock<StatService> _mockStatService;
        private SongsController _songsController;

        [SetUp]
        public void SetUp()
        {
            _mockSongService = new Mock<SongService>();
            _mockStatService = new Mock<StatService>();
            _songsController = new SongsController(_mockSongService.Object, _mockStatService.Object);
        }

        [Test]
        public async Task Add_ValidSong_ReturnsOk()
        {
            // Arrange
            var songInputModel = new SongInputModel
            {
                Name = "My Song",
                Artist = "Awesome Artist",
                Album = "Best Album",
                Filename = "mysong.mp3"
            };
            _mockSongService.Setup(service => service.Add(It.IsAny<SongModel>())).ReturnsAsync(1);
            _mockStatService.Setup(service => service.Add(It.IsAny<StatModel>())).ReturnsAsync(1);

            // Act
            var result = await _songsController.Add(songInputModel);

            // Assert
            Assert.That(result, Is.InstanceOf<OkResult>());
        }

        [Test]
        public async Task Update_ValidSong_ReturnsOk()
        {
            // Arrange
            var songModel = new SongModel
            {
                SongID = 1,
                Name = "Updated Song",
                Artist = "Updated Artist",
                Album = "Updated Album",
                Filename = "updatedsong.mp3"
            };
            _mockSongService.Setup(service => service.Update(It.IsAny<SongModel>())).ReturnsAsync(true);

            // Act
            var result = await _songsController.Update(songModel);

            // Assert
            Assert.That(result, Is.InstanceOf<OkResult>());
        }

        [Test]
        public async Task Delete_ValidSongId_ReturnsOk()
        {
            // Arrange
            int songId = 1;
            _mockStatService.Setup(service => service.DeleteBySongId(It.IsAny<int>())).ReturnsAsync(true);
            _mockSongService.Setup(service => service.Delete(It.IsAny<int>())).ReturnsAsync(true);

            // Act
            var result = await _songsController.Delete(songId);

            // Assert
            Assert.That(result, Is.InstanceOf<OkResult>());
        }

        [Test]
        public async Task Get_ValidSongId_ReturnsSongWithStreams()
        {
            // Arrange
            int songId = 1;
            var songModel = new SongModel
            {
                SongID = songId,
                Name = "My Song",
                Artist = "Awesome Artist",
                Album = "Best Album",
                Filename = "mysong.mp3"
            };
            _mockSongService.Setup(service => service.Get(It.IsAny<int>())).ReturnsAsync(songModel);
            _mockStatService.Setup(service => service.GetStreams(It.IsAny<int>())).ReturnsAsync(100);

            // Act
            var result = await _songsController.Get(songId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.That(okResult, Is.Not.Null);
            var response = okResult.Value as dynamic;
            Assert.That(100, Is.EqualTo(response.streams));
        }

        [Test]
        public async Task GetAll_ReturnsListOfSongsWithStreams()
        {
            // Arrange
            var songs = new List<SongModel>
            {
                new SongModel
                {
                    SongID = 1,
                    Name = "My Song",
                    Artist = "Awesome Artist",
                    Album = "Best Album",
                    Filename = "mysong.mp3"
                },
                new SongModel
                {
                    SongID = 2,
                    Name = "Another Song",
                    Artist = "Another Artist",
                    Album = "Another Album",
                    Filename = "anothersong.mp3"
                }
            };
            _mockSongService.Setup(service => service.Get()).ReturnsAsync(songs);
            _mockStatService.Setup(service => service.GetStreams(It.IsAny<int>())).ReturnsAsync(100);

            // Act
            var result = await _songsController.Get();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.That(okResult, Is.Not.Null);
            var response = okResult.Value as List<dynamic>;
            Assert.That(2, Is.EqualTo(response.Count));
            Assert.That(100, Is.EqualTo(response[0].streams));
        }

        [Test]
        public async Task DownloadSongFile_ValidSongId_ReturnsFile()
        {
            // Arrange
            int songId = 1;
            var songModel = new SongModel
            {
                SongID = songId,
                Name = "My Song",
                Artist = "Awesome Artist",
                Album = "Best Album",
                Filename = "mysong.mp3"
            };
            var filePath = "/mock/path/mysong.mp3";
            var fileContent = new MemoryStream();
            var contentType = "audio/mpeg";

            _mockSongService.Setup(service => service.Get(It.IsAny<int>())).ReturnsAsync(songModel);
            _mockSongService.Setup(service => service.GetFilePath(It.IsAny<int>())).ReturnsAsync(filePath);
            _mockStatService.Setup(service => service.IncrementStreams(It.IsAny<int>())).ReturnsAsync(101);

            // Act
            var result = await _songsController.DownloadSongFile(songId);

            // Assert
            Assert.That(result, Is.InstanceOf<FileStreamResult>());
            var fileResult = result as FileStreamResult;
            Assert.That(contentType, Is.EqualTo(fileResult.ContentType));
            Assert.That(songModel.Filename, Is.EqualTo(fileResult.FileDownloadName));
        }

        // Additional tests for error handling, invalid inputs, etc.
    }
}
