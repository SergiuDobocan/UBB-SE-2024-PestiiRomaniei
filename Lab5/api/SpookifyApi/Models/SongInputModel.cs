using System.ComponentModel.DataAnnotations;

namespace SpookifyApi.Models;

public class SongInputModel
{
    [Required]
    [StringLength(150)]
    public string Name { get; set; }
    [Required]
    [StringLength(150)]
    public string Artist { get; set; }
    [Required]
    [StringLength(150)]
    public string Album { get; set; }
    [Required]
    [StringLength(150)]
    public string Filename { get; set; }

    public SongModel ToSongModel()
    {
        return new SongModel
        {
            Name = Name,
            Artist = Artist,
            Album = Album,
            Filename = Filename
        };
    }
}