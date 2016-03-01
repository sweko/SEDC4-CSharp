using MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement
{
    public class MovieManager
    {
        private PersonManager personManager;

        public MovieManager(PersonManager personManager)
        {
            this.personManager = personManager;
        }

        private List<Movie> movies = new List<Movie>();

        private List<Movie> GetDefaultMovies()
        {
            personManager.Reset();
            var apocalypseNow = new Movie("Apocalypse Now", 1979)
            {
                Duration = new TimeSpan(3, 22, 0),
                Genres = new List<Genre> { Genre.War, Genre.Drama },
                Director = personManager.GetPersonById(1),
                Cast = new List<Person>() {
                    personManager.GetPersonById(2),
                    personManager.GetPersonById(3),
                    personManager.GetPersonById(4),
                    personManager.GetPersonById(5),
                },
            };

            var pulpFiction = new Movie("Pulp Fiction", 1994)
            {
                Duration = new TimeSpan(2, 33, 0),
                Genres = new List<Genre> { Genre.Crime },
                Director = personManager.GetPersonById(9),
                Cast = new List<Person>
                {
                    personManager.GetPersonById(6),
                    personManager.GetPersonById(7),
                    personManager.GetPersonById(8),
                    personManager.GetPersonById(9),
                }
            };

            var fightClub = new Movie("Fight Club", 1999)
            {
                Duration = new TimeSpan(2, 19, 0),
                Genres = new List<Genre> { Genre.Drama },
                Director = personManager.GetPersonById(13),
                Cast = new List<Person>
                {
                    personManager.GetPersonById(10),
                    personManager.GetPersonById(11),
                    personManager.GetPersonById(12)
                }
            };

            var lepaSela = new Movie("Lepa Sela Lepo Gore", 1996)
            {
                Duration = new TimeSpan(1, 55, 0),
                Genres = new List<Genre> { Genre.War, Genre.Drama, Genre.Comedy },
                Director = personManager.GetPersonById(27),
                Cast = new List<Person>
                {
                    personManager.GetPersonById(14),
                    personManager.GetPersonById(15),
                    personManager.GetPersonById(16)
                }
            };

            var shawshank = new Movie("The Shawshank Redemption", 1994)
            {
                Duration = new TimeSpan(2, 22, 0),
                Genres = new List<Genre> { Genre.Drama, Genre.Crime },
                Director = personManager.GetPersonById(28),
                Cast = new List<Person>
                {
                    personManager.GetPersonById(17),
                    personManager.GetPersonById(18),
                    personManager.GetPersonById(19)
                }
            };

            var keyserSose = new Movie("The Usual Suspects", 1995)
            {
                Duration = new TimeSpan(1, 46, 0),
                Genres = new List<Genre> { Genre.Drama, Genre.Crime },
                Director = personManager.GetPersonById(29),
                Cast = new List<Person>
                {
                    personManager.GetPersonById(20),
                    personManager.GetPersonById(21),
                    personManager.GetPersonById(22)
                }
            };

            var nbk = new Movie("Natural Born Killers", 1994)
            {
                Duration = new TimeSpan(1, 58, 0),
                Genres = new List<Genre> { Genre.Drama, Genre.Crime },
                Director = personManager.GetPersonById(30),
                Cast = new List<Person>
                {
                    personManager.GetPersonById(23),
                    personManager.GetPersonById(24),
                    personManager.GetPersonById(25),
                    personManager.GetPersonById(26),
                }
            };

            var movies = new List<Movie> {
                apocalypseNow,
                pulpFiction,
                fightClub,
                lepaSela,
                shawshank,
                keyserSose,
                nbk
            };

            return movies;
        }

        public void DeleteMovie(Movie movie)
        {
            movies.Remove(movie);
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public void Reset()
        {
            movies = GetDefaultMovies();
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
    }
}
