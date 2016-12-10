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
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}

		private void AdminForm_Load(object sender, EventArgs e)
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
		

		private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{
				MessageBox.Show("No movie selected");
				return;
			}
			Entities context = new Entities();
			Film film = (context.Films.Where(x => x.Id.Equals(movies.SelectedRows[0].Cells[0].Value))).FirstOrDefault();
			MovieInfoForm movieInfo = new MovieInfoForm(film);
			movieInfo.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddMovieForm movieForm = new AddMovieForm();
			movieForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{ 
				MessageBox.Show("No movie selected");
				return;
			}
			Entities context = new Entities();
			Film film = (context.Films.Where(x => x.Id.Equals(movies.SelectedRows[0].Cells[0].Value))).FirstOrDefault();
			AddMovieForm movieForm = new AddMovieForm(film);
			movieForm.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{
				MessageBox.Show("No movie selected");
				return;
			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			AddScreeningForm screeningForm = new AddScreeningForm();
			screeningForm.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (screenings.SelectedRows.Count == 0)
			{
				MessageBox.Show("No screening selected");
				return;
			}
			AddScreeningForm screeningForm = new AddScreeningForm();
			screeningForm.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (screenings.SelectedRows.Count == 0)
			{
				MessageBox.Show("No screening selected");
				return;
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			AddHallForm hallForm = new AddHallForm();
			hallForm.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (halls.SelectedRows.Count == 0)
			{
				MessageBox.Show("No hall selected");
				return;
			}
			AddHallForm hallForm = new AddHallForm();
			hallForm.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (halls.SelectedRows.Count == 0)
			{
				MessageBox.Show("No hall selected");
				return;
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			BuyTicketForm ticketForm = new BuyTicketForm();
			ticketForm.Show();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			SignupForm signupForm = new SignupForm();
			signupForm.Show();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			if (clients.SelectedRows.Count == 0)
			{
				MessageBox.Show("No client selected");
				return;
			}
			SignupForm signupForm = new SignupForm();
			signupForm.Show();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if (clients.SelectedRows.Count == 0)
			{
				MessageBox.Show("No client selected");
				return;
			}
		}
	}
}
