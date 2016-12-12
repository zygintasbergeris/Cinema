using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
	public partial class AddHallForm : Form
	{
		private CinemaDBEntities tables;

		public AddHallForm()
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int numOfSeats;
			if (!int.TryParse(textBox1.Text, out numOfSeats) || textBox1.Text.Equals("0"))
				MessageBox.Show("Invalid number format");
			Hall hall = new Hall();
			hall.NumberOfSeats = Convert.ToInt32(textBox1.Text);
			tables.Halls.AddOrUpdate(hall);
			tables.SaveChanges();
			PopulateHall(hall);
			this.Close();
		}
		private void AddHallForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.Dispose();
		}

		private void PopulateHall(Hall hall)
		{
			for (int i = 1; i <= hall.NumberOfSeats; i++)
			{
				Seat s = new Seat();
				s.Hall = hall.Id;
				s.Id = i;
				tables.Seats.Add(s);
			}
			tables.SaveChanges();
		}
	}
}
