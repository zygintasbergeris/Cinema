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
		Hall hall;

		public AddHallForm()
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			hall = new Hall();
		}

		public AddHallForm(Hall hall)
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			textBox1.Text = hall.NumberOfSeats.ToString();
			this.Text = "Edit hall";
			button1.Text = "Edit hall";
			this.hall = hall;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int numOfSeats;
			if (!int.TryParse(textBox1.Text, out numOfSeats))
				MessageBox.Show("Invalid number format");
			hall.NumberOfSeats = Convert.ToInt32(textBox1.Text);
			tables.Halls.AddOrUpdate(hall);
			tables.SaveChanges();
			this.Close();
		}
		private void AddHallForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.Dispose();
		}
	}
}
