using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
	public partial class BuyTicketForm : Form
	{
		private CinemaDBEntities tables;
		private Screening screening;
		private int ticketPrice;

		public BuyTicketForm()
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			LoadData();
			screening = new Screening();
		}

		private void LoadData()
		{
			this.users.Items.Add("No user");
			foreach (var client in tables.Clients)
			{
				string name = client.Id + ", " + client.FirstName + " " + client.LastName;
				this.users.Items.Add(name);
			}
			foreach (var movie in tables.Movies)
			{
				this.movies.Items.Add(movie.Title);
			}
		}

		public BuyTicketForm(Screening screening)
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			this.screening = screening;
			LoadData();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Regex pattern = new Regex(@"^\d{1,}.{0,2}$");
			if (!pattern.IsMatch(credit.Text) || Convert.ToDecimal(credit.Text) < 0)
			{
				MessageBox.Show("Invalid credit. Use format XX.XX");
			}
			if (Convert.ToDecimal(credit.Text) < ticketPrice)
			{
				MessageBox.Show("Insuficiet credit");
				return;
			}
			Ticket ticket = new Ticket();
			ticket.Hall = screening.Hall;
			ticket.Screening = screening.Id;
			ticket.Price = ticketPrice;
			
			for (int i = 1; i <= screening.Hall1.NumberOfSeats; i++)
			{
				var x = screening.Tickets.FirstOrDefault(y => y.Seat == i);
				if (x == null)
				{
					ticket.Seat = i;
					try
					{
						tables.Tickets.Add(ticket);
						tables.SaveChanges();
					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.Message);
					}
					break;
				}
			}
			if (screening.Tickets.Contains(ticket)) 
				this.Close();
		}

		private void movies_SelectedIndexChanged(object sender, EventArgs e)
		{
			Movie movie = CineamaSearchService.SearchMovies(tables, movies.SelectedItem.ToString()).FirstOrDefault();
			var result = tables.Screenings.Where((s) => s.Movie.Equals(movie.Id));
			screenings.Items.Clear();
			foreach (var res in result)
			{
				string str = res.Id + ", " + res.Time + " " + res.Hall;
				screenings.Items.Add(str); 
			}
		}

		private void users_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (users.SelectedItem.ToString().Contains("No user"))
			{
				price.Text = "6€";
				ticketPrice = 6;
				return;
			}
			string values = (users.SelectedItem.ToString().Split(','))[0];
			Client client = tables.Clients.First(x => values.Equals(x.Id.ToString()));
			int years = DateTime.Today.Year - client.DateOfBirth.Year;
			if (DateTime.Today.DayOfYear >= client.DateOfBirth.DayOfYear)
				years++;
			if (years < 18)
			{
				price.Text = "4€";
				ticketPrice = 4;
			}
			else
			{
				price.Text = "5€";
				ticketPrice = 5;
			}
		}

		private void BuyTicketForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.Dispose();
		}

		private void screenings_TextChanged(object sender, EventArgs e)
		{
			string[] res = screenings.SelectedItem.ToString().Split(',');
			screening = CineamaSearchService.SearchScreenings(tables, res[0]).FirstOrDefault();
		}
	}
}
