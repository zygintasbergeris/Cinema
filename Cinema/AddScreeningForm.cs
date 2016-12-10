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
	public partial class AddScreeningForm : Form
	{
		public AddScreeningForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Regex pattern = new Regex(@"^\d{1,}.{0,2}$");
			if (!pattern.IsMatch(price.Text) || Convert.ToDecimal(price.Text) < 0)
				MessageBox.Show("Invalid price. Use format XX.XX");
		}
	}
}
