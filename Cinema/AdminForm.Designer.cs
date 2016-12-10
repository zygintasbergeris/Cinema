namespace Cinema
{
	partial class AdminForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.halls = new System.Windows.Forms.DataGridView();
			this.cinemaDBDataSet = new Cinema.CinemaDBDataSet();
			this.hallBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hallTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.HallTableAdapter();
			this.screenings = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.screeningBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.screeningTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.ScreeningTableAdapter();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.movies = new System.Windows.Forms.DataGridView();
			this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.filmTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.FilmTableAdapter();
			this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.halls)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.screenings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(496, 237);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.movies);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(488, 211);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Movies";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.screenings);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(488, 211);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Screenings";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Transparent;
			this.tabPage3.Controls.Add(this.halls);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(488, 211);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Halls";
			// 
			// halls
			// 
			this.halls.AutoGenerateColumns = false;
			this.halls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.halls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn});
			this.halls.DataSource = this.hallBindingSource;
			this.halls.Location = new System.Drawing.Point(3, 53);
			this.halls.Name = "halls";
			this.halls.RowHeadersVisible = false;
			this.halls.Size = new System.Drawing.Size(471, 150);
			this.halls.TabIndex = 0;
			// 
			// cinemaDBDataSet
			// 
			this.cinemaDBDataSet.DataSetName = "CinemaDBDataSet";
			this.cinemaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// hallBindingSource
			// 
			this.hallBindingSource.DataMember = "Hall";
			this.hallBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// hallTableAdapter
			// 
			this.hallTableAdapter.ClearBeforeFill = true;
			// 
			// screenings
			// 
			this.screenings.AllowUserToAddRows = false;
			this.screenings.AllowUserToDeleteRows = false;
			this.screenings.AutoGenerateColumns = false;
			this.screenings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.screenings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.filmDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.hallDataGridViewTextBoxColumn});
			this.screenings.DataSource = this.screeningBindingSource;
			this.screenings.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.screenings.Location = new System.Drawing.Point(3, 35);
			this.screenings.MultiSelect = false;
			this.screenings.Name = "screenings";
			this.screenings.RowHeadersVisible = false;
			this.screenings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.screenings.Size = new System.Drawing.Size(482, 173);
			this.screenings.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// numberOfSeatsDataGridViewTextBoxColumn
			// 
			this.numberOfSeatsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
			this.numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "Number Of Seats";
			this.numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
			// 
			// screeningBindingSource
			// 
			this.screeningBindingSource.DataMember = "Screening";
			this.screeningBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// screeningTableAdapter
			// 
			this.screeningTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// filmDataGridViewTextBoxColumn
			// 
			this.filmDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.filmDataGridViewTextBoxColumn.DataPropertyName = "Film";
			this.filmDataGridViewTextBoxColumn.HeaderText = "Film";
			this.filmDataGridViewTextBoxColumn.Name = "filmDataGridViewTextBoxColumn";
			// 
			// timeDataGridViewTextBoxColumn
			// 
			this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
			this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
			this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// hallDataGridViewTextBoxColumn
			// 
			this.hallDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.hallDataGridViewTextBoxColumn.DataPropertyName = "Hall";
			this.hallDataGridViewTextBoxColumn.HeaderText = "Hall";
			this.hallDataGridViewTextBoxColumn.Name = "hallDataGridViewTextBoxColumn";
			// 
			// movies
			// 
			this.movies.AllowUserToAddRows = false;
			this.movies.AllowUserToDeleteRows = false;
			this.movies.AutoGenerateColumns = false;
			this.movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.movies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
			this.movies.DataSource = this.filmBindingSource;
			this.movies.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.movies.Location = new System.Drawing.Point(3, 35);
			this.movies.MultiSelect = false;
			this.movies.Name = "movies";
			this.movies.ReadOnly = true;
			this.movies.RowHeadersVisible = false;
			this.movies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.movies.Size = new System.Drawing.Size(482, 173);
			this.movies.TabIndex = 0;
			this.movies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
			// 
			// filmBindingSource
			// 
			this.filmBindingSource.DataMember = "Film";
			this.filmBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// filmTableAdapter
			// 
			this.filmTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn2
			// 
			this.idDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
			this.idDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// yearDataGridViewTextBoxColumn
			// 
			this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
			this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
			this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
			this.yearDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// directorDataGridViewTextBoxColumn
			// 
			this.directorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
			this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
			this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
			this.directorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// durationDataGridViewTextBoxColumn
			// 
			this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
			this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
			this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
			this.durationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(131, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Update selected movie";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(117, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Add new movie";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(262, 6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(140, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Remove selected movie";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(3, 6);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(155, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "Add new screening";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(164, 6);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(155, 23);
			this.button5.TabIndex = 2;
			this.button5.Text = "Update selected screening";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(325, 6);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(155, 23);
			this.button6.TabIndex = 3;
			this.button6.Text = "Delete selected screening";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 261);
			this.Controls.Add(this.tabControl1);
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.halls)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.screenings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView halls;
		private CinemaDBDataSet cinemaDBDataSet;
		private System.Windows.Forms.BindingSource hallBindingSource;
		private CinemaDBDataSetTableAdapters.HallTableAdapter hallTableAdapter;
		private System.Windows.Forms.DataGridView screenings;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource screeningBindingSource;
		private CinemaDBDataSetTableAdapters.ScreeningTableAdapter screeningTableAdapter;
		private System.Windows.Forms.DataGridView movies;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hallDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource filmBindingSource;
		private CinemaDBDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
	}
}