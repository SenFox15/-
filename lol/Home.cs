﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagmentSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FlightTable flight = new FlightTable();
            flight.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddPassengers passenger = new AddPassengers();
            passenger.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            TicketBooking ticket = new TicketBooking();
            ticket.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Cancellation cancellation = new Cancellation();
            cancellation.Show();
            this.Hide();
        }
    }
}
