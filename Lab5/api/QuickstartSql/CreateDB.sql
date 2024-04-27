
CREATE TABLE Songs (
                       SongID INT PRIMARY KEY IDENTITY,
                       Name VARCHAR(150),
                       Artist VARCHAR(150),
                       Album VARCHAR(150),
                       Filename VARCHAR(150)
);

CREATE TABLE Stats (
                       StatID INT PRIMARY KEY IDENTITY,
                       SongID INT,
                       Streams INT,
                       FOREIGN KEY (SongID) REFERENCES Songs(SongID)
)

-- Populate Songs table
INSERT INTO Songs (Name, Artist, Album, Filename)
VALUES
    ('Someone Like You', 'Adele', '21', 'Adele-SomeoneLikeYou.mp3'),
    ('Shape of You', 'Ed Sheeran', '�', 'EdSheeran-ShapeOfYou.mp3'),
    ('Despacito', 'Luis Fonsi ft. Daddy Yankee', 'Vida', 'LuisFonsi_ft_DaddyYankee-Despacito.mp3'),
    ('Uptown Funk', 'Mark Ronson ft. Bruno Mars', 'Uptown Special', 'MarkRonson_ft_BrunoMars-UptownFunk.mp3'),
    ('Closer', 'The Chainsmokers ft. Halsey', 'Collage', 'TheChainsmokers_ft_Halsey-Closer.mp3'),
    ('Old Town Road', 'Lil Nas X ft. Billy Ray Cyrus', '7', 'LilNasX_ft_BillyRayCyrus-OldTownRoad.mp3'),
    ('Thinking Out Loud', 'Ed Sheeran', 'x', 'EdSheeran-ThinkingOutLoud.mp3'),
    ('Havana', 'Camila Cabello ft. Young Thug', 'Camila', 'CamilaCabello_ft_YoungThug-Havana.mp3'),
    ('Sorry', 'Justin Bieber', 'Purpose', 'JustinBieber-Sorry.mp3'),
    ('Love Yourself', 'Justin Bieber', 'Purpose', 'JustinBieber-LoveYourself.mp3'),
    ('Shallow', 'Lady Gaga, Bradley Cooper', 'A Star is Born Soundtrack', 'LadyGaga_BradleyCooper-Shallow.mp3'),
    ('Hello', 'Adele', '25', 'Adele-Hello.mp3'),
    ('Gods Plan', 'Drake', 'Scorpion', 'Drake-GodsPlan.mp3'),
    ('Blinding Lights', 'The Weeknd', 'After Hours', 'TheWeeknd-BlindingLights.mp3'),
    ('Bad Guy', 'Billie Eilish', 'When We All Fall Asleep, Where Do We Go?', 'BillieEilish-BadGuy.mp3');

-- Populate Stats table
INSERT INTO Stats (SongID, Streams)
VALUES
    (1, 35),
    (2, 28),
    (3, 41),
    (4, 22),
    (5, 39),
    (6, 46),
    (7, 32),
    (8, 27),
    (9, 48),
    (10, 34),
    (11, 21),
    (12, 46),
    (13, 30),
    (14, 50),
    (15, 24);


--SELECT * FROM Songs;
--SELECT * FROM Stats;


--Drop table Songs;
--Drop table Stats;