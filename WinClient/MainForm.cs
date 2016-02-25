using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieClasses;


namespace WinClient
{
    public partial class MainForm : Form
    {
        private List<Movie> movies = new List<Movie>();

        public MainForm()
        {
            InitializeComponent();
        }

        //Scenario 1
        //public void AddMovie(Movie movie)
        //{
        //    lstMovies.DataSource = null;
        //    movies.Add(movie);
        //    lstMovies.DataSource = movies;
        //}

        //scenario 2
        private void AddMovie(Movie movie)
        {
            lstMovies.DataSource = null;
            movies.Add(movie);
            lstMovies.DataSource = movies;
        }

        private void InitMovies()
        {
            var apocalypseNow = new Movie("Apocalypse Now", 1979)
            {
                Duration = new TimeSpan(3, 22, 0),
                Genres = new List<Genre> { Genre.War, Genre.Drama },
                Director = new Person { FirstName = "Francis", LastName = "Ford Coppola" },
                Cast = new List<Person>() {
                    new Person {FirstName = "Martin", LastName = "Sheen" },
                    new Person {FirstName = "Robert", LastName = "Duval"},
                    new Person {FirstName = "Dennis", LastName = "Hopper"},
                    new Person { FirstName = "Marlon", LastName = "Brando"}
                },
            };

            var pulpFiction = new Movie("Pulp Fiction", 1994)
            {
                Duration = new TimeSpan(2, 33, 0),
                Genres = new List<Genre> { Genre.Crime },
                Director = new Person { FirstName = "Quentin", LastName = "Tarantino" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "John", LastName = "Travolta" },
                    new Person {FirstName = "Samuel", LastName = "Jackson" },
                    new Person {FirstName = "Bruce", LastName = "Willis" },
                    new Person {FirstName = "Quentin", LastName="Tarantino"},
                }
            };

            var fightClub = new Movie("Fight Club", 1999)
            {
                Duration = new TimeSpan(2, 19, 0),
                Genres = new List<Genre> { Genre.Drama },
                Director = new Person { FirstName = "David", LastName = "Fincher" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "Brad", LastName = "Pitt" },
                    new Person {FirstName = "Edward", LastName = "Norton" },
                    new Person {FirstName = "Helena", LastName = "Bonham Carter" },
                }
            };

            var lepaSela = new Movie("Lepa Sela Lepo Gore", 1996)
            {
                Duration = new TimeSpan(1, 55, 0),
                Genres = new List<Genre> { Genre.War, Genre.Drama, Genre.Comedy },
                Director = new Person { FirstName = "Srdjan", LastName = "Dragojevic" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "Dragan", LastName = "Bjelogrlic" },
                    new Person {FirstName = "Nikola", LastName = "Kojo" },
                    new Person {FirstName = "Zoran", LastName = "Cvijanovic" },
                }
            };

            var shawshank = new Movie("The Shawshank Redemption", 1994)
            {
                Duration = new TimeSpan(2, 22, 0),
                Genres = new List<Genre> { Genre.Drama, Genre.Crime },
                Director = new Person { FirstName = "Frank", LastName = "Darabond" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "Tim", LastName = "Robbins" },
                    new Person {FirstName = "Morgan", LastName = "Freemen" },
                    new Person {FirstName = "Bob", LastName = "Gunton" },
                }
            };

            var keyserSose = new Movie("The Usual Suspects", 1995)
            {
                Duration = new TimeSpan(1, 46, 0),
                Genres = new List<Genre> { Genre.Drama, Genre.Crime },
                Director = new Person { FirstName = "Bryan", LastName = "Singer" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "Kevin", LastName = "Spacey" },
                    new Person {FirstName = "Chazz", LastName = "Palminteri" },
                    new Person {FirstName = "Gabriel", LastName = "Byrne" },
                }
            };

            var nbk = new Movie("Natural Born Killers", 1994)
            {
                Duration = new TimeSpan(1, 58, 0),
                Genres = new List<Genre> { Genre.Drama, Genre.Crime },
                Director = new Person { FirstName = "Oliver", LastName = "Stone" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "Woody", LastName = "Harrelson" },
                    new Person {FirstName = "Juliette", LastName = "Lewis" },
                    new Person {FirstName = "Tom", LastName = "Sizemore" },
                    new Person {FirstName = "Robert", LastName = "Downey Jr" },
                }
            };

            movies.Add(apocalypseNow);
            movies.Add(pulpFiction);
            movies.Add(fightClub);
            movies.Add(lepaSela);
            movies.Add(shawshank);
            movies.Add(keyserSose);
            movies.Add(nbk);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lstMovies.DataSource = movies;
        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMovies.SelectedItem == null)
                return;

            var movie = (Movie)lstMovies.SelectedItem;
            lblTitle.Text = movie.Title;
            lblYear.Text = movie.Year.ToString();
            lblDuration.Text = $"{movie.Duration.TotalMinutes} min";
            lblDirector.Text = movie.Director.ToString();
            lblGenres.Text = GetMovieGenreString(movie.Genres);
            lblCast.Text = GetMovieCastString(movie.Cast);
        }

        private string GetMovieCastString(List<Person> cast)
        {
            string result = string.Empty;
            foreach (var actor in cast)
            {
                result += actor.ToString() + Environment.NewLine;
            }
            return result;
        }

        private string GetMovieGenreString(List<Genre> genres)
        {
            return string.Join(", ", genres);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addMovieForm = new AddMovieForm();
            var dialogResult = addMovieForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                AddMovie(addMovieForm.Movie);
            }
        }

        private void initToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstMovies.DataSource = null;
            InitMovies();
            lstMovies.DataSource = movies;
        }
    }
}
