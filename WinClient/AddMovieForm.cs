using MovieClasses;
using MovieManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinClient
{
    public partial class AddMovieForm : Form
    {
        //scenario 1
        //private MainForm caller;

        //public AddMovieForm(MainForm caller)
        //{
        //    this.caller = caller;
        //    InitializeComponent();
        //}

        //scenario 2
        //public Movie Movie { get; set; }

        private MovieManager movieManager;
        private PersonManager personManager;

        public AddMovieForm(MovieManager manager)
        {
            //scenario 3
            this.movieManager = manager;

            //not-good-but-working
            personManager = new PersonManager();
            personManager.Reset();

            InitializeComponent();
        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            LoadPersons();
        }

        private void LoadPersons()
        {
            cbxDirector.DataSource = null;
            cbxDirector.DataSource = personManager.GetAllPersons();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var director = (Person)cbxDirector.SelectedItem;

            var movie = new Movie(txtTitle.Text, (int)nudYear.Value)
            {
                Director = director
            };

            //var movie = new Movie("Titanic", 1997)
            //{
            //    Duration = new TimeSpan(3, 14, 0),
            //    Director = new Person { FirstName = "James", LastName = "Cameron" },
            //    Genres = new List<Genre> { Genre.Drama, Genre.Romance },
            //    ImdbId = "tt0120338",
            //    Cast = new List<Person>
            //    {
            //        new Person {FirstName = "Leonardo", LastName = "Di Caprio" },
            //        new Person {FirstName = "Kate", LastName = "Winslet" },
            //        new Person {FirstName = "Billy", LastName = "Zane" },
            //    }
            //};

            //scenario 1
            //caller.AddMovie(movie);

            //scenario 2
            //Movie = movie;

            //scenario 3
            movieManager.AddMovie(movie);
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
