using Microsoft.AspNetCore.Routing;
using NUnit.Framework;
using SpookifyApi.Models;

namespace SpookifyApi.Tests.Models
{
    [TestFixture]
    public class SongInputModelTests
    {
        [Test]
        public void ToSongModel_WhenCalled_ReturnsSongModelWithSameValues()
        {
            // Arrange
            var songInput = new SongInputModel
            {
                Name = "Thriller",
                Artist = "Michael Jackson",
                Album = "Thriller",
                Filename = "thriller.mp3"
            };

            // Act
            var result = songInput.ToSongModel();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo(songInput.Name));
            Assert.That(result.Artist, Is.EqualTo(songInput.Artist));
            Assert.That(result.Album, Is.EqualTo(songInput.Album));
            Assert.That(result.Filename, Is.EqualTo(songInput.Filename));
        }
    }
}
