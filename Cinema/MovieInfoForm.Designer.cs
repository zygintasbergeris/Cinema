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
			this.components = new System.ComponentModel.Container();
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
			this.screenings = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.screeningBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cinemaDBDataSet = new Cinema.CinemaDBDataSet();
			this.cinemaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.screeningTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.ScreeningTableAdapter();
			this.search = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buy = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.screenings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSetBindingSource)).BeginInit();
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
			// screenings
			// 
			this.screenings.AllowUserToAddRows = false;
			this.screenings.AllowUserToDeleteRows = false;
			this.screenings.AutoGenerateColumns = false;
			this.screenings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.screenings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.hallDataGridViewTextBoxColumn});
			this.screenings.DataSource = this.screeningBindingSource;
			this.screenings.Location = new System.Drawing.Point(274, 72);
			this.screenings.MultiSelect = false;
			this.screenings.Name = "screenings";
			this.screenings.ReadOnly = true;
			this.screenings.RowHeadersVisible = false;
			this.screenings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.screenings.Size = new System.Drawing.Size(304, 177);
			this.screenings.TabIndex = 10;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// timeDataGridViewTextBoxColumn
			// 
			this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
			this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
			this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
			this.timeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hallDataGridViewTextBoxColumn
			// 
			this.hallDataGridViewTextBoxColumn.DataPropertyName = "Hall";
			this.hallDataGridViewTextBoxColumn.HeaderText = "Hall";
			this.hallDataGridViewTextBoxColumn.Name = "hallDataGridViewTextBoxColumn";
			this.hallDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// screeningBindingSource
			// 
			this.screeningBindingSource.DataMember = "Screening";
			this.screeningBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// cinemaDBDataSet
			// 
			this.cinemaDBDataSet.DataSetName = "CinemaDBDataSet";
			this.cinemaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cinemaDBDataSetBindingSource
			// 
			this.cinemaDBDataSetBindingSource.DataSource = this.cinemaDBDataSet;
			this.cinemaDBDataSetBindingSource.Position = 0;
			// 
			// screeningTableAdapter
			// 
			this.screeningTableAdapter.ClearBeforeFill = true;
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(484, 13);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(94, 23);
			this.search.TabIndex = 11;
			this.search.Text = "Search";
			this.search.UseVisualStyleBackColor = true;
			this.search.Click += new System.EventHandler(this.search_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(274, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(204, 20);
			this.textBox1.TabIndex = 12;
			// 
			// buy
			// 
			this.buy.Location = new System.Drawing.Point(379, 42);
			this.buy.Name = "buy";
			this.buy.Size = new System.Drawing.Size(75, 23);
			this.buy.TabIndex = 13;
			this.buy.Text = "Buy tickets";
			this.buy.UseVisualStyleBackColor = true;
			this.buy.Click += new System.EventHandler(this.buy_Click);
			// 
			// MovieInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 260);
			this.Controls.Add(this.buy);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.search);
			this.Controls.Add(this.screenings);
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
			this.Load += new System.EventHandler(this.MovieInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.screenings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSetBindingSource)).EndInit();
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
		private System.Windows.Forms.DataGridView screenings;
		private System.Windows.Forms.BindingSource cinemaDBDataSetBindingSource;
		private CinemaDBDataSet cinemaDBDataSet;
		private System.Windows.Forms.BindingSource screeningBindingSource;
		private CinemaDBDataSetTableAdapters.ScreeningTableAdapter screeningTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hallDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button search;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buy;
	}
}