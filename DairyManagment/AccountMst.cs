using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace DairyManagment
{
    public partial class AccountMst : Form
    {
        string uname = "";

        //database connecting string
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ABHI\Desktop\dairymanagment\DairyManagment\DairyManagment\Dairymanagmentdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        public AccountMst(string unamee)
        {
            InitializeComponent();
            uname = unamee;
        }

        // date contronl
        private void adob_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today <= adob.Value)
            {
                adob.Value = DateTime.Today;
                MessageBox.Show("invalid date");
            }
        }
        private void edob_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today <= edob.Value)
            {
                edob.Value = DateTime.Today;
                MessageBox.Show("invalid date");
            }
        }

        //number control only allow numbers
        private void amobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                m1.Text = "only numbers are allow";
            }
            else
            {
                m1.Text = "";
            }
        }


        private void emobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void editid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void deleteid_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        //database queries " inserting a account data"

        private void addaccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (afname.Text == "")
                {
                    MessageBox.Show("enter your first Name");
                }
                else if (alname.Text == "")
                {
                    MessageBox.Show("enter your last name");
                }
                else if (aaddress.Text == "")
                {
                    MessageBox.Show("enter your address");
                }
                else if (adob.Text == "")
                {
                    MessageBox.Show("select your date of birth");
                }
                else if (amobile.Text == "")
                {
                    MessageBox.Show("enter your mobile");
                }
                else if (agender.Text == "")
                {
                    MessageBox.Show("select your gender");
                }
                else if (acattle.Text == "")
                {
                    MessageBox.Show("select your cattle");
                }
                else
                {

                    con.Open();
                    string q1 = "insert into Accountdb values(@fname,@lname,@address,@dob,@mobile,@gender,@cattle,@Rdate)";
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue("@fname", afname.Text);
                    cmd1.Parameters.AddWithValue("@lname", alname.Text);
                    cmd1.Parameters.AddWithValue("@address", aaddress.Text);
                    cmd1.Parameters.AddWithValue("@dob", adob.Text);
                    cmd1.Parameters.AddWithValue("@mobile", amobile.Text);
                    cmd1.Parameters.AddWithValue("@gender", agender.Text);
                    cmd1.Parameters.AddWithValue("@cattle", acattle.Text);
                    cmd1.Parameters.AddWithValue("@Rdate", DateTime.Now);      
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("your account is add successfully \n WelCome");
                    afname.Text = "";
                    alname.Text = "";
                    aaddress.Text = "";
                    adob.Text = "";
                    amobile.Text = "";
                    agender.Text = "";
                    acattle.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //update Account data

        private void updateaccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (efname.Text == "")
                {
                    MessageBox.Show("enter your first name");
                }
                else if (elname.Text == "")
                {
                    MessageBox.Show("enter your last name");
                }
                else if (eaddress.Text == "")
                {
                    MessageBox.Show("enter your address");
                }
                else if (edob.Text == "")
                {
                    MessageBox.Show("select your date of birth");
                }
                else if (emobile.Text == "")
                {
                    MessageBox.Show("enter your mobile");
                }
                else if (egender.Text == "")
                {
                    MessageBox.Show("select your gender");
                }
                else if (ecattle.Text == "")
                {
                    MessageBox.Show("select your cattle");
                }
                else
                {
                    con.Open();
                    string q1 = "update Accountdb set fname=@fname ,lname=@lname ,address=@address,dob=@dob, mobile=@mobile,gender=@gender,cattle=@cattle where AID=" + editid.Text + "";
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue("@fname", efname.Text);
                    cmd1.Parameters.AddWithValue("@lname", elname.Text);
                    cmd1.Parameters.AddWithValue("@address", eaddress.Text);
                    cmd1.Parameters.AddWithValue("@dob", edob.Text);
                    cmd1.Parameters.AddWithValue("@mobile", emobile.Text);
                    cmd1.Parameters.AddWithValue("@gender", egender.Text);
                    cmd1.Parameters.AddWithValue("@cattle", ecattle.Text);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("your account is update successfully");
                    efname.Text = "";
                    elname.Text = "";
                    eaddress.Text = "";
                    edob.Text = "";
                    emobile.Text = "";
                    egender.Text = "";
                    ecattle.Text = "";
                    editid.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //show id
        private void showid_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q1 = "select * from Accountdb where AID=" + int.Parse(editid.Text);
                SqlCommand cmd1 = new SqlCommand(q1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    efname.Text = (dr["fname"].ToString());
                    elname.Text = (dr["lname"].ToString());
                    eaddress.Text = (dr["address"].ToString());
                    edob.Text = (dr["dob"].ToString());
                    emobile.Text = (dr["mobile"].ToString());
                    egender.Text = (dr["gender"].ToString());
                    ecattle.Text = (dr["cattle"].ToString());
                }
                else
                {
                    MessageBox.Show("this account number is not present \n please enter your valid account number");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
            
             
        //delete Account data
        private void confirmdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteid.Text == "")
                {
                    MessageBox.Show("please enter account number");
                }
                else
                {
                    if (MessageBox.Show("Do you want delete account \n press YES \n if not press NO", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string q1 = "delete from Accountdb where AID=" + deleteid.Text + "";
                        SqlCommand cmd1 = new SqlCommand(q1, con);
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        deleteid.Text = "";
                        deleteview.DataSource = "";
                    }
                    else
                    {
                        MessageBox.Show("this account number is not present \n please enter your valid account number");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //show delete id
        private void showdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteid.Text == "")
                {
                    MessageBox.Show("please enter account number");
                }
                else
                {
                    con.Open();
                    string q1 = "select * from Accountdb where AID=" + int.Parse(deleteid.Text);
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    deleteview.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
        //View data

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q1 = "select * from Accountdb";
                SqlCommand cmd = new SqlCommand(q1, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                accountview.DataSource = dt;
                con.Close();
                AID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {
            this.accountdbTableAdapter.Fill(this.accountMstData.Accountdb);
            this.accountview.Refresh();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q1 = "select * from Accountdb where AID="+int.Parse(AID.Text);
                SqlCommand cmd = new SqlCommand(q1, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                accountview.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void afname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
                f1.Text = "only charaters are allow";
            }
            else
            {
                f1.Text = "";
            }
        }

        private void alname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
                l1.Text = "only charaters are allow";
            }
            else
            {
                l1.Text = "";
            }
        }
    }
}


        
