using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagmentSystem
{
    public partial class ViewPassengers : Form
    {
        public ViewPassengers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewPassengers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPassengers addpas = new AddPassengers();
            addpas.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PidTb.Text == "")
            {
                MessageBox.Show("Enter the passenger to delete");
            }
            else
            {
                try
                {
                    Con.Open() ;
                    string query = "delete from PassengerTbl where PassId=" + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Con.Close() ;
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PidTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
            PnameTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PpassTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PaddTb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
            natcb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
            GendCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
            PphoneTb.Text = PassengerDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PidTb.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddTb.Text = "";
            natcb.SelectedItem = "";
            GendCb.SelectedItem = "";
            PphoneTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PidTb.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" || PaddTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengerTbl set PassName='" + PnameTb.Text + "',Passport='" + PpassTb.Text + "', PassAd= '" + PaddTb.Text + "', PassNat='" + natcb.SelectedItem.ToString() + "',PassGend='" + GendCb.SelectedItem.ToString() + "', PassPhone='" + PphoneTb.Text + "' where PassId = " + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger updated successfully");
                    Con.Close();
                    populate();
                }catch (Exception Ex) 
                {
                    MessageBox.Show("Missing information");
                }
            }
        }
    }
}
