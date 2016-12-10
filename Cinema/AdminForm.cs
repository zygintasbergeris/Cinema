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
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'cinemaDBDataSet.Film' table. You can move, or remove it, as needed.
			this.filmTableAdapter.Fill(this.cinemaDBDataSet.Film);
			// TODO: This line of code loads data into the 'cinemaDBDataSet.Screening' table. You can move, or remove it, as needed.
			this.screeningTableAdapter.Fill(this.cinemaDBDataSet.Screening);
			// TODO: This line of code loads data into the 'cinemaDBDataSet.Hall' table. You can move, or remove it, as needed.
			this.hallTableAdapter.Fill(this.cinemaDBDataSet.Hall);

		}

		private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			MovieInfoForm movieInfo = new MovieInfoForm();
			movieInfo.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddMovieForm movieForm = new AddMovieForm();
			movieForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{ 
				MessageBox.Show("No movie selected");
				return;
			}
			AddMovieForm movieForm = new AddMovieForm();
			movieForm.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (movies.SelectedRows.Count == 0)
			{
				MessageBox.Show("No movie selected");
				return;
			}

		}
	}
}
