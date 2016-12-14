using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
	public partial class UserForm : Form
	{
		private CinemaDBEntities tables;
		private Client client;

		public UserForm(Client client)
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			this.client = client;
		}

		private void UserForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'cinemaDBDataSet.Screening' table. You can move, or remove it, as needed.
			this.screeningTableAdapter.Fill(this.cinemaDBDataSet.Screening);
			// TODO: This line of code loads data into the 'cinemaDBDataSet.Movie' table. You can move, or remove it, as needed.
			this.movieTableAdapter.Fill(this.cinemaDBDataSet.Movie);
			var screeningsMovies = tables.Screenings.Join(tables.Movies, s => s.Movie, m => m.Id,
				(s, m) => new {s.Id, s.Movie, m.Title, s.Time, s.Hall});
			screeningBindingSource.ResetBindings(false);
			screeningBindingSource.DataSource = screeningsMovies.ToList();
			screenings.DataSource = screeningBindingSource;
			//screenings.Columns["Id"].Visible = false;
		}

		private void movies_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{
				MessageBox.Show("No movie selected");
				return;
			}
			int id = (int)movies.SelectedRows[0].Cells[0].Value;
			Movie movie = (tables.Movies.Where(x => x.Id.Equals(id))).FirstOrDefault();
			MovieInfoForm movieInfo = new MovieInfoForm(movie);
			movieInfo.Show();
		}

		private void searchMoviesButton_Click(object sender, EventArgs e)
		{
			movieBindingSource.ResetBindings(false);
			var results = CineamaSearchService.SearchMovies(tables, searchMovies.Text);
			if (results.Count() != 0)
			{
				movieBindingSource.DataSource =
					results.Select(movie => new { movie.Id, movie.Title, movie.Year, movie.Director, movie.Duration }).ToList();
				movies.DataSource = movieBindingSource;
			}
		}

		private void searchScreeningsButton_Click(object sender, EventArgs e)
		{
			screeningBindingSource.ResetBindings(false);
			var results = CineamaSearchService.SearchScreenings(tables, searchScreenings.Text);
			if (results.Count() != 0)
			{
				screeningBindingSource.DataSource =
					results.Select(screening => new { screening.Id, screening.Movie, screening.Time, screening.Hall }).ToList();
				screenings.DataSource = screeningBindingSource;
			}
		}

		private void RefreshMovies()
		{
			searchMovies.Clear();
			movieBindingSource.ResetBindings(false);
			movieBindingSource.DataSource = cinemaDBDataSet;
			movieBindingSource.DataMember = "Movie";
		}

		private void RefreshScreenings()
		{
			searchScreenings.Clear();
			screeningBindingSource.ResetBindings(false);
			screeningBindingSource.DataSource = cinemaDBDataSet;
			screeningBindingSource.DataMember = "Screening";
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl1.SelectedIndex)
			{
				case 0:
					RefreshMovies();
					break;
				case 1:
					RefreshScreenings();
					break;
			}
		}

		private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.SaveChanges();
			tables.Dispose();
		}

		private void clientInfo_Click(object sender, EventArgs e)
		{
			SignupForm signupForm = new SignupForm(client);
			signupForm.Show();
			signupForm.Closing += (x, args) => UserForm_Load(this, new EventArgs());
		}

		private void buy_Click(object sender, EventArgs e)
		{
			//act differently with screenings, movies
		}
	}
}
