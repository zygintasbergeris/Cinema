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
	public partial class AddHallForm : Form
	{
		private Entities tables;
		Hall hall;

		public AddHallForm()
		{
			InitializeComponent();
			tables = new Entities();
			hall = new Hall();
		}

		public AddHallForm(Hall hall)
		{
			InitializeComponent();
			tables = new Entities();
			textBox1.Text = hall.NumberOfSeats.ToString();
			this.Text = "Edit hall";
			button1.Text = "Edit hall";
			this.hall = hall;
			tables.Halls.Remove((tables.Halls.Where(x => x.Id.Equals(hall.Id))).FirstOrDefault());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int numOfSeats;
			if (int.TryParse(textBox1.Text, out numOfSeats))
				MessageBox.Show("Invalid number format");
			hall.NumberOfSeats = Convert.ToInt32(textBox1.Text);
			tables.Halls.Add(hall);
			tables.SaveChanges();
			this.Close();
		}
		private void AddHallForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.Dispose();
		}
	}
}
