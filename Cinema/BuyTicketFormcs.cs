using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
	public partial class BuyTicketForm : Form
	{
		/*
		 * 6 ticket buying options:
		 * admin buy						--no info
		 * admin buy from screenings		--movie and screening, no user
		 * admin buy from movie screenings	--movie and screening, no user
		 * user buy							--user, no movie, screening
		 * user buy from screenings			--movie and screening and user
		 * user buy from movie screenings	--movie and screening and user
		 */

		private CinemaDBEntities tables;
		private Screening screening;
		private int ticketPrice;
		private Client client;

		public BuyTicketForm()
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			LoadClients();
			LoadMovies();
		}

		public BuyTicketForm(Client client)
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			this.client = client;
			LoadClients();
			LoadMovies();
		}

		public BuyTicketForm(Screening screening)
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			this.screening = screening;
			LoadClients();
			LoadMovies();
		}

		public BuyTicketForm(Screening screening, Client client)
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			this.screening = screening;
			this.client = client;
			LoadClients();
			LoadMovies();
		}

		private void LoadClients()
		{
			if (client != null)
			{
				users.Items.Add(client.Id + ", " + client.FirstName + " " + client.LastName);
				users.SelectedItem = users.Items[0];
				return;
			}
			this.users.Items.Add("No user");
			foreach (var cl in tables.Clients)
			{
				string name = cl.Id + ", " + cl.FirstName + " " + cl.LastName;
				users.Items.Add(name);
				users.SelectedItem = users.Items[0];
			}
		}

		private void LoadMovies()
		{
			if (screening != null)
			{
				movies.Items.Add(screening.Movie1.Title);
				movies.SelectedItem = movies.Items[0];
				return;
			}
			foreach (var movie in tables.Movies)
			{
				movies.Items.Add(movie.Title);
			}
		}

		private void movies_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (screening != null)
			{
				screenings.Items.Add(screening.Id + ", " + screening.Time + " " + screening.Hall);
				screenings.SelectedItem = screenings.Items[0];
				return;
			}
			Movie movie = CineamaSearchService.SearchMovies(tables, movies.SelectedItem.ToString()).FirstOrDefault();
			var result = tables.Screenings.Where((s) => s.Movie.Equals(movie.Id));
			screenings.Items.Clear();
			foreach (var res in result)
			{
				string str = res.Id + ", " + res.Time + " " + res.Hall;
				screenings.Items.Add(str);
			}
		}

		private void screenings_TextChanged(object sender, EventArgs e)
		{
			if (screening != null)
				return;
			string[] res = screenings.SelectedItem.ToString().Split(',');
			screening = CineamaSearchService.SearchScreenings(tables, res[0]).FirstOrDefault();
		}

		private void users_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (client == null)
			{
				if (users.SelectedItem.ToString().Contains("No user"))
				{
					price.Text = "6€";
					ticketPrice = 6;
					return;
				}
				string values = (users.SelectedItem.ToString().Split(','))[0];
				client = tables.Clients.First(x => values.Equals(x.Id.ToString()));
			}
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

		private void button1_Click(object sender, EventArgs e)
		{
			Ticket ticket = new Ticket();
			ticket.Hall = screening.Hall;
			ticket.Screening = screening.Id;
			ticket.Price = ticketPrice;

			var screeningTickets = tables.Tickets.Where(x => x.Screening == screening.Id);
			var screeningSeats = tables.Seats.GroupJoin(
				screeningTickets,
				s => s.Id,
				t => t.Seat,
				(s, t) => new {Tickets = t, Seat = s}).SelectMany(
				x => x.Tickets.DefaultIfEmpty(null),
				(x, y) => new { x.Seat, Ticket = y});
			var freeSeats = screeningSeats.Where(x => x.Ticket == null).ToList();
			
			//foreach (var v in freeSeats)
			//{
			//	string value;
			//	if (v.Ticket == null)
			//		value = "null";
			//	else
			//	{
			//		value = v.Ticket.Id + " " + v.Ticket.Screening;
			//	}
			//	Console.WriteLine(v.Seat.Hall + " " + v.Seat.Id + " " + value);
			//}
			//Console.WriteLine(freeSeats.Count());
			//Console.WriteLine();
			int amount = Convert.ToInt32(numericUpDown1.Value);
			if (!freeSeats.Any())
			{
				MessageBox.Show("All tickets are sold to selected screening");
			}
			if (amount > freeSeats.Count())
			{
				MessageBox.Show($"Amount {amount} exceeds number of free seats {freeSeats.Count()} in selected screening");
				return;
			}

			for (int j = 1; j <= amount; j++)
			{
				//for (int i = 1; i <= screening.Hall1.NumberOfSeats; i++) //Improve algorithm?
				//{
				//	var x = screening.Tickets.FirstOrDefault(y => y.Seat == i);
				//	if (x != null)
				//		continue;
				//	ticket.Seat = i;
				var seat = freeSeats.First();
				ticket.Seat = seat.Seat.Id;
				tables.Tickets.Add(ticket);
				freeSeats.Remove(seat);
				if (client != null)
				{
					Booking booking = new Booking();
					booking.Client = client.Id;
					booking.Ticket = ticket.Id;
					tables.Bookings.Add(booking);
				}
				tables.SaveChanges();
				//	break;
				//}
			}
			if (tables.Tickets.Contains(ticket))
				this.Close();
			else
				MessageBox.Show("Can't buy ticket. All tickets are sold");
		}

		private void BuyTicketForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.Dispose();
		}
	}
}
