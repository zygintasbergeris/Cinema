namespace Cinema
{
	partial class MovieInfoForm
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
			this.title = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.director = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.year = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.duration = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.decription = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title:";
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Location = new System.Drawing.Point(72, 12);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(35, 13);
			this.title.TabIndex = 1;
			this.title.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Year:";
			// 
			// director
			// 
			this.director.AutoSize = true;
			this.director.Location = new System.Drawing.Point(72, 56);
			this.director.Name = "director";
			this.director.Size = new System.Drawing.Size(35, 13);
			this.director.TabIndex = 3;
			this.director.Text = "label4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Director:";
			// 
			// year
			// 
			this.year.AutoSize = true;
			this.year.Location = new System.Drawing.Point(72, 34);
			this.year.Name = "year";
			this.year.Size = new System.Drawing.Size(35, 13);
			this.year.TabIndex = 5;
			this.year.Text = "label6";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Duration:";
			// 
			// duration
			// 
			this.duration.AutoSize = true;
			this.duration.Location = new System.Drawing.Point(72, 78);
			this.duration.Name = "duration";
			this.duration.Size = new System.Drawing.Size(35, 13);
			this.duration.TabIndex = 7;
			this.duration.Text = "label8";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Description:";
			// 
			// decription
			// 
			this.decription.Location = new System.Drawing.Point(15, 121);
			this.decription.Multiline = true;
			this.decription.Name = "decription";
			this.decription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.decription.Size = new System.Drawing.Size(253, 128);
			this.decription.TabIndex = 9;
			// 
			// MovieInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.decription);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.duration);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.year);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.director);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.title);
			this.Controls.Add(this.label1);
			this.Name = "MovieInfoForm";
			this.Text = "MovieInfoForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label director;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label year;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label duration;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox decription;
	}
}