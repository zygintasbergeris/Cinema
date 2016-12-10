namespace Cinema
{
	partial class SignupForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.Fname = new System.Windows.Forms.TextBox();
			this.Lname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Pass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First name:";
			// 
			// Fname
			// 
			this.Fname.Location = new System.Drawing.Point(12, 29);
			this.Fname.Name = "Fname";
			this.Fname.Size = new System.Drawing.Size(167, 20);
			this.Fname.TabIndex = 1;
			// 
			// Lname
			// 
			this.Lname.Location = new System.Drawing.Point(12, 71);
			this.Lname.Name = "Lname";
			this.Lname.Size = new System.Drawing.Size(167, 20);
			this.Lname.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last Name:";
			// 
			// Pass
			// 
			this.Pass.Location = new System.Drawing.Point(12, 110);
			this.Pass.Name = "Pass";
			this.Pass.Size = new System.Drawing.Size(167, 20);
			this.Pass.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Date of birth:";
			// 
			// date
			// 
			this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date.Location = new System.Drawing.Point(12, 152);
			this.date.MaxDate = new System.DateTime(2016, 12, 10, 0, 0, 0, 0);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(167, 20);
			this.date.TabIndex = 7;
			this.date.Value = new System.DateTime(2016, 12, 10, 0, 0, 0, 0);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 179);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Sign Up";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Signup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(191, 212);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.date);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Pass);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Lname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Fname);
			this.Controls.Add(this.label1);
			this.Name = "Signup";
			this.Text = "Sign up";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Fname;
		private System.Windows.Forms.TextBox Lname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Pass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker date;
		private System.Windows.Forms.Button button1;
	}
}