using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Artist with the longest name is " + MusicManager.ArtistWithTheLongestName);
                                           
            Console.WriteLine("Artist with the oldest album is " + MusicManager.ArtistWithTheOldestAlbum);
                                           
            Console.WriteLine("Artist with the newest album is " + MusicManager.ArtistWithTheNewestAlbum);
                                           
            Console.WriteLine("Artist with the max number of albums is " + MusicManager.ArtistWithTheMaxAlbums);

            Console.WriteLine("Artist with the longest song is " + MusicManager.ArtistWithTheLongestSong);

            Console.WriteLine("Artist with the max number of songs is " + MusicManager.ArtistWithTheMaxSongs);

            Console.WriteLine("Artist with album with the max number of songs is " + MusicManager.ArtistWithAlbumWithTheMaxSongs);

            Console.WriteLine("Artist with the longest sum of song durations " + MusicManager.ArtistWithLongestSumOfSongDurations);

            Console.WriteLine("The year with the max number of albums is " + MusicManager.YearWithTheMaxAlbums);

            if (MusicManager.AnyArtistWithAlbumsInOneYear)
            {
                Console.WriteLine("There is artist with more than one album in a year.");
            }
            else
            {
                Console.WriteLine("There is no artist with more than one album in a year.");
            }

            Console.WriteLine("The average song duration is " + MusicManager.AverageSongDuration.ToString("##.###"));

            Console.WriteLine("The average album duration is " + MusicManager.AverageAlbumDuration.ToString("##.###"));

            Console.ReadLine();
        }

        
    }
}
