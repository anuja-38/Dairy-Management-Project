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
    public partial class Editbuy : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ABHI\Desktop\dairymanagment\DairyManagment\DairyManagment\Dairymanagmentdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        string uname = "";
        public Editbuy(String uname1)
        {
            InitializeComponent();
            uname = uname1;
        }

        private void AID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AID.Text == "")
                {
                    fname.Text = "";
                    lname.Text = "";
                    address.Text = "";
                    cattle.Text = "";
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
                        address.Text = (dr["address"].ToString());
                        cattle.Text = (dr["cattle"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("this account number is not present \n please enter your valid account number");
                    }
                    con.Close();
                }
            }
            catch
            {
            }


            try
            {
                con.Open();
                string q2 = "select * from Milkbuydb where AID= '" + AID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                editview.DataSource = dt2;
                con.Close();
            }
            catch
            {
            }
        }

        private void Editbuy_Load(object sender, EventArgs e)
        {
            this.milkbuydbTableAdapter.Fill(this.milkbuyds.Milkbuydb);

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q1 = "select * from Milkbuydb where BID= '" + BID.Text + "'";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                editview.DataSource = dt1;
                con.Close();
            }
            catch
            {
            }

            try
            {
                con.Open();
                string q2 = "select * from Milkbuydb where BID=" + int.Parse(BID.Text);
                SqlCommand cmd2 = new SqlCommand(q2, con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    fat.Text = (dr2["fat"]).ToString();
                    price.Text = (dr2["price"]).ToString();
                    liter.Text = (dr2["liter"]).ToString();
                    tprice.Text = (dr2["tprice"]).ToString();
                }
                else
                {
                    MessageBox.Show("this milk buy ID is not present \n please enter your valid milk buy ID");
                    fat.Text = "";
                    liter.Text = "";
                    price.Text = "";
                    tprice.Text = "";         
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
                int b = Convert.ToInt32(price.Text);
                int c = a * b;
                tprice.Text = Convert.ToString(c);

            }
            catch
            {
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q1 = "update Milkbuydb set fat=@fat ,price=@price ,liter=@liter ,tprice=@tprice where BID=" + BID.Text + "";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                cmd1.Parameters.AddWithValue("@fat", fat.Text);
                cmd1.Parameters.AddWithValue("@price", price.Text);
                cmd1.Parameters.AddWithValue("@liter", liter.Text);
                cmd1.Parameters.AddWithValue("@tprice", tprice.Text);
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("edit");
            }
            catch
            {
            }

            try
            {
                con.Open();
                string q2 = "select * from Milkbuydb where BID= '" + BID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                editview.DataSource = dt2;
                con.Close();
            }
            catch
            {
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (BID.Text == "")
                {
                    MessageBox.Show("this milk buy ID is not present");
                }
                else
                {
                    if (MessageBox.Show("delete", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        string q1 = "delete from Milkbuydb where BID=" + int.Parse(BID.Text);
                        SqlCommand cmd1 = new SqlCommand(q1, con);
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("delete");
                        BID.Text = "";
                        fat.Text = "";
                        liter.Text = "";
                        price.Text = "";
                        tprice.Text = "";
                    }
                }
            }
            catch
            {
            }

            try
            {
                con.Open();
                string q2 = "select * from Milkbuydb where AID= '" + BID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                editview.DataSource = dt2;
                con.Close();
            }
            catch
            {
            }
        }

        private void fat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
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
    }
}
