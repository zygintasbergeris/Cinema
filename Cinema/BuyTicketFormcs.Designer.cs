namespace Cinema
{
	partial class BuyTicketForm
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
			this.screenings = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.movies = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.users = new System.Windows.Forms.ComboBox();
			this.price = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// screenings
			// 
			this.screenings.FormattingEnabled = true;
			this.screenings.Location = new System.Drawing.Point(12, 71);
			this.screenings.Name = "screenings";
			this.screenings.Size = new System.Drawing.Size(214, 21);
			this.screenings.TabIndex = 1;
			this.screenings.TextChanged += new System.EventHandler(this.screenings_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 193);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(214, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Buy";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// movies
			// 
			this.movies.FormattingEnabled = true;
			this.movies.Location = new System.Drawing.Point(12, 28);
			this.movies.Name = "movies";
			this.movies.Size = new System.Drawing.Size(214, 21);
			this.movies.TabIndex = 0;
			this.movies.SelectedIndexChanged += new System.EventHandler(this.movies_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Movie:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Screening:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Price:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "User:";
			// 
			// users
			// 
			this.users.FormattingEnabled = true;
			this.users.Location = new System.Drawing.Point(12, 112);
			this.users.Name = "users";
			this.users.Size = new System.Drawing.Size(214, 21);
			this.users.TabIndex = 2;
			this.users.SelectedIndexChanged += new System.EventHandler(this.users_SelectedIndexChanged);
			// 
			// price
			// 
			this.price.AutoSize = true;
			this.price.Location = new System.Drawing.Point(65, 168);
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(0, 13);
			this.price.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Amount:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(68, 139);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(158, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// BuyTicketForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 225);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.price);
			this.Controls.Add(this.users);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.movies);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.screenings);
			this.Name = "BuyTicketForm";
			this.Text = "Buy ticket";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuyTicketForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox screenings;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox movies;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox users;
		private System.Windows.Forms.Label price;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}