using System.ComponentModel.DataAnnotations;

namespace SpookifyApi.Models;

public class StatModel
{
    [Required]
    public int StatID { get; set; }
    [Required]
    public int SongID { get; set; }
    public int Streams { get; set; }
}