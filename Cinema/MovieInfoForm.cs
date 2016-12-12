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
	public partial class MovieInfoForm : Form
	{
		public MovieInfoForm(Movie movie)
		{
			InitializeComponent();
			title.Text = movie.Title;
			year.Text = movie.Year.ToString();
			director.Text = movie.Director;
			duration.Text = movie.Duration.ToString();
			decription.Text = movie.Description;
		}
	}
}
