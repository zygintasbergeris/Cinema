namespace Cinema
{
	partial class AddMovieForm
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
			this.description = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.duration = new System.Windows.Forms.TextBox();
			this.director = new System.Windows.Forms.TextBox();
			this.title = new System.Windows.Forms.TextBox();
			this.year = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// description
			// 
			this.description.Location = new System.Drawing.Point(23, 162);
			this.description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.description.Multiline = true;
			this.description.Name = "description";
			this.description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.description.Size = new System.Drawing.Size(335, 114);
			this.description.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(19, 143);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 16);
			this.label9.TabIndex = 18;
			this.label9.Text = "Description:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 111);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 16);
			this.label7.TabIndex = 16;
			this.label7.Text = "Duration:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 79);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Director:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 47);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Year:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Title:";
			// 
			// duration
			// 
			this.duration.Location = new System.Drawing.Point(116, 107);
			this.duration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.duration.Name = "duration";
			this.duration.Size = new System.Drawing.Size(241, 22);
			this.duration.TabIndex = 20;
			// 
			// director
			// 
			this.director.Location = new System.Drawing.Point(116, 75);
			this.director.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.director.Name = "director";
			this.director.Size = new System.Drawing.Size(241, 22);
			this.director.TabIndex = 21;
			// 
			// title
			// 
			this.title.Location = new System.Drawing.Point(116, 11);
			this.title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(241, 22);
			this.title.TabIndex = 23;
			// 
			// year
			// 
			this.year.Location = new System.Drawing.Point(116, 43);
			this.year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.year.Name = "year";
			this.year.Size = new System.Drawing.Size(241, 22);
			this.year.TabIndex = 22;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(23, 284);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(336, 28);
			this.button1.TabIndex = 24;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddMovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 322);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.title);
			this.Controls.Add(this.year);
			this.Controls.Add(this.director);
			this.Controls.Add(this.duration);
			this.Controls.Add(this.description);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AddMovieForm";
			this.Text = "Add Movie";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMovieForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox description;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox duration;
		private System.Windows.Forms.TextBox director;
		private System.Windows.Forms.TextBox title;
		private System.Windows.Forms.TextBox year;
		private System.Windows.Forms.Button button1;
	}
}