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
	public partial class AddMovieForm : Form
	{
		private CinemaDBEntities tables;
		Movie movie;

		public AddMovieForm()
		{
			InitializeComponent();
			tables = new CinemaDBEntities();
			movie = new Movie();
		}

		public AddMovieForm(Movie movie)
		{
			InitializeComponent();
			this.Text = "Edit movie";
			button1.Text = "Edit movie";
			title.Text = movie.Title;
			director.Text = movie.Director;
			year.Text = movie.Year.ToString();
			duration.Text = movie.Duration.Hours + ":" + movie.Duration.Minutes;
			description.Text = movie.Description;
			tables = new CinemaDBEntities();
			this.movie = movie;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Regex patternYear = new Regex(@"^\d{4}$");
			Regex patternDuration = new Regex(@"^\d{1}:\d{2}$");
			if (!patternYear.IsMatch(year.Text))
			{
				MessageBox.Show("Invalid year. Use format YYYY");
				return;
			}
			if (!patternDuration.IsMatch(duration.Text))
			{
				MessageBox.Show("Invalid duration. Use Format H:MM");
				return;
			}
			movie.Description = description.Text;
			movie.Director = director.Text;
			movie.Title = title.Text;
			movie.Year = Convert.ToInt32(year.Text);
			string[] str = duration.Text.Split(':');
			movie.Duration = new TimeSpan(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]), 0);
			tables.Movies.AddOrUpdate(movie);
			tables.SaveChanges();
			this.Close();
		}

		private void AddMovieForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			tables.Dispose();
		}
	}
}
