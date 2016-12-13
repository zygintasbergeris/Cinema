namespace Cinema
{
	partial class AddScreeningForm
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.title = new System.Windows.Forms.ComboBox();
			this.hall = new System.Windows.Forms.ComboBox();
			this.time = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Movie:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Hall:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Time:";
			// 
			// title
			// 
			this.title.FormattingEnabled = true;
			this.title.Location = new System.Drawing.Point(87, 10);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(201, 21);
			this.title.TabIndex = 9;
			// 
			// hall
			// 
			this.hall.FormattingEnabled = true;
			this.hall.Location = new System.Drawing.Point(87, 37);
			this.hall.Name = "hall";
			this.hall.Size = new System.Drawing.Size(201, 21);
			this.hall.TabIndex = 10;
			// 
			// time
			// 
			this.time.CustomFormat = "yyyy-MM-dd HH:mm";
			this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.time.Location = new System.Drawing.Point(87, 64);
			this.time.MinDate = new System.DateTime(2016, 12, 10, 0, 0, 0, 0);
			this.time.Name = "time";
			this.time.Size = new System.Drawing.Size(201, 20);
			this.time.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(272, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Add screening";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddScreeningForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 121);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.time);
			this.Controls.Add(this.hall);
			this.Controls.Add(this.title);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "AddScreeningForm";
			this.Text = "AddScreeningForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddScreeningForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox title;
		private System.Windows.Forms.ComboBox hall;
		private System.Windows.Forms.DateTimePicker time;
		private System.Windows.Forms.Button button1;
	}
}