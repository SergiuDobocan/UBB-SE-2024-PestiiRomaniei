using System;

public class Request 
{
	public int Id { get; set; }
	public Song Song { get; set; }

	public Request(int id, Song song)
	{
		Id = id;
		Song = song;

	}

	
}
