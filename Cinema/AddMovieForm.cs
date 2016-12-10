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
	public partial class AddMovieForm : Form
	{
		public AddMovieForm()
		{
			InitializeComponent();
		}

		public AddMovieForm(Film film)
		{
			InitializeComponent();
			this.Text = "Edit movie";
			button1.Text = "Edit movie";
			title.Text = film.Title;
			director.Text = film.Director;
			year.Text = film.Year.ToString();
			duration.Text = film.Duration.ToString();
			description.Text = film.Description;
			Entities tables = new Entities();
			tables.Films.Remove(film);
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
			Film film = new Film();
			film.Description = description.Text;
			film.Director = director.Text;
			film.Title = title.Text;
			film.Year = Convert.ToInt32(year.Text);
			string[] str = duration.Text.Split(':');
			film.Duration = new TimeSpan(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]), 0);
			Entities tables = new Entities();
			tables.Films.Add(film);
			this.Close();
		}
	}
}
