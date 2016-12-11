using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
	public partial class AddScreeningForm : Form
	{
		private Entities tables;
		private Screening screening;

		public AddScreeningForm()
		{
			InitializeComponent();
			tables = new Entities();
			screening = new Screening();
			foreach (var hall in tables.Halls)
			{
				this.hall.Items.Add(hall.Id);
			}
			foreach (var film in tables.Films)
			{
				this.title.Items.Add(film.Title);
			}
		}
		public AddScreeningForm(Screening screening)
		{
			InitializeComponent();
			tables = new Entities();
			this.screening = screening;
			title.Items.Add((tables.Films.Where(x => x.Id.Equals(screening.Film))).FirstOrDefault().Title);
			price.Text = screening.Price.ToString();
			time.Value = screening.Time;
			hall.Items.Add(screening.Hall);
			this.Text = "Edit screening";
			button1.Text = "Edit screening";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Regex pattern = new Regex(@"^\d{1,}.{0,2}$");
			if (!pattern.IsMatch(price.Text) || Convert.ToDecimal(price.Text) < 0)
				MessageBox.Show("Invalid price. Use format XX.XX");
			screening.Price = Convert.ToDecimal(price.Text);
			screening.Time = time.Value;
			screening.Hall = (short)hall.SelectedItem;
			screening.Film = (tables.Films.Where(x => x.Title.Equals((string) title.SelectedItem))).FirstOrDefault().Id;
			tables.Screenings.AddOrUpdate(screening);
			tables.SaveChanges();
			this.Close();
		}

		private void AddScreeningForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.Dispose();
		}
	}
}
