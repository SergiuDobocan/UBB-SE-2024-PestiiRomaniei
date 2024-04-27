using System;
using System.Collections.Generic;

public class Album
{
    // Properties
    public int Id { get; set; }
    public string title { get; set; }
    public string Artist { get; set; }
    public List<Song> Songs { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string imageUrl { get; set; }

    // Constructor
    public Album(string name, string artist, string genre, DateTime releaseDate)
    {
        Name = name;
        Artist = artist;
        Genre = genre;
        ReleaseDate = releaseDate;
        Songs = new List<Song>(); // Initialize the list of songs
    }

    // Method to add a song to the album
    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    // Method to remove a song from the album
    public void RemoveSong(Song song)
    {
        Songs.Remove(song);
    }

   
}
