namespace DairyManagment
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.oldfat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cattle = new System.Windows.Forms.ComboBox();
            this.fid = new System.Windows.Forms.TextBox();
            this.setprice = new System.Windows.Forms.Button();
            this.newfat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cornlabel = new System.Windows.Forms.Label();
            this.show3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.npassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.show2 = new System.Windows.Forms.CheckBox();
            this.cnpassword = new System.Windows.Forms.TextBox();
            this.lcpass = new System.Windows.Forms.Label();
            this.show1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.cpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(76, 25);
            this.tabControl1.Location = new System.Drawing.Point(160, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SET MILK PRICE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.oldfat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cattle);
            this.groupBox1.Controls.Add(this.fid);
            this.groupBox1.Controls.Add(this.setprice);
            this.groupBox1.Controls.Add(this.newfat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FAT SETTING";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "OLD MILK RATE";
            // 
            // oldfat
            // 
            this.oldfat.Location = new System.Drawing.Point(216, 95);
            this.oldfat.Name = "oldfat";
            this.oldfat.ReadOnly = true;
            this.oldfat.Size = new System.Drawing.Size(57, 20);
            this.oldfat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // cattle
            // 
            this.cattle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cattle.FormattingEnabled = true;
            this.cattle.Items.AddRange(new object[] {
            "COW",
            "BUFFALO"});
            this.cattle.Location = new System.Drawing.Point(216, 60);
            this.cattle.Name = "cattle";
            this.cattle.Size = new System.Drawing.Size(121, 21);
            this.cattle.TabIndex = 7;
            this.cattle.SelectedIndexChanged += new System.EventHandler(this.cattle_SelectedIndexChanged);
            // 
            // fid
            // 
            this.fid.Location = new System.Drawing.Point(343, 60);
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            this.fid.Size = new System.Drawing.Size(16, 20);
            this.fid.TabIndex = 6;
            this.fid.TextChanged += new System.EventHandler(this.fid_TextChanged);
            // 
            // setprice
            // 
            this.setprice.Location = new System.Drawing.Point(216, 172);
            this.setprice.Name = "setprice";
            this.setprice.Size = new System.Drawing.Size(84, 33);
            this.setprice.TabIndex = 4;
            this.setprice.Text = "SET PRICE";
            this.setprice.UseVisualStyleBackColor = true;
            this.setprice.Click += new System.EventHandler(this.button1_Click);
            // 
            // newfat
            // 
            this.newfat.Location = new System.Drawing.Point(216, 133);
            this.newfat.Name = "newfat";
            this.newfat.Size = new System.Drawing.Size(121, 20);
            this.newfat.TabIndex = 3;
            this.newfat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newfat_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SET NEW MILK  PRICE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATTLE";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(611, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PASSWORD CHANGE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lcpass);
            this.groupBox2.Controls.Add(this.show1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.username);
            this.groupBox2.Controls.Add(this.cpassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(41, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 291);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PASSWORD CHANGE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cornlabel);
            this.panel1.Controls.Add(this.show3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.npassword);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.show2);
            this.panel1.Controls.Add(this.cnpassword);
            this.panel1.Location = new System.Drawing.Point(16, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 163);
            this.panel1.TabIndex = 3;
            // 
            // cornlabel
            // 
            this.cornlabel.AutoSize = true;
            this.cornlabel.Location = new System.Drawing.Point(194, 88);
            this.cornlabel.Name = "cornlabel";
            this.cornlabel.Size = new System.Drawing.Size(15, 13);
            this.cornlabel.TabIndex = 14;
            this.cornlabel.Text = "--";
            // 
            // show3
            // 
            this.show3.AutoSize = true;
            this.show3.Location = new System.Drawing.Point(314, 56);
            this.show3.Name = "show3";
            this.show3.Size = new System.Drawing.Size(64, 17);
            this.show3.TabIndex = 12;
            this.show3.Text = "SHOW";
            this.show3.UseVisualStyleBackColor = true;
            this.show3.CheckedChanged += new System.EventHandler(this.show3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "NEW PASSWORD";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "CHANGE PASSWORD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // npassword
            // 
            this.npassword.Location = new System.Drawing.Point(197, 17);
            this.npassword.Name = "npassword";
            this.npassword.Size = new System.Drawing.Size(100, 20);
            this.npassword.TabIndex = 3;
            this.npassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CONFIRM PASSWORD";
            // 
            // show2
            // 
            this.show2.AutoSize = true;
            this.show2.Location = new System.Drawing.Point(310, 19);
            this.show2.Name = "show2";
            this.show2.Size = new System.Drawing.Size(64, 17);
            this.show2.TabIndex = 11;
            this.show2.Text = "SHOW";
            this.show2.UseVisualStyleBackColor = true;
            this.show2.CheckedChanged += new System.EventHandler(this.show2_CheckedChanged);
            // 
            // cnpassword
            // 
            this.cnpassword.Location = new System.Drawing.Point(197, 56);
            this.cnpassword.Name = "cnpassword";
            this.cnpassword.Size = new System.Drawing.Size(100, 20);
            this.cnpassword.TabIndex = 5;
            this.cnpassword.UseSystemPasswordChar = true;
            this.cnpassword.TextChanged += new System.EventHandler(this.cnpassword_TextChanged);
            // 
            // lcpass
            // 
            this.lcpass.AutoSize = true;
            this.lcpass.Location = new System.Drawing.Point(392, 87);
            this.lcpass.Name = "lcpass";
            this.lcpass.Size = new System.Drawing.Size(21, 13);
            this.lcpass.TabIndex = 13;
            this.lcpass.Text = "__";
            // 
            // show1
            // 
            this.show1.AutoSize = true;
            this.show1.Location = new System.Drawing.Point(322, 86);
            this.show1.Name = "show1";
            this.show1.Size = new System.Drawing.Size(64, 17);
            this.show1.TabIndex = 10;
            this.show1.Text = "SHOW";
            this.show1.UseVisualStyleBackColor = true;
            this.show1.CheckedChanged += new System.EventHandler(this.show1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "USERNAME";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(213, 45);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 7;
            // 
            // cpassword
            // 
            this.cpassword.Location = new System.Drawing.Point(213, 84);
            this.cpassword.Name = "cpassword";
            this.cpassword.Size = new System.Drawing.Size(100, 20);
            this.cpassword.TabIndex = 2;
            this.cpassword.UseSystemPasswordChar = true;
            this.cpassword.TextChanged += new System.EventHandler(this.cpassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CURRENT PASSWORD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "SETTING";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(999, 568);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(140, 73);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setprice;
        private System.Windows.Forms.TextBox newfat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox npassword;
        private System.Windows.Forms.TextBox cpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cattle;
        private System.Windows.Forms.TextBox fid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oldfat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cnpassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox show3;
        private System.Windows.Forms.CheckBox show2;
        private System.Windows.Forms.CheckBox show1;
        private System.Windows.Forms.Label lcpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cornlabel;
    }
}