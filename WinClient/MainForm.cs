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
using MovieManagement;

namespace WinClient
{
    public partial class MainForm : Form
    {
        //private List<Movie> movies = new List<Movie>();
        MovieManager manager;


        public MainForm()
        {
            manager = new MovieManager();
            manager.Reset();
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
        //private void AddMovie(Movie movie)
        //{
        //    lstMovies.DataSource = null;
        //    movies.Add(movie);
        //    lstMovies.DataSource = movies;
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {

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
            var addMovieForm = new AddMovieForm(manager);
            var dialogResult = addMovieForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ReloadMovies();
            }
        }

        private void initToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.Reset();
            ReloadMovies();
        }

        private void ReloadMovies()
        {
            lstMovies.DataSource = null;
            lstMovies.DataSource = manager.GetMovies();
        }
    }
}
