using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHomework
{
    public static class MusicManager
    {
        public static IEnumerable<Artist> Artists { get; private set; }

        public static IEnumerable<Album> Albums { get; private set; }

        public static IEnumerable<Song> Songs { get; private set; }

        static MusicManager()
        {
            InitArtists();
            InitAlbums();
            InitSongs();
        }

        private static void InitArtists()
        {
            Artists = new List<Artist>
            {
                new Artist
                {
                    Id = 1,
                    Name = "Red Hot Chilly Peppers",
                    AlbumIds = new List<int> { 4, 5, 6 }
                },
                new Artist
                {
                    Id = 2,
                    Name = "Tose Proeski",
                    AlbumIds = new List<int> { 7, 8, 9 }
                },
                new Artist
                {
                    Id = 3,
                    Name = "Dino Merlin",
                    AlbumIds = new List<int> { 10, 11, 12 }
                },
            };
        }

        private static void InitAlbums()
        {
            Albums = new List<Album>
            {
                #region RedHotChillyPeppers
                new Album
                {
                    Id = 4,
                    Name = "Californication",
                    Year = 1999,
                    ArtistId = 1,
                    SongIds = new List<int> { 13, 14, 15 }
                },
                new Album
                {
                    Id = 5,
                    Name = "Stadium Arcadium",
                    Year = 2006,
                    ArtistId = 1,
                    SongIds = new List<int> { 16, 17, 18 }
                },
                new Album
                {
                    Id = 6,
                    Name = "By the Way",
                    Year = 2006,//2002 is the true value, it is just for testing 2006
                    ArtistId = 1,
                    SongIds = new List<int> { 19, 20, 21 }
                },
                new Album
                {
                    Id = 40,
                    Name = "The Red Hot Chili Peppers",
                    Year = 1984,
                    ArtistId = 1,
                    SongIds = new List<int> { 41, 42, 43 }
                },
                #endregion

                #region ToseProeski
                new Album
                {
                    Id = 7,
                    Name = "Igri Bez Granici",
                    Year = 2007,
                    ArtistId = 2,
                    SongIds = new List<int> { 22, 23, 24 }
                },
                new Album
                {
                    Id = 8,
                    Name = "Po Tebe",
                    Year = 2005,
                    ArtistId = 2,
                    SongIds = new List<int> { 25, 26, 27 }
                },
                new Album
                {
                    Id = 9,
                    Name = "The Hardest Thing",
                    Year = 2009,
                    ArtistId = 2,
                    SongIds = new List<int> { 28, 29, 30 }
                },
                #endregion

                #region DinoMerlin
                new Album
                {
                    Id = 10,
                    Name = "Nesto lepo treba da se desi",
                    Year = 1989,
                    ArtistId = 3,
                    SongIds = new List<int> { 31, 32, 33 }
                },
                new Album
                {
                    Id = 11,
                    Name = "Kokuzna vremena",
                    Year = 1985,
                    ArtistId = 3,
                    SongIds = new List<int> { 34, 35, 36 }
                },
                new Album
                {
                    Id = 12,
                    Name = "Tesko meni sa tobom",
                    Year = 1986,
                    ArtistId = 3,
                    SongIds = new List<int> { 37, 38, 39 }
                },
                #endregion
            };
        }

        private static void InitSongs()
        {
            Songs = new List<Song>
            {
                #region Californication
                new Song
                {
                    Id = 13,
                    Name = "Californication",
                    AlbumId = 4,
                    Duration = 321
                },
                new Song
                {
                    Id = 14,
                    Name = "Around the World",
                    AlbumId = 4,
                    Duration = 238
                },
                new Song
                {
                    Id = 15,
                    Name = "Otherside",
                    AlbumId = 4,
                    Duration = 255
                },
                #endregion

                #region StadiumArcadium
                new Song
                {
                    Id = 16,
                    Name = "Stadium Arcadium",
                    AlbumId = 5,
                    Duration = 315
                },
                new Song
                {
                    Id = 17,
                    Name = "Dani California",
                    AlbumId = 5,
                    Duration = 282
                },
                new Song
                {
                    Id = 18,
                    Name = "Snow (Hey Oh)",
                    AlbumId = 5,
                    Duration = 334
                },
                #endregion

                #region ByTheWay
                new Song
                {
                    Id = 19,
                    Name = "By the Way",
                    AlbumId = 6,
                    Duration = 217
                },
                new Song
                {
                    Id = 20,
                    Name = "Don't Forget Me",
                    AlbumId = 6,
                    Duration = 312
                },
                new Song
                {
                    Id = 21,
                    Name = "Tear",
                    AlbumId = 6,
                    Duration = 317
                },
                #endregion

                #region TheRedHotChiliPeppers
                new Song
                {
                    Id = 41,
                    Name = "Get Up and Jump",
                    AlbumId = 40,
                    Duration = 173
                },
                new Song
                {
                    Id = 42,
                    Name = "Green Heaven",
                    AlbumId = 40,
                    Duration = 239
                },
                new Song
                {
                    Id = 43,
                    Name = "Police Helicopter",
                    AlbumId = 40,
                    Duration = 116
                },
                #endregion
                
                #region IgriBezGranici
                new Song
                {
                    Id = 22,
                    Name = "Boze, cuvaj ja od zlo",
                    AlbumId = 7,
                    Duration = 242
                },
                new Song
                {
                    Id = 23,
                    Name = "Cresha",
                    AlbumId = 7,
                    Duration = 250
                },
                new Song
                {
                    Id = 24,
                    Name = "Igri Bez Granici",
                    AlbumId = 7,
                    Duration = 294
                },
                new Song
                {
                    Id = 44,
                    Name = "Nesanica",
                    AlbumId = 7,
                    Duration = 294
                },
                #endregion
                
                #region PoTebe
                new Song
                {
                    Id = 25,
                    Name = "Po tebe",
                    AlbumId = 8,
                    Duration = 247
                },
                new Song
                {
                    Id = 26,
                    Name = "Gromovi na dusha",
                    AlbumId = 8,
                    Duration = 255
                },
                new Song
                {
                    Id = 27,
                    Name = "Koj li ti grize obrazi",
                    AlbumId = 8,
                    Duration = 301
                },
                #endregion

                #region TheHardestThing
                new Song
                {
                    Id = 28,
                    Name = "The Hardest Thing",
                    AlbumId = 9,
                    Duration = 228
                },
                new Song
                {
                    Id = 29,
                    Name = "My Little One",
                    AlbumId = 9,
                    Duration = 292
                },
                new Song
                {
                    Id = 30,
                    Name = "Guilty",
                    AlbumId = 9,
                    Duration = 232
                },
                #endregion

                #region NestoLepoTrebaDaSeDesi
                new Song
                {
                    Id = 31,
                    Name = "Mjesecina",
                    AlbumId = 10,
                    Duration = 272
                },
                new Song
                {
                    Id = 32,
                    Name = "Zar je to sve sto imam od tebe",
                    AlbumId = 10,
                    Duration = 290
                },
                new Song
                {
                    Id = 33,
                    Name = "Nesto lepo treba da se desi",
                    AlbumId = 10,
                    Duration = 284
                },
                #endregion
                
                #region KokuznaVremena
                new Song
                {
                    Id = 34,
                    Name = "Kokuzna vremena",
                    AlbumId = 11,
                    Duration = 227
                },
                new Song
                {
                    Id = 35,
                    Name = "Jutro u Splitu",
                    AlbumId = 11,
                    Duration = 302
                },
                new Song
                {
                    Id = 36,
                    Name = "Svjetla Zagreba",
                    AlbumId = 11,
                    Duration = 307
                },
                #endregion

                #region TeskoMeniSaTobom
                new Song
                {
                    Id = 37,
                    Name = "Tesko Meni Sa Tobom",
                    AlbumId = 12,
                    Duration = 237
                },
                new Song
                {
                    Id = 38,
                    Name = "Lazu me",
                    AlbumId = 12,
                    Duration = 262
                },
                new Song
                {
                    Id = 39,
                    Name = "Sibirska",
                    AlbumId = 12,
                    Duration = 277
                },
                #endregion
            };
        }

        public static Artist ArtistWithTheLongestName
        {
            get
            {
                return Artists
                    .OrderByDescending(a => a.Name.Length)
                    .First();
            }
        }

        public static Artist ArtistWithTheOldestAlbum
        {
            get
            {
               return (from al in Albums
                              orderby al.Year
                              join ar in Artists on al.ArtistId equals ar.Id
                              select ar).First();
            }

        }

        public static Artist ArtistWithTheNewestAlbum
        {
            get
            {
                return (from al in Albums
                        orderby al.Year descending
                        join ar in Artists on al.ArtistId equals ar.Id
                        select ar).First();
            }

        }

        public static Artist ArtistWithTheMaxAlbums
        {
            get
            {
                return (from al in Albums
                        group al by al.ArtistId into g
                        orderby g.Count() descending
                        join ar in Artists on g.Key equals ar.Id
                        select ar).First();
            }
        }

        public static Artist ArtistWithTheLongestSong
        {
            get
            {
                return (from s in Songs
                          orderby s.Duration descending
                          join al in Albums on s.AlbumId equals al.Id
                          join ar in Artists on al.ArtistId equals ar.Id
                          select ar).First();
            }
        }

        public static Artist ArtistWithTheMaxSongs
        {
            get
            {
                return (from s in Songs
                        join al in Albums on s.AlbumId equals al.Id
                        group al by al.ArtistId into g
                        orderby g.Count() descending
                        join ar in Artists on g.Key equals ar.Id
                        select ar).First();
            }
        }

        public static Artist ArtistWithAlbumWithTheMaxSongs
        {
            get
            {
                return (from s in Songs
                        group s by s.AlbumId into g
                        orderby g.Count() descending
                        join al in Albums on g.Key equals al.Id
                        join ar in Artists on al.ArtistId equals ar.Id
                        select ar).First();
            }

        }

        public static Artist ArtistWithLongestSumOfSongDurations
        {
            get
            {
                var albumsWithDuration = (from s in Songs
                                          group s by s.AlbumId into g1
                                          select new
                                          {
                                              AlbumDuration = g1.Sum(s => s.Duration),
                                              Album = (from al in Albums
                                                       where al.Id == g1.Key
                                                       select al).First()
                                          }).ToList();
                var artist = (from awd in albumsWithDuration
                              group awd by awd.Album.ArtistId into g
                              orderby g.Sum(p => p.AlbumDuration) descending
                              join ar in Artists on g.Key equals ar.Id
                              select ar).First();
                return artist;
            }
        }

        public static ushort YearWithTheMaxAlbums
        {
            get
            {
                return (from al in Albums
                        group al by al.Year into g
                        orderby g.Count() descending
                        select g.Key).First();
            }
        }

        public static bool AnyArtistWithAlbumsInOneYear
        {
            get
            {
                return (from al in Albums
                        group al by new { al.ArtistId, al.Year } into g
                        where g.Count() > 1
                        join ar in Artists on g.Key.ArtistId equals ar.Id
                        select ar).Any();
            }
        }

        public static double AverageSongDuration
        {
            get
            {
                return Songs.Average(s => s.Duration);
            }
        }

        public static double AverageAlbumDuration
        {
            get
            {
                return (from s in Songs
                        group s by s.AlbumId into g1
                        select new
                        {
                            AlbumDuration = g1.Sum(s => s.Duration),
                            Album = (from al in Albums
                                     where al.Id == g1.Key
                                     select al).First()
                        }).Average(a => a.AlbumDuration);
            }
        }
    }
}
