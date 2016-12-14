using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cinema
{
	public partial class AdminForm : Form
	{
		private CinemaDBEntities tables;

		public AdminForm()
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			try
			{
				// TODO: This line of code loads data into the 'cinemaDBDataSet.Client' table. You can move, or remove it, as needed.
				this.clientTableAdapter.Fill(this.cinemaDBDataSet.Client);
				// TODO: This line of code loads data into the 'cinemaDBDataSet.Booking' table. You can move, or remove it, as needed.
				this.bookingTableAdapter.Fill(this.cinemaDBDataSet.Booking);
				// TODO: This line of code loads data into the 'cinemaDBDataSet.Ticket' table. You can move, or remove it, as needed.
				this.ticketTableAdapter.Fill(this.cinemaDBDataSet.Ticket);
				// TODO: This line of code loads data into the 'cinemaDBDataSet.Movie' table. You can move, or remove it, as needed.
				this.movieTableAdapter.Fill(this.cinemaDBDataSet.Movie);
				// TODO: This line of code loads data into the 'cinemaDBDataSet.Screening' table. You can move, or remove it, as needed.
				this.screeningTableAdapter.Fill(this.cinemaDBDataSet.Screening);
				// TODO: This line of code loads data into the 'cinemaDBDataSet.Hall' table. You can move, or remove it, as needed.
				this.hallTableAdapter.Fill(this.cinemaDBDataSet.Hall);
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void movies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{
				MessageBox.Show("No movie selected");
				return;
			}
			int id = (int) movies.SelectedRows[0].Cells[0].Value;
			Movie movie = (tables.Movies.Where(x => x.Id.Equals(id))).FirstOrDefault();
			MovieInfoForm movieInfo = new MovieInfoForm(movie);
			movieInfo.Show();
		}

		private void addMovie_Click(object sender, EventArgs e)
		{
			AddMovieForm movieForm = new AddMovieForm();
			movieForm.Show();
			movieForm.Closing += (x, args) => AdminForm_Load(this, new EventArgs());
		}

		private void updateMovie_Click(object sender, EventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{
				MessageBox.Show("No movie selected");
				return;
			}
			int id = (int) movies.SelectedRows[0].Cells[0].Value;
			Movie movie = (tables.Movies.Where(x => x.Id.Equals(id))).FirstOrDefault();
			AddMovieForm movieForm = new AddMovieForm(movie);
			movieForm.Show();
			movieForm.Closing += (x, args) => AdminForm_Load(this, new EventArgs());
		}

		private void removeMovie_Click(object sender, EventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{
				MessageBox.Show("No movie selected");
				return;
			}
			int id = (int) movies.SelectedRows[0].Cells[0].Value;
			try
			{
				tables.Movies.Remove((tables.Movies.Where(x => x.Id.Equals(id))).FirstOrDefault());
				tables.SaveChanges();
			}
			catch (Exception)
			{
				MessageBox.Show("Can't remove movie. Selected movie has planed screenings");
			}

			AdminForm_Load(this, new EventArgs());
		}

		private void addScreening_Click(object sender, EventArgs e)
		{
			AddScreeningForm screeningForm = new AddScreeningForm();
			screeningForm.Show();
			screeningForm.Closing += (x, args) => AdminForm_Load(this, new EventArgs());
		}

		private void updateScreening_Click(object sender, EventArgs e)
		{
			if (screenings.SelectedRows.Count == 0)
			{
				MessageBox.Show("No screening selected");
				return;
			}
			int id = (int) screenings.SelectedRows[0].Cells[0].Value;
			Screening screening = (tables.Screenings.Where(x => x.Id.Equals(id))).FirstOrDefault();
			AddScreeningForm screeningForm = new AddScreeningForm(screening);
			screeningForm.Show();
			screeningForm.Closing += (x, args) => AdminForm_Load(this, new EventArgs());
		}

		private void deleteScreening_Click(object sender, EventArgs e)
		{
			if (screenings.SelectedRows.Count == 0)
			{
				MessageBox.Show("No screening selected");
				return;
			}
			int id = (int) screenings.SelectedRows[0].Cells[0].Value;
			try
			{
				tables.Screenings.Remove((tables.Screenings.Where(x => x.Id.Equals(id))).FirstOrDefault());
				tables.SaveChanges();
			}
			catch (Exception)
			{
				MessageBox.Show("Can't remove screening. Selected screening has sold tickets");
			}
			
			AdminForm_Load(this, new EventArgs());
		}

		private void addHall_Click(object sender, EventArgs e)
		{
			AddHallForm hallForm = new AddHallForm();
			hallForm.Show();
			hallForm.Closing += (x, args) => AdminForm_Load(this, new EventArgs());
		}

		private void deleteHall_Click(object sender, EventArgs e)
		{
			if (halls.SelectedRows.Count == 0)
			{
				MessageBox.Show("No hall selected");
				return;
			}
			short id = (short) halls.SelectedRows[0].Cells[0].Value;
			try
			{
				tables.Halls.Remove((tables.Halls.Where(x => x.Id.Equals(id))).FirstOrDefault());
				tables.SaveChanges();
			}
			catch (Exception)
			{
				MessageBox.Show("Can't remove hall. Selected hall has planed screenings");
			}
		
			AdminForm_Load(this, new EventArgs());
		}

		private void buyTicket_Click(object sender, EventArgs e)
		{
			BuyTicketForm ticketForm = new BuyTicketForm();
			ticketForm.Show();
			ticketForm.Closing += (x, args) => AdminForm_Load(this, new EventArgs());
		}

		private void addClient_Click(object sender, EventArgs e)
		{
			SignupForm signupForm = new SignupForm();
			signupForm.Show();
			signupForm.Closing += (x, args) => AdminForm_Load(this, new EventArgs());
		}

		private void updateClient_Click(object sender, EventArgs e)
		{
			if (clients.SelectedRows.Count == 0)
			{
				MessageBox.Show("No client selected");
				return;
			}
			int id = (int)clients.SelectedRows[0].Cells[0].Value;
			Client client= (tables.Clients.Where(x => x.Id.Equals(id))).FirstOrDefault();
			SignupForm signupForm = new SignupForm(client);
			signupForm.Show();
			signupForm.Closing += (x, args) => AdminForm_Load(this, new EventArgs());
		}

		private void deleteClient_Click(object sender, EventArgs e)
		{
			if (clients.SelectedRows.Count == 0)
			{
				MessageBox.Show("No client selected");
				return;
			}
			int id = (int)clients.SelectedRows[0].Cells[0].Value;
			tables.Clients.Remove((tables.Clients.Where(x => x.Id.Equals(id))).FirstOrDefault());
			tables.SaveChanges();
			AdminForm_Load(this, new EventArgs());
		}

		private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.SaveChanges();
			tables.Dispose();
		}

		private void searchMoviesButton_Click(object sender, EventArgs e)
		{
			movieBindingSource.ResetBindings(false);
			var results = CineamaSearchService.SearchMovies(tables, searchMovies.Text);
			if (results.Count() != 0)
			{
				movieBindingSource.DataSource = 
					results.Select(movie => new {movie.Id, movie.Title, movie.Year, movie.Director, movie.Duration}).ToList();
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
					results.Select(screening => new {screening.Id, screening.Movie, screening.Time, screening.Hall}).ToList();
				screenings.DataSource = screeningBindingSource;
			}
		}

		private void searchHallsButton_Click(object sender, EventArgs e)
		{
			hallBindingSource.ResetBindings(false);
			var results = CineamaSearchService.SearchHalls(tables, searchHalls.Text);
			if (results.Count() != 0)
			{
				hallBindingSource.DataSource = results.Select(hall => new {hall.Id, hall.NumberOfSeats}).ToList();
				halls.DataSource = hallBindingSource;
			}
		}

		private void searchTicketsButton_Click(object sender, EventArgs e)
		{
			ticketBindingSource.ResetBindings(false);
			var results = CineamaSearchService.SearchTickets(tables, searchTickets.Text);
			if (results.Count() != 0)
			{
				ticketBindingSource.DataSource =
					results.Select(ticket => new {ticket.Id, ticket.Screening, ticket.Hall, ticket.Seat, ticket.Price}).ToList();
				tickets.DataSource = ticketBindingSource;
			}
		}

		private void searchClientsButton_Click(object sender, EventArgs e)
		{
			clientBindingSource.ResetBindings(false);
			var results = CineamaSearchService.SearchClients(tables, searchClients.Text);
			if (results.Count() != 0)
			{
				clientBindingSource.DataSource =
					results.Select(client => new {client.Id, client.FirstName, client.LastName, client.DateOfBirth, client.Email}).ToList();
				clients.DataSource = clientBindingSource;
			}
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl.SelectedIndex)
			{
				case 0:
					RefreshMovies();
					break;
				case 1:
					RefreshScreenings();
					break;
				case 2:
					RefreshHalls();
					break;
				case 3:
					RefreshTickets();
					break;
				case 4:
					RefreshClients();
					break;
			}
		}

		private void RefreshMovies()
		{
			searchMovies.Clear();
			movieBindingSource.ResetBindings(false);
			movieBindingSource.DataSource = cinemaDBDataSet;
			movieBindingSource.DataMember = "Movie";
		}

		private void RefreshTickets()
		{
			searchTickets.Clear();
			ticketBindingSource.ResetBindings(false);
			ticketBindingSource.DataSource = cinemaDBDataSet;
			ticketBindingSource.DataMember = "Ticket";
		}

		private void RefreshScreenings()
		{
			searchScreenings.Clear();
			screeningBindingSource.ResetBindings(false);
			screeningBindingSource.DataSource = cinemaDBDataSet;
			screeningBindingSource.DataMember = "Screening";
		}

		private void RefreshClients()
		{
			searchClients.Clear();
			clientBindingSource.ResetBindings(false);
			clientBindingSource.DataSource = cinemaDBDataSet;
			clientBindingSource.DataMember = "Client";
		}

		private void RefreshHalls()
		{
			searchHalls.Clear();
			hallBindingSource.ResetBindings(false);
			hallBindingSource.DataSource = cinemaDBDataSet;
			hallBindingSource.DataMember = "Hall";
		}
		
	}
}
