﻿using System;
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

		}
	}
}