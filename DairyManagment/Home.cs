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
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ABHI\Desktop\dairymanagment\DairyManagment\DairyManagment\Dairymanagmentdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        string uname="";
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                    Mdi.BackColor = System.Drawing.Color.White;
                }
                catch (Exception)
                {

                }
            }
        }
        private void closeExistingForm()
        {
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception)
            {

            }

        }
        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            gplogin.Visible = true;
            aCCOUNTToolStripMenuItem.Enabled = false;
            mILKMENYToolStripMenuItem.Enabled = false;
            pAYMENTToolStripMenuItem.Enabled = false;
            sETTINGToolStripMenuItem.Enabled = false;
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }


        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm2 = new AccountMst(uname);
            frm2.MdiParent = this;
            frm2.Show();

        }
        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm2 = new AccountMst(uname);
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm2 = new AccountMst(uname);
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void rEPORTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm2 = new AccountMst(uname);
            frm2.MdiParent = this;
            frm2.Show();
        }

       
        private void bUYMILKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm3 = new milkbuy(uname);
            frm3.MdiParent = this;
            frm3.Show();
        }

        

        private void eDITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm4 = new Editbuy(uname);
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void fATPRICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm5 = new Setting(uname);
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void pASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm5 = new Setting(uname);
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void bILLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm7 = new Salaryview(uname);
            frm7.MdiParent = this;
            frm7.Show();
        }

        private void sALARYSLIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form frm6 = new Salary(uname);
            frm6.MdiParent = this;
            frm6.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if(username.Text=="")
                {
                    MessageBox.Show("please enter your username");
                }
                else if(password.Text=="")
                {
                    MessageBox.Show("please enter your password");
                }
                else
                {
                    con.Open();
                    string q1 = "select * from Logindb Where username ='" + username.Text + "' and password = '" + password.Text + "' ";
                    SqlCommand cmd = new SqlCommand(q1, con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    sda.Fill(dt1);
                    if (dt1.Rows.Count == 1)
                    {
                        gplogin.Visible = false;
                        menuStrip1.Visible = true;
                        aCCOUNTToolStripMenuItem.Enabled = true;
                        mILKMENYToolStripMenuItem.Enabled = true;
                        pAYMENTToolStripMenuItem.Enabled = true;
                        sETTINGToolStripMenuItem.Enabled = true;
                        user.Text = username.Text;
                        username.Text = "";
                        password.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(" wrong username or password \n please insert correct username or password");
                        username.Text = "";
                        password.Text = "";
                        user.Text = "";
                    }
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }


        private void cANCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

