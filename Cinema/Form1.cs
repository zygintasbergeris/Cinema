using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Cinema
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void signIn_Click(object sender, EventArgs e)
		{
			if (username.Text.Equals("admin"))
			{
				Admin();
			}
			else
			{
				User();
			}

		}

		private void User()
		{
			using (SqlConnection connection =new SqlConnection(
						@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CinemaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
			{
				SqlDataAdapter adapter = new SqlDataAdapter("Select Id, password From Client WHERE Id = @ID", connection);
				adapter.SelectCommand.Parameters.AddWithValue("@ID", username.Text);
				DataSet set = new DataSet();
				adapter.Fill(set, "Client");
				if (set.Tables[0].Rows.Count == 0)
					MessageBox.Show("Client not found");
				else
				{
					if (set.Tables[0].Rows[0]["Password"].ToString() == password.Text)
					{
						this.Hide();
						UserForm userf = new UserForm();
						userf.Show();
						userf.Closing += (x, args) => this.Close();
					}
					else
						MessageBox.Show("Password doesn't match");
				}
				adapter.Dispose();
			}
		}

		private void Admin()
		{
			if (password.Text == Convert.ToString(ConfigurationManager.AppSettings["AdminPass"]))
			{
				this.Hide();
				AdminForm adminf = new AdminForm();
				adminf.Show();
				adminf.Closing += (x, args) => this.Close();
			}
		}

		private void signUp_Click(object sender, EventArgs e)
		{
			SignupForm signup = new SignupForm();
			signup.Show();
		}
	}
}
