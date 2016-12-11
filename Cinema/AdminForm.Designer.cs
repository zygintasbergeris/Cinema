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
			this.tickets = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.addMovie = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.movies = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.screenings = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.halls = new System.Windows.Forms.DataGridView();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button10 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.button13 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.clients = new System.Windows.Forms.DataGridView();
			this.button12 = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cinemaDBDataSet = new Cinema.CinemaDBDataSet();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.screeningBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hallBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hallTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.HallTableAdapter();
			this.screeningTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.ScreeningTableAdapter();
			this.filmTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.FilmTableAdapter();
			this.ticketTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.TicketTableAdapter();
			this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookingTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.BookingTableAdapter();
			this.clientTableAdapter = new Cinema.CinemaDBDataSetTableAdapters.ClientTableAdapter();
			this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Screening = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hallDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tickets.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.movies)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.screenings)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.halls)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.clients)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tickets
			// 
			this.tickets.Controls.Add(this.tabPage1);
			this.tickets.Controls.Add(this.tabPage2);
			this.tickets.Controls.Add(this.tabPage3);
			this.tickets.Controls.Add(this.tabPage4);
			this.tickets.Controls.Add(this.tabPage6);
			this.tickets.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tickets.Location = new System.Drawing.Point(0, 6);
			this.tickets.Margin = new System.Windows.Forms.Padding(4);
			this.tickets.Name = "tickets";
			this.tickets.SelectedIndex = 0;
			this.tickets.Size = new System.Drawing.Size(661, 292);
			this.tickets.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.addMovie);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.movies);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(653, 263);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Movies";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(349, 7);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(187, 28);
			this.button3.TabIndex = 3;
			this.button3.Text = "Remove selected movie";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.removeMovie_Click);
			// 
			// addMovie
			// 
			this.addMovie.Location = new System.Drawing.Point(11, 7);
			this.addMovie.Margin = new System.Windows.Forms.Padding(4);
			this.addMovie.Name = "addMovie";
			this.addMovie.Size = new System.Drawing.Size(156, 28);
			this.addMovie.TabIndex = 2;
			this.addMovie.Text = "Add new movie";
			this.addMovie.UseVisualStyleBackColor = true;
			this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(175, 7);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 28);
			this.button1.TabIndex = 1;
			this.button1.Text = "Update selected movie";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.updateMovie_Click);
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
			this.movies.Location = new System.Drawing.Point(4, 46);
			this.movies.Margin = new System.Windows.Forms.Padding(4);
			this.movies.MultiSelect = false;
			this.movies.Name = "movies";
			this.movies.ReadOnly = true;
			this.movies.RowHeadersVisible = false;
			this.movies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.movies.Size = new System.Drawing.Size(645, 213);
			this.movies.TabIndex = 0;
			this.movies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movies_CellDoubleClick);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.screenings);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(653, 263);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Screenings";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(433, 7);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(207, 28);
			this.button6.TabIndex = 3;
			this.button6.Text = "Delete selected screening";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.deleteScreening_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(219, 7);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(207, 28);
			this.button5.TabIndex = 2;
			this.button5.Text = "Update selected screening";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.updateScreening_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(4, 7);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(207, 28);
			this.button4.TabIndex = 1;
			this.button4.Text = "Add new screening";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.addScreening_Click);
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
			this.screenings.Location = new System.Drawing.Point(4, 46);
			this.screenings.Margin = new System.Windows.Forms.Padding(4);
			this.screenings.MultiSelect = false;
			this.screenings.Name = "screenings";
			this.screenings.RowHeadersVisible = false;
			this.screenings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.screenings.Size = new System.Drawing.Size(645, 213);
			this.screenings.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Transparent;
			this.tabPage3.Controls.Add(this.button9);
			this.tabPage3.Controls.Add(this.button8);
			this.tabPage3.Controls.Add(this.button7);
			this.tabPage3.Controls.Add(this.halls);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(653, 263);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Halls";
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(428, 4);
			this.button9.Margin = new System.Windows.Forms.Padding(4);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(204, 28);
			this.button9.TabIndex = 3;
			this.button9.Text = "Remove selected hall";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.deleteHall_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(216, 4);
			this.button8.Margin = new System.Windows.Forms.Padding(4);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(204, 28);
			this.button8.TabIndex = 2;
			this.button8.Text = "Update selected hall";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.updateHall_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(4, 4);
			this.button7.Margin = new System.Windows.Forms.Padding(4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(204, 28);
			this.button7.TabIndex = 1;
			this.button7.Text = "Add new hall";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.addHall_Click);
			// 
			// halls
			// 
			this.halls.AllowUserToAddRows = false;
			this.halls.AllowUserToDeleteRows = false;
			this.halls.AutoGenerateColumns = false;
			this.halls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.halls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn});
			this.halls.DataSource = this.hallBindingSource;
			this.halls.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.halls.Location = new System.Drawing.Point(0, 43);
			this.halls.Margin = new System.Windows.Forms.Padding(4);
			this.halls.MultiSelect = false;
			this.halls.Name = "halls";
			this.halls.RowHeadersVisible = false;
			this.halls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.halls.Size = new System.Drawing.Size(653, 220);
			this.halls.TabIndex = 0;
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.Transparent;
			this.tabPage4.Controls.Add(this.button10);
			this.tabPage4.Controls.Add(this.dataGridView1);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(653, 263);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Tickets";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(4, 4);
			this.button10.Margin = new System.Windows.Forms.Padding(4);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(199, 28);
			this.button10.TabIndex = 1;
			this.button10.Text = "Buy tickets";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.buyTicket_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.Screening,
            this.hallDataGridViewTextBoxColumn1,
            this.seatDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.ticketBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 43);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(653, 220);
			this.dataGridView1.TabIndex = 0;
			// 
			// tabPage6
			// 
			this.tabPage6.BackColor = System.Drawing.Color.Transparent;
			this.tabPage6.Controls.Add(this.button13);
			this.tabPage6.Controls.Add(this.button12);
			this.tabPage6.Controls.Add(this.button11);
			this.tabPage6.Controls.Add(this.clients);
			this.tabPage6.Location = new System.Drawing.Point(4, 25);
			this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(653, 263);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Clients";
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(388, 4);
			this.button13.Margin = new System.Windows.Forms.Padding(4);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(203, 28);
			this.button13.TabIndex = 3;
			this.button13.Text = "Remove selected client";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.deleteClient_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(4, 4);
			this.button11.Margin = new System.Windows.Forms.Padding(4);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(180, 28);
			this.button11.TabIndex = 1;
			this.button11.Text = "Add new client";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.addClient_Click);
			// 
			// clients
			// 
			this.clients.AllowUserToAddRows = false;
			this.clients.AllowUserToDeleteRows = false;
			this.clients.AutoGenerateColumns = false;
			this.clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn5,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
			this.clients.DataSource = this.clientBindingSource;
			this.clients.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.clients.Location = new System.Drawing.Point(0, 43);
			this.clients.Margin = new System.Windows.Forms.Padding(4);
			this.clients.MultiSelect = false;
			this.clients.Name = "clients";
			this.clients.ReadOnly = true;
			this.clients.RowHeadersVisible = false;
			this.clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.clients.Size = new System.Drawing.Size(653, 220);
			this.clients.TabIndex = 0;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(192, 4);
			this.button12.Margin = new System.Windows.Forms.Padding(4);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(188, 28);
			this.button12.TabIndex = 2;
			this.button12.Text = "Edit selected client";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.updateClient_Click);
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
			// filmBindingSource
			// 
			this.filmBindingSource.DataMember = "Film";
			this.filmBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// cinemaDBDataSet
			// 
			this.cinemaDBDataSet.DataSetName = "CinemaDBDataSet";
			this.cinemaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			// screeningBindingSource
			// 
			this.screeningBindingSource.DataMember = "Screening";
			this.screeningBindingSource.DataSource = this.cinemaDBDataSet;
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
			// hallBindingSource
			// 
			this.hallBindingSource.DataMember = "Hall";
			this.hallBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// ticketBindingSource
			// 
			this.ticketBindingSource.DataMember = "Ticket";
			this.ticketBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// idDataGridViewTextBoxColumn5
			// 
			this.idDataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idDataGridViewTextBoxColumn5.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn5.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
			this.idDataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateOfBirthDataGridViewTextBoxColumn
			// 
			this.dateOfBirthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clientBindingSource
			// 
			this.clientBindingSource.DataMember = "Client";
			this.clientBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// hallTableAdapter
			// 
			this.hallTableAdapter.ClearBeforeFill = true;
			// 
			// screeningTableAdapter
			// 
			this.screeningTableAdapter.ClearBeforeFill = true;
			// 
			// filmTableAdapter
			// 
			this.filmTableAdapter.ClearBeforeFill = true;
			// 
			// ticketTableAdapter
			// 
			this.ticketTableAdapter.ClearBeforeFill = true;
			// 
			// bookingBindingSource
			// 
			this.bookingBindingSource.DataMember = "Booking";
			this.bookingBindingSource.DataSource = this.cinemaDBDataSet;
			// 
			// bookingTableAdapter
			// 
			this.bookingTableAdapter.ClearBeforeFill = true;
			// 
			// clientTableAdapter
			// 
			this.clientTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn3
			// 
			this.idDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
			this.idDataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// Screening
			// 
			this.Screening.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Screening.DataPropertyName = "Screening";
			this.Screening.HeaderText = "Screening";
			this.Screening.Name = "Screening";
			this.Screening.ReadOnly = true;
			// 
			// hallDataGridViewTextBoxColumn1
			// 
			this.hallDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.hallDataGridViewTextBoxColumn1.DataPropertyName = "Hall";
			this.hallDataGridViewTextBoxColumn1.HeaderText = "Hall";
			this.hallDataGridViewTextBoxColumn1.Name = "hallDataGridViewTextBoxColumn1";
			this.hallDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// seatDataGridViewTextBoxColumn
			// 
			this.seatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.seatDataGridViewTextBoxColumn.DataPropertyName = "Seat";
			this.seatDataGridViewTextBoxColumn.HeaderText = "Seat";
			this.seatDataGridViewTextBoxColumn.Name = "seatDataGridViewTextBoxColumn";
			this.seatDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 298);
			this.Controls.Add(this.tickets);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.tickets.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.movies)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.screenings)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.halls)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.clients)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tickets;
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
		private System.Windows.Forms.Button addMovie;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.BindingSource ticketBindingSource;
		private CinemaDBDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
		private System.Windows.Forms.BindingSource bookingBindingSource;
		private CinemaDBDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
		private System.Windows.Forms.DataGridView clients;
		private System.Windows.Forms.BindingSource clientBindingSource;
		private CinemaDBDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.DataGridViewTextBoxColumn showingDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Screening;
		private System.Windows.Forms.DataGridViewTextBoxColumn hallDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn seatDataGridViewTextBoxColumn;
	}
}