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
    public partial class Setting : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ABHI\Desktop\dairymanagment\DairyManagment\DairyManagment\Dairymanagmentdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        string uname = "";
        public Setting(string unamee)
        {
            InitializeComponent();
            uname = unamee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q1 = "update Fatdb set fat=@fat where fid=" + fid.Text + "";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                cmd1.Parameters.AddWithValue("@fat", newfat.Text);
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("milk price changed");
            }
            catch
            {
            }



        }

        private void cattle_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cattle.Text == "COW")
            {
                fid.Text = Convert.ToString(1);
            }
            else
            {
                fid.Text = Convert.ToString(2);
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void fid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q2 = "select * from Fatdb where fid=" + int.Parse(fid.Text);
                SqlCommand cmd2 = new SqlCommand(q2, con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    oldfat.Text = (dr2["fat"].ToString());
                }
                con.Close();
            }
            catch
            {
            }
        }

        private void newfat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text == "")
                {
                    MessageBox.Show("enter your username");
                }
                else if (cpassword.Text=="")
                {
                    MessageBox.Show("enter your old password in current password");
                }
                else if (npassword.Text == "")
                {
                    MessageBox.Show("enter your new password");
                }
                else if (npassword.Text != cnpassword.Text)
                {
                    MessageBox.Show("confirm password is not match");
                }
                else
                {

                    con.Open();
                    string q1 = "update Logindb set password=@password where username='" + username.Text + "' and password = '" + cpassword.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue("@password", npassword.Text);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("your password is changed successfully");
                    username.Text = "";
                    cpassword.Text = "";
                    npassword.Text = "";
                    cnpassword.Text = "";
                    
                }
            }
            catch
            {         
            }
        }

        private void cnpassword_TextChanged(object sender, EventArgs e)
        {
            if (npassword.Text == cnpassword.Text)
            {
                cornlabel.Text = "";
                
            }
            else
            {
                cornlabel.Text = "confirm password is not match"; 
            }
        }

        private void show1_CheckedChanged(object sender, EventArgs e)
        {
            if (show1.Checked)
            {
                cpassword.UseSystemPasswordChar = false;
            }
            else
            {
                cpassword.UseSystemPasswordChar = true;
            }
        }

        private void show2_CheckedChanged(object sender, EventArgs e)
        {
            if (show2.Checked)
            {
                npassword.UseSystemPasswordChar = false;
            }
            else
            {
                npassword.UseSystemPasswordChar = true;
            }
        }

        private void show3_CheckedChanged(object sender, EventArgs e)
        {
            if (show3.Checked)
            {
                cnpassword.UseSystemPasswordChar = false;
            }
            else
            {
                cnpassword.UseSystemPasswordChar = true;
            }
        }

        private void cpassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q2 = "select * from logindb where username='" + username.Text + "' and password ='" + cpassword.Text + "'";
                SqlCommand cmd = new SqlCommand(q2, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    lcpass.Text = "";
                }
                else
                {
                    lcpass.Text = "password not match";
                }
                con.Close();
            }
            catch
            {
            }
        }
    }
}
