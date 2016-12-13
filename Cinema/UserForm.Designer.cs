namespace Cinema
{
	partial class UserForm
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
			this.cinemaDBDataSet = new Cinema.CinemaDBDataSet();
			this.cinemaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.movies = new System.Windows.Forms.DataGridView();
			this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.movieTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.MovieTableAdapter();
			this.screenings = new System.Windows.Forms.DataGridView();
			this.screeningBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.screeningTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.ScreeningTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.searchMoviesButton = new System.Windows.Forms.Button();
			this.searchMovies = new System.Windows.Forms.TextBox();
			this.searchScreenings = new System.Windows.Forms.TextBox();
			this.searchScreeningsButton = new System.Windows.Forms.Button();
			this.clientInfo = new System.Windows.Forms.Button();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buy = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSetBindingSource)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.movies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.screenings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).BeginInit();
			this.SuspendLayout();
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
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new System.Drawing.Point(0, 35);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(449, 243);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.searchMovies);
			this.tabPage1.Controls.Add(this.searchMoviesButton);
			this.tabPage1.Controls.Add(this.movies);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(441, 217);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Movies";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.searchScreeningsButton);
			this.tabPage2.Controls.Add(this.searchScreenings);
			this.tabPage2.Controls.Add(this.screenings);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(441, 217);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Screenings";
			// 
			// movies
			// 
			this.movies.AllowUserToAddRows = false;
			this.movies.AllowUserToDeleteRows = false;
			this.movies.AutoGenerateColumns = false;
			this.movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.movies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn});
			this.movies.DataSource = this.movieBindingSource;
			this.movies.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.movies.Location = new System.Drawing.Point(3, 35);
			this.movies.MultiSelect = false;
			this.movies.Name = "movies";
			this.movies.ReadOnly = true;
			this.movies.RowHeadersVisible = false;
			this.movies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.movies.Size = new System.Drawing.Size(435, 179);
			this.movies.TabIndex = 0;
			this.movies.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.movies_CellMouseDoubleClick);
			// 
			// movieBindingSource
			// 
			this.movieBindingSource.DataMember = "Movie";
			this.movieBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// movieTableAdapter
			// 
			this.movieTableAdapter.ClearBeforeFill = true;
			// 
			// screenings
			// 
			this.screenings.AllowUserToAddRows = false;
			this.screenings.AllowUserToDeleteRows = false;
			this.screenings.AutoGenerateColumns = false;
			this.screenings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.screenings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Movie,
            this.MovieTitle,
            this.timeDataGridViewTextBoxColumn,
            this.hallDataGridViewTextBoxColumn});
			this.screenings.DataSource = this.screeningBindingSource;
			this.screenings.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.screenings.Location = new System.Drawing.Point(3, 35);
			this.screenings.MultiSelect = false;
			this.screenings.Name = "screenings";
			this.screenings.ReadOnly = true;
			this.screenings.RowHeadersVisible = false;
			this.screenings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.screenings.Size = new System.Drawing.Size(435, 179);
			this.screenings.TabIndex = 0;
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
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
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
			// durationDataGridViewTextBoxColumn
			// 
			this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
			this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
			this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
			this.durationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// directorDataGridViewTextBoxColumn
			// 
			this.directorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
			this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
			this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
			this.directorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// searchMoviesButton
			// 
			this.searchMoviesButton.Location = new System.Drawing.Point(332, 7);
			this.searchMoviesButton.Name = "searchMoviesButton";
			this.searchMoviesButton.Size = new System.Drawing.Size(103, 23);
			this.searchMoviesButton.TabIndex = 1;
			this.searchMoviesButton.Text = "Search";
			this.searchMoviesButton.UseVisualStyleBackColor = true;
			this.searchMoviesButton.Click += new System.EventHandler(this.searchMoviesButton_Click);
			// 
			// searchMovies
			// 
			this.searchMovies.Location = new System.Drawing.Point(8, 9);
			this.searchMovies.Name = "searchMovies";
			this.searchMovies.Size = new System.Drawing.Size(318, 20);
			this.searchMovies.TabIndex = 2;
			// 
			// searchScreenings
			// 
			this.searchScreenings.Location = new System.Drawing.Point(8, 9);
			this.searchScreenings.Name = "searchScreenings";
			this.searchScreenings.Size = new System.Drawing.Size(318, 20);
			this.searchScreenings.TabIndex = 4;
			// 
			// searchScreeningsButton
			// 
			this.searchScreeningsButton.Location = new System.Drawing.Point(332, 7);
			this.searchScreeningsButton.Name = "searchScreeningsButton";
			this.searchScreeningsButton.Size = new System.Drawing.Size(103, 23);
			this.searchScreeningsButton.TabIndex = 3;
			this.searchScreeningsButton.Text = "Search";
			this.searchScreeningsButton.UseVisualStyleBackColor = true;
			this.searchScreeningsButton.Click += new System.EventHandler(this.searchScreeningsButton_Click);
			// 
			// clientInfo
			// 
			this.clientInfo.Location = new System.Drawing.Point(362, 12);
			this.clientInfo.Name = "clientInfo";
			this.clientInfo.Size = new System.Drawing.Size(75, 23);
			this.clientInfo.TabIndex = 1;
			this.clientInfo.Text = "Edit my info";
			this.clientInfo.UseVisualStyleBackColor = true;
			this.clientInfo.Click += new System.EventHandler(this.clientInfo_Click);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// Movie
			// 
			this.Movie.DataPropertyName = "Movie";
			this.Movie.HeaderText = "Movie";
			this.Movie.Name = "Movie";
			this.Movie.ReadOnly = true;
			this.Movie.Visible = false;
			// 
			// MovieTitle
			// 
			this.MovieTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MovieTitle.HeaderText = "Movie Title";
			this.MovieTitle.Name = "MovieTitle";
			this.MovieTitle.ReadOnly = true;
			// 
			// timeDataGridViewTextBoxColumn
			// 
			this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
			this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
			this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
			this.timeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hallDataGridViewTextBoxColumn
			// 
			this.hallDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.hallDataGridViewTextBoxColumn.DataPropertyName = "Hall";
			this.hallDataGridViewTextBoxColumn.HeaderText = "Hall";
			this.hallDataGridViewTextBoxColumn.Name = "hallDataGridViewTextBoxColumn";
			this.hallDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// buy
			// 
			this.buy.Location = new System.Drawing.Point(255, 12);
			this.buy.Name = "buy";
			this.buy.Size = new System.Drawing.Size(75, 23);
			this.buy.TabIndex = 2;
			this.buy.Text = "Buy";
			this.buy.UseVisualStyleBackColor = true;
			this.buy.Click += new System.EventHandler(this.buy_Click);
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 278);
			this.Controls.Add(this.buy);
			this.Controls.Add(this.clientInfo);
			this.Controls.Add(this.tabControl1);
			this.Name = "UserForm";
			this.Text = "UserForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
			this.Load += new System.EventHandler(this.UserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSetBindingSource)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.movies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.screenings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CinemaDBDataSet cinemaDBDataSet;
		private System.Windows.Forms.BindingSource cinemaDBDataSetBindingSource;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView movies;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.BindingSource movieBindingSource;
		private CinemaDBDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
		private System.Windows.Forms.DataGridView screenings;
		private System.Windows.Forms.BindingSource screeningBindingSource;
		private CinemaDBDataSetTableAdapters.ScreeningTableAdapter screeningTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox searchMovies;
		private System.Windows.Forms.Button searchMoviesButton;
		private System.Windows.Forms.Button searchScreeningsButton;
		private System.Windows.Forms.TextBox searchScreenings;
		private System.Windows.Forms.Button clientInfo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Movie;
		private System.Windows.Forms.DataGridViewTextBoxColumn MovieTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hallDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button buy;
	}
}