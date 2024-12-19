using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace AirlineManagmentSystem
{
    public partial class TicketBooking : Form
    {
        public TicketBooking()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void fillPassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PIdCb.ValueMember = "PassId";
            PIdCb.DataSource = dt;
            Con.Close();
        }
        private void fillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FCodeCb.ValueMember = "Fcode";
            FCodeCb.DataSource = dt;
            Con.Close();
        }
        string pname, ppass, padd, pnat;
        private void fetchpassenger()
        {
            Con.Open();
            string query = "select * from PassengerTbl where PassId=" + PIdCb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassNat"].ToString();
                PnameTb.Text = pname;
                PPassTb.Text = ppass;
                PNatTb.Text = pnat;
            }
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tid.Text == "" || PnameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into TicketTbl values(" + Tid.Text + ",'" + FCodeCb.SelectedValue.ToString() + "', " + PIdCb.SelectedValue.ToString()+ ", '" + PnameTb.Text + "', '" + PPassTb.Text + "', '" + PNatTb.Text + "', " + PAmtTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tid.Text = "";
            PnameTb.Text = "";
            PPassTb.Text = "";
            PNatTb.Text = "";
            PAmtTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home2 = new Home();
            home2.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TicketBooking_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlightCode();
            populate();
        }

        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpassenger();
        }
    }
}
