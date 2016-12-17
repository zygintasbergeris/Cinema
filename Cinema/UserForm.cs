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
			// TODO: This line of code loads data into the 'cinemaDBDataSet.Ticket' table. You can move, or remove it, as needed.
			this.ticketTableAdapter.Fill(this.cinemaDBDataSet.Ticket);
			// TODO: This line of code loads data into the 'cinemaDBDataSet.Screening' table. You can move, or remove it, as needed.
			this.screeningTableAdapter.Fill(this.cinemaDBDataSet.Screening);
			// TODO: This line of code loads data into the 'cinemaDBDataSet.Movie' table. You can move, or remove it, as needed.
			this.movieTableAdapter.Fill(this.cinemaDBDataSet.Movie);
			screenings.Columns[0].Visible = false;
			tickets.Columns[0].Visible = false;
		}

		private void movies_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ShowMovieInfo();
		}

		private void ShowMovieInfo()
		{
			int id = (int) movies.SelectedRows[0].Cells[0].Value;
			Movie movie = (tables.Movies.Where(x => x.Id.Equals(id))).FirstOrDefault();
			MovieInfoForm movieInfo = new MovieInfoForm(movie, client);
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
			foreach (DataGridViewRow row in screenings.Rows)
			{
				int id = (int)row.Cells[1].Value;
				row.Cells[2].Value = tables.Movies.Where(m => m.Id == id).Select(m => m.Title).ToList().First();
			}
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
				case 2:
					RefreshTickets();
					break;
			}
		}

		private void RefreshTickets()
		{
			searchTickets.Clear();
			ticketBindingSource.ResetBindings(false);
			var result = tables.Tickets.Join(tables.Bookings, t => t.Id, b => b.Ticket, (t, b) => t).ToList();
			ticketBindingSource.DataSource = result;
			tickets.DataSource = ticketBindingSource;
			
			foreach (DataGridViewRow row in tickets.Rows)
			{
				int id = (int)row.Cells[0].Value;
				var screening = tables.Screenings.First(s => s.Id == id);
				row.Cells[1].Value = screening.Movie1.Title;
				row.Cells[2].Value = screening.Time;
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
			if (tabControl1.SelectedIndex == 0)
			{
				if (movies.SelectedRows.Count == 0)
				{
					MessageBox.Show("No movie selected");
					return;
				}
				ShowMovieInfo();
			}
			else if (tabControl1.SelectedIndex == 1)
			{
				if (screenings.SelectedRows.Count == 0)
				{
					MessageBox.Show("No screening selected");
					return;
				}
				BuyTicketForm buyTicket = new BuyTicketForm(
					CineamaSearchService.SearchScreenings(tables, screenings.SelectedRows[0].Cells[0].Value.ToString()).First(), client);
				buyTicket.Show();
			}
			else
			{
				BuyTicketForm buyTicket = new BuyTicketForm(client);
				buyTicket.Show();
				RefreshTickets();
			}
		}

		private void searchTicketsButton_Click(object sender, EventArgs e)
		{
			ticketBindingSource.ResetBindings(false);
			var results = CineamaSearchService.SearchTickets(tables, searchTickets.Text);
			if (results.Count() != 0)
			{
				ticketBindingSource.DataSource =
					results.Select(ticket => new { ticket.Id, ticket.Screening, ticket.Hall, ticket.Seat, ticket.Price }).ToList();
				tickets.DataSource = ticketBindingSource;
			}
		}
	}
}
