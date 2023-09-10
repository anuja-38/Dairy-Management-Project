using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DairyManagment
{
    public partial class milkbuy : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ABHI\Desktop\dairymanagment\DairyManagment\DairyManagment\Dairymanagmentdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        string uname = "";
        public milkbuy(string uanmee)
        {
            InitializeComponent();
            uname = uanmee;
        }

        private void addrecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (AID.Text == "")
                {
                    MessageBox.Show("enter your account number");
                }
                else if (liter.Text == "")
                {
                    MessageBox.Show("enter quantity of milk in liter");
                }
                else if (mfat.Text == "")
                {
                    MessageBox.Show("enter fat of milk");
                }
                else
                {
                    con.Open();
                    string q1 = "insert into Milkbuydb values(@AID,@rdate,@time,@cattle,@liter,@fat,@price,@tprice)";
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue("@AID", AID.Text);
                    cmd1.Parameters.AddWithValue("@rdate", DateTime.Now);
                    cmd1.Parameters.AddWithValue("@time", DateTime.Now);
                    cmd1.Parameters.AddWithValue("@cattle", cattle.Text);
                    cmd1.Parameters.AddWithValue("@liter", liter.Text);
                    cmd1.Parameters.AddWithValue("@fat", mfat.Text);
                    cmd1.Parameters.AddWithValue("@price", mprice.Text);
                    cmd1.Parameters.AddWithValue("@tprice", mtprice.Text);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("your Todays Record successfully added \n Thank You");               
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                con.Open();
                string q2 = "select * from Milkbuydb where AID= '" + AID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                viewrecord.DataSource = dt2;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                con.Open();
                string q3 = "select * from Milkbuydb where rdate= '" + DateTime.Today + "'";
                SqlCommand cmd3 = new SqlCommand(q3, con);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                todayview.DataSource = dt3;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AID_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (AID.Text == "")
                {
                    fname.Text = "";
                    lname.Text = "";
                    cattle.Text = "";
                    liter.Text = "";
                    mprice.Text = "";
                    mfat.Text = "";
                    mtprice.Text = "";
                }
                else
                {
                    con.Open();
                    string q1 = "select * from Accountdb where AID=" + int.Parse(AID.Text);
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        fname.Text = (dr["fname"].ToString());
                        lname.Text = (dr["lname"].ToString());
                        cattle.Text = (dr["cattle"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("this account number is not present \n please enter your valid account number");
                        fname.Text = "";
                        lname.Text = "";
                        cattle.Text = "";
                    }
                    con.Close();
                }
            }
            catch 
            {
                
            }

            //

            try
            {
                con.Open();
                string q2 = "select * from Fatdb where cattle= '"+cattle.Text+"'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    mprice.Text = (dr2["fat"].ToString());
                }
                con.Close();
            }
            catch 
            {
                
            }
        }

        private void liter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(liter.Text);
                int b = Convert.ToInt32(mprice.Text);
                int c = a * b;
                mtprice.Text = Convert.ToString(c);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void milkbuy_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q2 = "select * from Milkbuydb where rdate= '" + DateTime.Today + "'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                todayview.DataSource = dt2;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void liter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void AID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void mfat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}