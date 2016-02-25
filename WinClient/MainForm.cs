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
            var apocalypseNow = new Movie ("Apocalypse Now", 1979)
            {
                Duration = new TimeSpan(3, 22, 0),
                Genres = new List<Genre>{Genre.War, Genre.Drama },
                Director = new Person { FirstName = "Francis", LastName = "Ford Coppola"},
                Cast = new List<Person>() {
                    new Person {FirstName = "Martin", LastName = "Sheen" },
                    new Person {FirstName = "Robert", LastName = "Duval"},
                    new Person {FirstName = "Dennis", LastName = "Hopper"},
                    new Person { FirstName = "Marlon", LastName = "Brando"}
                },
            };

            var pulpFiction = new Movie("Pulp Fiction", 1993)
            {
                Duration = new TimeSpan(2, 15, 0),
                Genres = new List<Genre> { Genre.Crime },
                Director = new Person { FirstName = "Quentin", LastName = "Tarantino" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "John", LastName = "Travolta" },
                    new Person {FirstName = "Samuel", LastName = "Jackson" },
                    new Person {FirstName = "Bruce", LastName = "Willis" },
                    new Person { FirstName = "Quentin", LastName="Tarantino"},
                }
            };

            movies.Add(apocalypseNow);
            movies.Add(pulpFiction);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lstMovies.DataSource = movies;
        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            var movie = (Movie)lstMovies.SelectedItem;
            lblTitle.Text = movie.Title;
            lblYear.Text = movie.Year.ToString();
        }
    }
}
