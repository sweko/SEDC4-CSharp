using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHomework
{
    class Program
    {
        static IEnumerable<Artist> artist;
        static IEnumerable<Album> album;
        static IEnumerable<Song> song;
        static void Main(string[] args)
        {
            InitSongs();

            Console.WriteLine("Artist so najdolgo ime:");
            var longestLength = artist.Max(l => l.Name.Length);
            var artistName = artist.FirstOrDefault(l => l.Name.Length == longestLength);
            Console.WriteLine(JsonConvert.SerializeObject(artistName));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Artist koj prv izdal album:");
            var firstAlbum = (from a in artist
                             join b in album on a.ID equals b.ArtistID
                             orderby b.AlbumYear
                             select a.Name).First();
            Console.WriteLine(JsonConvert.SerializeObject(firstAlbum));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Artist koj posleden izdal album:");
            var lastAlbum = (from a in artist
                              join b in album on a.ID equals b.ArtistID
                              orderby b.AlbumYear
                              select a.Name).Last();
            Console.WriteLine(JsonConvert.SerializeObject(lastAlbum));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Artist koj ima najmnogu albumi:");
            var max1 = artist.Max(a => a.AlbumIds.Count());
            var maxAlbums = artist.Where(a => a.AlbumIds.Count() == max1).First();
            Console.WriteLine(JsonConvert.SerializeObject(maxAlbums.Name));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Artist koj ima najdolga pesna:");
            var songMax = song.Max(s => s.SongDuration);
            var artistLongestsSong = (from a in artist
                        join b in album on a.ID equals b.ArtistID
                        join s in song on b.ID equals s.AlbumID
                        where s.SongDuration == songMax
                        select a.Name).First();
            Console.WriteLine(JsonConvert.SerializeObject(artistLongestsSong));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Artist koj ima najmnogu pesni:");
            var maxSongs = album.Max(s => s.SongIds.Count());
            var artistMaxSongs = (from a in artist
                                 join b in album on a.ID equals b.ArtistID
                                 where b.SongIds.Count() == maxSongs
                                 select a.Name).First();
            Console.WriteLine(JsonConvert.SerializeObject(artistMaxSongs));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Artist so najdolgo vremetraenje na pesnite:");
            var maxMaxSong = song.Max(s => s.SongDuration);
            var artistMaxMaxSongs = (from a in artist
                                    join b in album on a.ID equals b.ArtistID
                                    join s in song on b.ID equals s.AlbumID
                                    where s.SongDuration == maxMaxSong
                                    select a.Name).First();
            Console.WriteLine(JsonConvert.SerializeObject(artistMaxMaxSongs));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Vo koja godina ima izdadeno najmnogu albumi:");
            var yearAlbums = (from a in artist
                             join b in album on a.ID equals b.ArtistID
                             group b by b.AlbumYear into y
                             let count = y.Count()
                             orderby count descending
                             select new { Year = y.Key, Albums = count}).First();
            Console.WriteLine(JsonConvert.SerializeObject(yearAlbums));
            Console.WriteLine("--------------------------");

            //Console.WriteLine("Dali ima artist koj izdal povekje od eden album vo ista godina:");
            //var artistYearAlbums = (from a in artist
            //                        join b in album on a.ID equals b.ArtistID

            //                        select new { Value = y.Key });
            //Console.WriteLine(JsonConvert.SerializeObject(artistYearAlbums));
            //Console.WriteLine("--------------------------");

            Console.WriteLine("Prosecno vremetraenje na pesna:");
            var avgSong = song.Average(a => a.SongDuration.TotalSeconds);
            Console.WriteLine(JsonConvert.SerializeObject(avgSong));
            Console.WriteLine("--------------------------");

            //Console.WriteLine("Prosecno vremetraenje na album:");
            //var avgAlbum = (from a in album
            //               join s in song on a.ID equals s.AlbumID
            //               group s by s.SongDuration.TotalSeconds into g
            //               select g.Key).Average();
            //Console.WriteLine(JsonConvert.SerializeObject(avgAlbum));
            //Console.WriteLine("--------------------------");
        }
        static void InitSongs()
        {
            artist = new List<Artist>
            {
                new Artist
                {
                    ID = 1,
                    Name = "Eminem",
                    AlbumIds = new List<int> { 1, 2, 3, 10 }
                },
                new Artist
                {
                    ID = 2,
                    Name = "50 Cent",
                    AlbumIds = new List<int> { 4, 5, 6, }
                },
                new Artist
                {
                    ID = 3,
                    Name = "Dr. Dre",
                    AlbumIds = new List<int> { 7, 8, 9}
                }
            };
            album = new List<Album>
            {
                // Eminem
                new Album
                {
                    ID = 1,
                    AlbumName = "Infinite",
                    AlbumYear = 1996,
                    ArtistID = 1,
                    SongIds = new List<int> { 1, 2, 3 }
                },
                new Album
                {
                    ID = 2,
                    AlbumName = "The Slim Shady LP",
                    AlbumYear = 1996,
                    ArtistID = 1,
                    SongIds = new List<int> { 4, 5, 6 }
                },
                new Album
                {
                    ID = 3,
                    AlbumName = "The Marshall Mathers LP",
                    AlbumYear = 2000,
                    ArtistID = 1,
                    SongIds = new List<int> { 7, 8, 9 }
                },
                new Album
                {
                    ID = 10,
                    AlbumName = "The Eminem Show",
                    AlbumYear = 2002,
                    ArtistID = 1,
                    SongIds = new List<int> { 28, 29, 30 }
                },
                // 50 Cent
                new Album
                {
                    ID = 4,
                    AlbumName = "Get Rich or Die Tryin",
                    AlbumYear = 2003,
                    ArtistID = 2,
                    SongIds = new List<int> { 10, 11 ,12 }
                },
                new Album
                {
                    ID = 5,
                    AlbumName = "The Massacre",
                    AlbumYear = 2005,
                    ArtistID = 2,
                    SongIds = new List<int> { 13, 14, 15 }
                },
                new Album
                {
                    ID = 6,
                    AlbumName = "Curtis",
                    AlbumYear = 2007,
                    ArtistID = 2,
                    SongIds = new List<int> { 16, 17, 18 }
                },
                // Dr. Dre
                new Album
                {
                    ID = 7,
                    AlbumName = "The Chronic",
                    AlbumYear = 1992,
                    ArtistID = 3,
                    SongIds = new List<int> { 19, 20, 21 }
                },
                new Album
                {
                    ID = 8,
                    AlbumName = "2001",
                    AlbumYear = 1999,
                    ArtistID = 3,
                    SongIds = new List<int> { 22, 23, 24 }
                },
                new Album
                {
                    ID = 9,
                    AlbumName = "Compton",
                    AlbumYear = 2015,
                    ArtistID = 3,
                    SongIds = new List<int> { 25, 26, 27 }
                }
            };
            song = new List<Song>
            {
                // Eminem 1
                new Song
                {
                    ID = 1,
                    SongName = "It's O.K.",
                    SongDuration = new TimeSpan(0, 0, 213),
                    AlbumID = 1
                },
                new Song
                {
                    ID = 2,
                    SongName = "Tonite",
                    SongDuration = new TimeSpan(0, 0, 254),
                    AlbumID = 1
                },
                new Song
                {
                    ID = 3,
                    SongName = "Maxine",
                    SongDuration = new TimeSpan(0, 0, 238),
                    AlbumID = 1
                },
                // Eminem 2
                new Song
                {
                    ID = 4,
                    SongName = "My Name Is",
                    SongDuration = new TimeSpan(0, 0, 268),
                    AlbumID = 2
                },
                new Song
                {
                    ID = 5,
                    SongName = "Brain Damage",
                    SongDuration = new TimeSpan(0, 0, 226),
                    AlbumID = 2
                },
                new Song
                {
                    ID = 6,
                    SongName = "My Fault",
                    SongDuration = new TimeSpan(0, 0, 241),
                    AlbumID = 2
                },
                // Eminem 3
                new Song
                {
                    ID = 7,
                    SongName = "Kill You",
                    SongDuration = new TimeSpan(0, 0, 264),
                    AlbumID = 3
                },
                new Song
                {
                    ID = 8,
                    SongName = "The Way I Am",
                    SongDuration = new TimeSpan(0, 0, 290),
                    AlbumID = 3
                },
                new Song
                {
                    ID = 9,
                    SongName = "The Real Slim Shady",
                    SongDuration = new TimeSpan(0, 0, 284),
                    AlbumID = 3
                },
                // Eminem 4
                new Song
                {
                    ID = 28,
                    SongName = "Business",
                    SongDuration = new TimeSpan(0, 0, 251),
                    AlbumID = 10
                },
                new Song
                {
                    ID = 29,
                    SongName = "Soldier",
                    SongDuration = new TimeSpan(0, 0, 226),
                    AlbumID = 10
                },
                new Song
                {
                    ID = 30,
                    SongName = "Superman",
                    SongDuration = new TimeSpan(0, 0, 350),
                    AlbumID = 10
                },
                // 50 Cent 1
                new Song
                {
                    ID = 10,
                    SongName = "Patiently Waiting",
                    SongDuration = new TimeSpan(0, 0, 288),
                    AlbumID = 4
                },
                new Song
                {
                    ID = 11,
                    SongName = "In da Club",
                    SongDuration = new TimeSpan(0, 0, 193),
                    AlbumID = 4
                },
                new Song
                {
                    ID = 12,
                    SongName = "Heat",
                    SongDuration = new TimeSpan(0, 0, 294),
                    AlbumID = 4
                },
                // 50 Cent 2
                new Song
                {
                    ID = 13,
                    SongName = "Candy Shop",
                    SongDuration = new TimeSpan(0, 0, 209),
                    AlbumID = 5
                },
                new Song
                {
                    ID = 14,
                    SongName = "Just a Lil Bit",
                    SongDuration = new TimeSpan(0, 0, 214),
                    AlbumID = 5
                },
                new Song
                {
                    ID = 15,
                    SongName = "My Toy Soldier",
                    SongDuration = new TimeSpan(0, 0, 224),
                    AlbumID = 5
                },
                // 50 Cent 3
                new Song
                {
                    ID = 16,
                    SongName = "Movin' on Up",
                    SongDuration = new TimeSpan(0, 0, 204),
                    AlbumID = 6
                },
                new Song
                {
                    ID = 17,
                    SongName = "All of Me",
                    SongDuration = new TimeSpan(0, 0, 231),
                    AlbumID = 6
                },
                new Song
                {
                    ID = 18,
                    SongName = "Touch the Sky",
                    SongDuration = new TimeSpan(0, 0, 190),
                    AlbumID = 6
                },
                // Dr. Dre 1
                new Song
                {
                    ID = 19,
                    SongName = "Let Me Ride",
                    SongDuration = new TimeSpan(0, 0, 261),
                    AlbumID = 7
                },
                new Song
                {
                    ID = 20,
                    SongName = "Nuthin' but a 'G' Thang",
                    SongDuration = new TimeSpan(0, 0, 238),
                    AlbumID = 7
                },
                new Song
                {
                    ID = 21,
                    SongName = "A Nigga Witta Gun",
                    SongDuration = new TimeSpan(0, 0, 232),
                    AlbumID = 7
                },
                // Dr. Dre 2
                new Song
                {
                    ID = 22,
                    SongName = "Xxplosive",
                    SongDuration = new TimeSpan(0, 0, 215),
                    AlbumID = 8
                },
                new Song
                {
                    ID = 23,
                    SongName = "Forgot About Dre",
                    SongDuration = new TimeSpan(0, 0, 222),
                    AlbumID = 8
                },
                new Song
                {
                    ID = 24,
                    SongName = "Some L.A. Niggaz",
                    SongDuration = new TimeSpan(0, 0, 265),
                    AlbumID = 8
                },
                // Dr. Dre 3
                new Song
                {
                    ID = 25,
                    SongName = "It's All on Me",
                    SongDuration = new TimeSpan(0, 0, 228),
                    AlbumID = 9
                },
                new Song
                {
                    ID = 26,
                    SongName = "Loose Cannons",
                    SongDuration = new TimeSpan(0, 0, 253),
                    AlbumID = 9
                },
                new Song
                {
                    ID = 27,
                    SongName = "Issues",
                    SongDuration = new TimeSpan(0, 0, 222),
                    AlbumID = 9
                }
            };
        }
    }
}
