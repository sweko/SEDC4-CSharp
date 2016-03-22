using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicDepo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bands = new List<Band>
            {
                new Band {ID = 1, Name = "Metallica" },
                new Band {ID = 2, Name = "Slipknot" },
                new Band {ID = 3, Name = "Rammstein" },
                new Band {ID = 4, Name = "Iron Maiden" },
                new Band {ID = 5, Name = "Guns n' Roses"}
            };

            var albums = new List<Album>
            {
                new Album { ID = 1, ArtistID = 1, Name = "Kill 'em all", Year = 1983},
                new Album { ID = 2, ArtistID = 1, Name="Ride the lightning", Year = 1984 },
                new Album { ID = 3, ArtistID = 1, Name="Master of puppets", Year = 1986 },
                new Album { ID = 4, ArtistID = 2, Name = ".5 The gray chapter", Year = 2014},
                new Album { ID = 5, ArtistID = 2, Name="Iowa", Year = 2001 },
                new Album { ID = 6, ArtistID = 2, Name="Vol. 3: (The Subliminal Verses)", Year = 2004 },
                new Album { ID = 7, ArtistID = 3, Name = "Mutter", Year = 2001},
                new Album { ID = 8, ArtistID = 3, Name="Reise, reise", Year = 2004 },
                new Album { ID = 9, ArtistID = 3, Name="Rosenrot", Year = 2005 },
                new Album { ID = 10, ArtistID = 4, Name="Iron Maiden", Year = 1980 },
                new Album { ID = 11, ArtistID = 4, Name="The Book of Souls", Year = 2015 },
                new Album { ID =12, ArtistID = 5, Name = "Use Your Illusion I", Year = 1991 },
                new Album { ID =13, ArtistID = 5, Name = "Use Your Illusion II", Year = 1991 },
            };

            var songs = new List<Song>
            {
                new Song {ID = 1, AlbumID = 1, Name = "Hit the lights", Length=256 },
                new Song {ID = 2, AlbumID = 1, Name = "The four horseman", Length=436 },
                new Song {ID = 3, AlbumID = 1, Name = "Motorbreath", Length=308 },
                new Song {ID = 28, AlbumID = 1, Name = "Jump in the Fire", Length=281 },
                new Song {ID = 29, AlbumID = 1, Name = "(Anesthesia) - Pulling Teeth", Length=255 },
                new Song {ID = 20, AlbumID = 1, Name = "Whiplash", Length=250 },
                new Song {ID = 4, AlbumID = 2, Name = "Hit the lights", Length=258 },
                new Song {ID = 5, AlbumID = 2, Name = "The four horseman", Length=439 },
                new Song {ID = 6, AlbumID = 2, Name = "Motorbreath", Length=312 },
                new Song {ID = 7, AlbumID = 3, Name = "Hit the lights", Length=256 },
                new Song {ID = 8, AlbumID = 3, Name = "The four horseman", Length=436 },
                new Song {ID = 9, AlbumID = 3, Name = "Motorbreath", Length=308 },
                new Song {ID = 10, AlbumID = 4, Name = "Hit the lights", Length=256 },
                new Song {ID = 11, AlbumID = 4, Name = "The four horseman", Length=436 },
                new Song {ID = 12, AlbumID = 4, Name = "Motorbreath", Length=308 },
                new Song {ID = 13, AlbumID = 5, Name = "Hit the lights", Length=256 },
                new Song {ID = 14, AlbumID = 5, Name = "The four horseman", Length=436 },
                new Song {ID = 15, AlbumID = 5, Name = "Motorbreath", Length=308 },
                new Song {ID = 16, AlbumID = 6, Name = "Hit the lights", Length=256 },
                new Song {ID = 17, AlbumID = 6, Name = "The four horseman", Length=436 },
                new Song {ID = 18, AlbumID = 6, Name = "Motorbreath", Length=308 },
                new Song {ID = 19, AlbumID = 7, Name = "Hit the lights", Length=256 },
                new Song {ID = 20, AlbumID = 7, Name = "The four horseman", Length=436 },
                new Song {ID = 21, AlbumID = 7, Name = "Motorbreath", Length=308 },
                new Song {ID = 22, AlbumID = 8, Name = "Hit the lights", Length=256 },
                new Song {ID = 23, AlbumID = 8, Name = "The four horseman", Length=444 },
                new Song {ID = 24, AlbumID = 8, Name = "Motorbreath", Length=308 },
                new Song {ID = 25, AlbumID = 9, Name = "Hit the lights", Length=250 },
                new Song {ID = 26, AlbumID = 9, Name = "The four horseman", Length=430 },
                new Song {ID = 27, AlbumID = 9, Name = "Motorbreath", Length=307 },
            };

            var maxNameLength = bands.Max(b => b.Name.Length);
            var longestName = bands.OrderByDescending(b => b.Name.Length).TakeWhile(b => b.Name.Length == maxNameLength);
            //longestName.PrintItems();

            var firstAlbumArtistId = albums.OrderBy(a => a.Year).First().ArtistID;
            var earliestBand = bands.Single(b => b.ID == firstAlbumArtistId);
            //Console.WriteLine(earliestBand);

            var lastAlbumArtistId = albums.OrderByDescending(a => a.Year).First().ArtistID;
            var lastBand = bands.Single(b => b.ID == lastAlbumArtistId);
            //Console.WriteLine(lastBand);

            var mostAlbums1 = from b in bands
                              join a in albums on b.ID equals a.ArtistID into allartistalbums
                              let artistAlbumCount = allartistalbums.Count()
                              orderby artistAlbumCount descending
                              select b;

            var mostAlbums2ID = albums.GroupBy(a => a.ArtistID).OrderByDescending(g => g.Count()).First().Key;
            var mostAlbums2 = bands.Single(b => b.ID == mostAlbums2ID);

            var maxDurationID = songs.OrderByDescending(s => s.Length).First().AlbumID;
            //maxDurationID.Dump();
            var longestSongOwner = from b in bands
                                   join a in albums on b.ID equals a.ArtistID
                                   where a.ID == maxDurationID
                                   select b;

            var longestSongOwner2 = (from b in bands
                                     join a in albums on b.ID equals a.ArtistID
                                     join s in songs on a.ID equals s.AlbumID
                                     orderby s.Length descending
                                     select b).First();
            //longestSongOwner2.Dump();

            var albumsWithSongs = albums.Select(a => new {
                ID = a.ID,
                ArtistID = a.ArtistID,
                Name = a.Name,
                SongCount = songs.Count(s => s.AlbumID == a.ID)
            });

            var bandsWithSongs = bands.Select(b => new {
                ID = b.ID,
                Name = b.Name,
                SongCount = albumsWithSongs.Where(a => a.ArtistID == b.ID).Sum(a => a.SongCount)
            });

            var mostSongs = bandsWithSongs.OrderByDescending(b => b.SongCount).First();
            //mostSongs.Dump();

            var mostSongsAlbum = albumsWithSongs.OrderByDescending(a => a.SongCount).First();
            var mostSongsAlbumBand = bands.Single(b => b.ID == mostSongsAlbum.ArtistID);

            //mostSongsAlbumBand.Dump();

            var albumsWithSongLengths = albums.Select(a => new {
                ID = a.ID,
                ArtistID = a.ArtistID,
                Name = a.Name,
                SongDuration = songs.Where(s => s.AlbumID == a.ID).Sum(s => s.Length)
            });

            var durationByArtist = albumsWithSongLengths
                .GroupBy(a => a.ArtistID, a => a.SongDuration)
                .Select(g => new {
                    ArtistID = g.Key,
                    TotalDuration = g.Sum()
                });

            var longest = durationByArtist.OrderByDescending(b => b.TotalDuration).First();
            //longest.Dump();

            var longestBand = bands.Single(b => b.ID == longest.ArtistID);
            //longestBand.Dump();

            var mostAlbumsYear = albums
                .GroupBy(a => a.Year)
                .Select(g => new {
                    Year = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(y => y.Count)
                .First();

            //mostAlbumsYear.Dump();

            var doubleAlbums1 = albums
            .GroupBy(g => g.Year)
            .Where(g => g.Count() > 1)
            .Select(g => new {
                Year = g.Key,
                Items = g.GroupBy(a => a.ArtistID)
            })
            .Select(y => new {
                Year = y.Year,
                Items = y.Items.Select(i => i.Count())
            })
            .Any(y => y.Items.Any(i => i > 1));


            var doubleAlbums2 = albums
            .GroupBy(g => new { g.Year, g.ArtistID })
            .Any(g => g.Count() > 1);

            //			doubleAlbums2.Dump();

            var averageSong = songs.Average(s => s.Length);
            //			averageSong.Dump();

            var averageAlbum = albumsWithSongLengths.Average(s => s.SongDuration);
            Console.WriteLine(averageAlbum);

        }
    }
}
