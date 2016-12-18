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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Cinema
{
	public partial class SignupForm : Form
	{
		public SignupForm()
		{
			InitializeComponent();
		}
		public SignupForm(Client client)
		{
			InitializeComponent();
			using (CinemaDBEntities tables = new CinemaDBEntities())
			{
				Fname.Text = client.FirstName;
				Lname.Text = client.LastName;
				pass.Text = client.Password;
				date.Value = client.DateOfBirth;
				email.Text = client.Email;
				tables.Clients.Remove((tables.Clients.Where(x => x.Id.Equals(client.Id))).FirstOrDefault());
				tables.SaveChanges();
			}
			this.Text = "Edit client";
			button1.Text = "Edit client";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Fname.Text.Length == 0 || Lname.Text.Length == 0 || pass.Text.Length == 0 || !date.Checked || 
				email.Text.Length == 0 || repass.Text.Length == 0)
			{
				MessageBox.Show("One or more fields not entered");
				return;
			}
			try
			{
				MailAddress address = new MailAddress(email.Text);
			}
			catch (FormatException)
			{
				MessageBox.Show("Invalid email");
				return;
			}
			if (!pass.Text.Equals(repass.Text))
			{
				MessageBox.Show("Passwords don't match");
				return;
			}
			using (SqlConnection connection = new SqlConnection(
					@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CinemaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
			{

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.InsertCommand = new SqlCommand("INSERT INTO Client(Firstname, LastName, Password, DateOfBirth, Email)" +
				                                       "VALUES (@FN, @LN, @P, @D, @E)", connection);
				adapter.SelectCommand = new SqlCommand("SELECT Id, Firstname, LastName, Password, DateOfBirth, Email FROM Client", connection); 
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@FN", SqlDbType.NVarChar, 50, "FirstName"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@LN", SqlDbType.NVarChar, 50, "LastName"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@P", SqlDbType.NVarChar, 50, "Password"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@D", SqlDbType.Date, 3, "DateOfBirth"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@E", SqlDbType.NVarChar, 50, "Email"));
				DataSet ds = new DataSet();
				adapter.Fill(ds, "Client");
				DataTable clientsTable = ds.Tables[0];
				DataRow newRow = clientsTable.NewRow();
				newRow["FirstName"] = Fname.Text;
				newRow["LastName"] = Lname.Text;
				newRow["Password"] = pass.Text;
				newRow["DateOfBirth"] = date.Value;
				newRow["Email"] = email.Text;

				clientsTable.Rows.Add(newRow);
				ds.Dispose();
				clientsTable.Dispose();
				adapter.Update(clientsTable);
				adapter.Dispose();
			}
			this.Close();
		}
	}
}
