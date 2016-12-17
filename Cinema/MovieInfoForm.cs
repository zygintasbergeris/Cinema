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
	public partial class MovieInfoForm : Form
	{
		private Client client;

		public MovieInfoForm(Movie movie)
		{
			InitializeComponent();
			title.Text = movie.Title;
			year.Text = movie.Year.ToString();
			director.Text = movie.Director;
			duration.Text = movie.Duration.ToString();
			decription.Text = movie.Description;
			LoadScreenings(movie);
		}

		public MovieInfoForm(Movie movie, Client client)
		{
			InitializeComponent();
			title.Text = movie.Title;
			year.Text = movie.Year.ToString();
			director.Text = movie.Director;
			duration.Text = movie.Duration.ToString();
			decription.Text = movie.Description;
			LoadScreenings(movie);
			this.client = client;
		}

		private void LoadScreenings(Movie movie)
		{
			screeningBindingSource.ResetBindings(false);
			var results = CineamaSearchService.SearchScreenings(new CinemaDBEntities(), movie.Id.ToString());
			if (results.Count() != 0)
			{
				screeningBindingSource.DataSource =
					results.Select(screening => new { screening.Id, screening.Movie, screening.Time, screening.Hall }).ToList();
				screenings.DataSource = screeningBindingSource;
			}
		}

		private void MovieInfoForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'cinemaDBDataSet.Screening' table. You can move, or remove it, as needed.
			this.screeningTableAdapter.Fill(this.cinemaDBDataSet.Screening);

		}

		private void search_Click(object sender, EventArgs e)
		{
			screeningBindingSource.ResetBindings(false);
			var results = CineamaSearchService.SearchScreenings(new CinemaDBEntities(), textBox1.Text);
			if (results.Count() != 0)
			{
				screeningBindingSource.DataSource =
					results.Select(screening => new { screening.Id, screening.Movie, screening.Time, screening.Hall }).ToList();
				screenings.DataSource = screeningBindingSource;
			}
		}

		private void buy_Click(object sender, EventArgs e)
		{
			int id = (int)screenings.SelectedRows[0].Cells[0].Value;
			this.Hide();
			Screening screening = ((new CinemaDBEntities()).Screenings.Where(x => x.Id.Equals(id))).FirstOrDefault();
			BuyTicketForm buyTicket;
			if (client == null)
				buyTicket = new BuyTicketForm(screening);
			else
				buyTicket = new BuyTicketForm(screening, client);
			buyTicket.Show();
			buyTicket.FormClosing += (x, args) => this.Close();
		}
	}
}