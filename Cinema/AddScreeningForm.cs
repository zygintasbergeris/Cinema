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
		private CinemaDBEntities tables;
		private Screening screening;

		public AddScreeningForm()
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			screening = new Screening();
			foreach (var hall in tables.Halls)
			{
				this.hall.Items.Add(hall.Id);
			}
			foreach (var movie in tables.Movies)
			{
				this.title.Items.Add(movie.Title);
			}
		}
		public AddScreeningForm(Screening screening)
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			this.screening = screening;
			title.Items.Add((tables.Movies.Where(x => x.Id.Equals(screening.Movie))).FirstOrDefault().Title);
			time.Value = screening.Time;
			hall.Items.Add(screening.Hall);
			this.Text = "Edit screening";
			button1.Text = "Edit screening";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			screening.Time = time.Value;
			screening.Hall = (short)hall.SelectedItem;
			screening.Movie = (tables.Movies.Where(x => x.Title.Equals((string) title.SelectedItem))).FirstOrDefault().Id;
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
