using System.Collections.Generic;
using System;

public class Playlist
{
    // Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public int SongCount { get { return Songs.Count; } } // Derived property based on the number of songs in the playlist
    public string Owner { get; set; }
    public bool IsPublic { get; set; }
    public List<Song> Songs { get; set; }

    // Constructor
    public Playlist(string name, string owner, bool isPublic)
    {
        Name = name;
        Owner = owner;
        IsPublic = isPublic;
        Songs = new List<Song>(); // Initialize the list of songs
    }

    // Method to add a song to the playlist
    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    // Method to remove a song from the playlist
    public void RemoveSong(Song song)
    {
        Songs.Remove(song);
    }

    
}