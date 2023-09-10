using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace DairyManagment
{
    public partial class Salaryview : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ABHI\Desktop\dairymanagment\DairyManagment\DairyManagment\Dairymanagmentdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        string uname = "";
        public Salaryview(string unamee)
        {
            InitializeComponent();
            uname = unamee;
        }

        private void Salaryview_Load(object sender, EventArgs e)
        {

            this.salarydbTableAdapter.Fill(this.salaryviewdataset.Salarydb);

            try
            {
                con.Open();
                string q1 = "select * from Salarydb";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                viewsalary.DataSource = dt1;
                con.Close();
            }
            catch
            {
            }

            this.reportViewer1.RefreshReport();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q1 = "select * from Salarydb where AID='" + AID.Text + "' and pdate='" + pdate.Text + "' ";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                viewsalary.DataSource = dt1;
                con.Close();
            }
            catch
            {
            }
        }

        private void primt_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q1 = "select * from Salarydb where SID=" + int.Parse(textBox1.Text);
                SqlCommand cmd = new SqlCommand(q1, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                salaryset ss = new salaryset();
                sda.Fill(ss, "Salarydb1");

                ReportDataSource rds = new ReportDataSource("DataSet1", ss.Tables[0]);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
                con.Close();
            }
            catch
            {
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pdate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today <= pdate.Value)
            {
                pdate.Value = DateTime.Today;
            }
        }
    }
}
