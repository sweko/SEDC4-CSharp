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
            //var apocalypseNow = new Movie();
            //apocalypseNow.Title = "Apocalypse Now";
            //apocalypseNow.Year = 1979;
            //apocalypseNow.Duration = new TimeSpan(3, 22, 0);
            //apocalypseNow.Genres = new List<Genre>();
            //apocalypseNow.Genres.Add(Genre.War);
            //apocalypseNow.Genres.Add(Genre.Drama);
            //apocalypseNow.Director = new Person();
            //apocalypseNow.Director.FirstName = "Francis";
            //apocalypseNow.Director.LastName = "Ford Coppola";
            //apocalypseNow.Cast = new List<Person>();
            //apocalypseNow.Cast.Add(new Person());
            //apocalypseNow.Cast[0].FirstName = "Martin";
            //apocalypseNow.Cast[0].LastName = "Sheen";
            //apocalypseNow.Cast.Add(new Person());
            //apocalypseNow.Cast[1].FirstName = "Robert";
            //apocalypseNow.Cast[1].LastName = "Duval";
            //apocalypseNow.Cast.Add(new Person());
            //apocalypseNow.Cast[2].FirstName = "Dennis";
            //apocalypseNow.Cast[2].LastName = "Hopper";
            //apocalypseNow.Cast.Add(new Person());
            //apocalypseNow.Cast[3].FirstName = "Marlon";
            //apocalypseNow.Cast[3].LastName = "Brando";

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
    }
}
