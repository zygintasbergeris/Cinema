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
		public MovieInfoForm(Film film)
		{
			InitializeComponent();
			title.Text = film.Title;
			year.Text = film.Year.ToString();
			director.Text = film.Director;
			duration.Text = film.Duration.ToString();
			decription.Text = film.Description;
		}
	}
}
