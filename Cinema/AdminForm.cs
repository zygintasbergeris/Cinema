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
		private Entities tables;

		public AdminForm()
		{
			InitializeComponent();
			tables = new Entities();
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
				// TODO: This line of code loads data into the 'cinemaDBDataSet.Film' table. You can move, or remove it, as needed.
				this.filmTableAdapter.Fill(this.cinemaDBDataSet.Film);
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

		private void Refresh()
		{
			movies.Update();
			movies.Refresh();
			screenings.Update();
			screenings.Refresh();
			halls.Update();
			halls.Refresh();
			tickets.Update();
			tickets.Refresh();
			clients.Update();
			clients.Refresh();
		}
		

		private void movies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{
				MessageBox.Show("No movie selected");
				return;
			}
			int id = (int)movies.SelectedRows[0].Cells[0].Value;
			Film film = (tables.Films.Where(x => x.Id.Equals(id))).FirstOrDefault();
			MovieInfoForm movieInfo = new MovieInfoForm(film);
			movieInfo.Show();
		}

		private void addMovie_Click(object sender, EventArgs e)
		{
			AddMovieForm movieForm = new AddMovieForm();
			movieForm.Show();
			movieForm.Closing += (x, args) => Refresh();
		}

		private void updateMovie_Click(object sender, EventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{ 
				MessageBox.Show("No movie selected");
				return;
			}
			int id = (int)movies.SelectedRows[0].Cells[0].Value;
			Film film = (tables.Films.Where(x => x.Id.Equals(id))).FirstOrDefault();
			AddMovieForm movieForm = new AddMovieForm(film);
			movieForm.Show();
			movieForm.Closing += (x, args) => Refresh();
		}

		private void removeMovie_Click(object sender, EventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{
				MessageBox.Show("No movie selected");
				return;
			}
			int id = (int)movies.SelectedRows[0].Cells[0].Value;
			tables.Films.Remove((tables.Films.Where(x => x.Id.Equals(id))).FirstOrDefault());
			tables.SaveChanges();
			Refresh();
		}

		private void addScreening_Click(object sender, EventArgs e)
		{
			AddScreeningForm screeningForm = new AddScreeningForm();
			screeningForm.Show();
			screeningForm.Closing += (x, args) => Refresh();
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
			screeningForm.Closing += (x, args) => Refresh();
		}

		private void deleteScreening_Click(object sender, EventArgs e)
		{
			if (screenings.SelectedRows.Count == 0)
			{
				MessageBox.Show("No screening selected");
				return;
			}
			int id = (int)screenings.SelectedRows[0].Cells[0].Value;
			tables.Screenings.Remove((tables.Screenings.Where(x => x.Id.Equals(id))).FirstOrDefault());
			tables.SaveChanges();
			Refresh();
		}

		private void addHall_Click(object sender, EventArgs e)
		{
			AddHallForm hallForm = new AddHallForm();
			hallForm.Show();
			hallForm.Closing += (x, args) => Refresh();
		}

		private void updateHall_Click(object sender, EventArgs e)
		{
			if (halls.SelectedRows.Count == 0)
			{
				MessageBox.Show("No hall selected");
				return;
			}
			short id = (short)halls.SelectedRows[0].Cells[0].Value;
			Hall hall = (tables.Halls.Where(x => x.Id.Equals(id))).FirstOrDefault();
			AddHallForm hallForm = new AddHallForm(hall);
			hallForm.Show();
			hallForm.Closing += (x, args) => Refresh();
		}

		private void deleteHall_Click(object sender, EventArgs e)
		{
			if (halls.SelectedRows.Count == 0)
			{
				MessageBox.Show("No hall selected");
				return;
			}
			short id = (short)screenings.SelectedRows[0].Cells[0].Value;
			tables.Halls.Remove((tables.Halls.Where(x => x.Id.Equals(id))).FirstOrDefault());
			tables.SaveChanges();
			Refresh();
		}

		private void buyTicket_Click(object sender, EventArgs e)
		{
			BuyTicketForm ticketForm = new BuyTicketForm();
			ticketForm.Show();
			ticketForm.Closing += (x, args) => Refresh();
		}

		private void addClient_Click(object sender, EventArgs e)
		{
			SignupForm signupForm = new SignupForm();
			signupForm.Show();
			signupForm.Closing += (x, args) => Refresh();
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
			signupForm.Closing += (x, args) => Refresh();
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
			Refresh();
		}

		private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.SaveChanges();
			tables.Dispose();
		}
	}
}
