﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
	public partial class BuyTicketForm : Form
	{
		public BuyTicketForm()
		{
			InitializeComponent();
		}

		public BuyTicketForm(Screening screening)
		{
			InitializeComponent();
		}
	}
}
