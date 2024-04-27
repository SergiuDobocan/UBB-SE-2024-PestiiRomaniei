using System;

public class Song
{
    // Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }
    public string songUrl { get; set; }
    public int albumId { get; set; }
    public bool isApproved { get; set; }

    // Constructors
    public Song(string name, TimeSpan duration, string artist, DateTime releaseDate, string genre, bool isApproved)
    {
        Name = name;
        Duration = duration;
        Artist = artist;
        ReleaseDate = releaseDate;
        Genre = genre;
        isApproved = false;
    }
}
 
