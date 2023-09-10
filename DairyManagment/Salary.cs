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
    public partial class Salary : Form
    {
        int sum = 0,sum2 =0;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ABHI\Desktop\dairymanagment\DairyManagment\DairyManagment\Dairymanagmentdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        string uname = "";
        public Salary(string unamee)
        {
            InitializeComponent();
            uname = unamee;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q1 = "select * from Milkbuydb where rdate between '" + datefrom.Text + "' and '" + dateto.Text + "' and AID='" + AID.Text + "'";
                SqlCommand cmd = new SqlCommand(q1, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    sum += Convert.ToInt32(dr["tprice"]);
                }
                salaryamount.Text = sum.ToString();
                if (datefrom == datefrom)
                {
                    sum = 0;
                }
                else
                {
                }
                foreach (DataRow dr in dt.Rows)
                {
                    sum2 += Convert.ToInt32(dr["liter"]);
                }
                tliter.Text = sum2.ToString();
                if (datefrom == datefrom)
                {
                    sum2 = 0;
                }
                else
                {
                }
                salaryview.DataSource = dt;
                con.Close();
            }
            catch
            {
            }


            //seperate
            try
            {
                con.Open();
                string q2 = "select * from Accountdb where AID=" + int.Parse(AID.Text);
                SqlCommand cmd1 = new SqlCommand(q2, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    fname.Text = (dr1["fname"].ToString());
                    lname.Text = (dr1["lname"].ToString());
                    address.Text = (dr1["address"].ToString());
                    cattle.Text = (dr1["cattle"].ToString());
                }
                else
                {
                    MessageBox.Show("this Account number is not present \n please enter valid account number");
                }
                con.Close();
            }
            catch
            {
            }

            if (cattle.Text == "COW")
            {
                fid.Text = Convert.ToString(1);
            }
            else
            {
                fid.Text = Convert.ToString(2);
            }

            //lslsls

            try
            {
                con.Open();
                string q3 = "select * from Fatdb where fid=" + int.Parse(fid.Text);
                SqlCommand cmd3 = new SqlCommand(q3, con);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                if (dr3.Read())
                {
                    literprice.Text = (dr3["fat"].ToString());
                }
                con.Close();
            }
            catch
            {
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q2 = "insert into Salarydb values(@AID,@fname,@lname,@address,@cattle,@tliter,@tprice,@fromdate,@todate,@pdate)";
                SqlCommand cmd = new SqlCommand(q2, con);
                cmd.Parameters.AddWithValue("@AID", AID.Text);
                cmd.Parameters.AddWithValue("@fname", fname.Text);
                cmd.Parameters.AddWithValue("@lname", lname.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@cattle", cattle.Text);
                cmd.Parameters.AddWithValue("@tliter", tliter.Text);
                cmd.Parameters.AddWithValue("@tprice", salaryamount.Text);
                cmd.Parameters.AddWithValue("@fromdate", datefrom.Text);
                cmd.Parameters.AddWithValue("@todate", dateto.Text);
                cmd.Parameters.AddWithValue("@pdate", DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your salary is created successfully ");
            }
            catch
            { 
            }
           
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milkbuyds.Milkbuydb' table. You can move, or remove it, as needed.
            this.milkbuydbTableAdapter.Fill(this.milkbuyds.Milkbuydb);

        }

        private void AID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void datefrom_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today <= datefrom.Value)
            {
                datefrom.Value = DateTime.Today;
            }
        }

        private void dateto_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today <= dateto.Value)
            {
                dateto.Value = DateTime.Today;
            }
        }
    }
}
