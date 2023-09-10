namespace DairyManagment
{
    partial class Salary
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AID = new System.Windows.Forms.TextBox();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fid = new System.Windows.Forms.TextBox();
            this.literprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cattle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryamount = new System.Windows.Forms.Label();
            this.tliter = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.salaryview = new System.Windows.Forms.DataGridView();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cattleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milkbuydbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkbuyds = new DairyManagment.DS.milkbuyds();
            this.milkbuydbTableAdapter = new DairyManagment.DS.milkbuydsTableAdapters.MilkbuydbTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuydbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuyds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.dateto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.generate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AID);
            this.panel1.Controls.Add(this.datefrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 75);
            this.panel1.TabIndex = 0;
            // 
            // dateto
            // 
            this.dateto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateto.Location = new System.Drawing.Point(402, 49);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(73, 20);
            this.dateto.TabIndex = 3;
            this.dateto.ValueChanged += new System.EventHandler(this.dateto_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SALARY TO DATE";
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.SystemColors.Menu;
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(555, 30);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(94, 32);
            this.generate.TabIndex = 4;
            this.generate.Text = "GENERATE";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ACCOUNT NO";
            // 
            // AID
            // 
            this.AID.Location = new System.Drawing.Point(125, 8);
            this.AID.Name = "AID";
            this.AID.Size = new System.Drawing.Size(100, 20);
            this.AID.TabIndex = 6;
            this.AID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AID_KeyPress);
            // 
            // datefrom
            // 
            this.datefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefrom.Location = new System.Drawing.Point(152, 43);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(73, 20);
            this.datefrom.TabIndex = 2;
            this.datefrom.ValueChanged += new System.EventHandler(this.datefrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALARY FROM DATE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.fid);
            this.groupBox2.Controls.Add(this.literprice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cattle);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.address);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lname);
            this.groupBox2.Controls.Add(this.fname);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Location = new System.Drawing.Point(714, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 360);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACCOUNT";
            // 
            // fid
            // 
            this.fid.Location = new System.Drawing.Point(565, 97);
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            this.fid.Size = new System.Drawing.Size(10, 20);
            this.fid.TabIndex = 17;
            // 
            // literprice
            // 
            this.literprice.AutoSize = true;
            this.literprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literprice.Location = new System.Drawing.Point(112, 135);
            this.literprice.Name = "literprice";
            this.literprice.Size = new System.Drawing.Size(11, 13);
            this.literprice.TabIndex = 16;
            this.literprice.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "PRICE/LITER";
            // 
            // cattle
            // 
            this.cattle.AutoSize = true;
            this.cattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cattle.Location = new System.Drawing.Point(90, 96);
            this.cattle.Name = "cattle";
            this.cattle.Size = new System.Drawing.Size(11, 13);
            this.cattle.TabIndex = 12;
            this.cattle.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "CATTLE";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(90, 58);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(11, 13);
            this.address.TabIndex = 10;
            this.address.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ADDRESS";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(169, 23);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(11, 13);
            this.lname.TabIndex = 8;
            this.lname.Text = "-";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(90, 23);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(11, 13);
            this.fname.TabIndex = 7;
            this.fname.Text = "-";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(6, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 13);
            this.name.TabIndex = 6;
            this.name.Text = "NAME";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.salaryview);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALARY VIEW";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.salaryamount);
            this.groupBox3.Controls.Add(this.tliter);
            this.groupBox3.Location = new System.Drawing.Point(10, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 62);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TOTAL LITER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "TOTAL PRICE";
            // 
            // salaryamount
            // 
            this.salaryamount.AutoSize = true;
            this.salaryamount.Location = new System.Drawing.Point(381, 25);
            this.salaryamount.Name = "salaryamount";
            this.salaryamount.Size = new System.Drawing.Size(11, 13);
            this.salaryamount.TabIndex = 6;
            this.salaryamount.Text = "-";
            // 
            // tliter
            // 
            this.tliter.AutoSize = true;
            this.tliter.Location = new System.Drawing.Point(107, 25);
            this.tliter.Name = "tliter";
            this.tliter.Size = new System.Drawing.Size(11, 13);
            this.tliter.TabIndex = 14;
            this.tliter.Text = "-";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.save.Location = new System.Drawing.Point(605, 310);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 39);
            this.save.TabIndex = 5;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // salaryview
            // 
            this.salaryview.AutoGenerateColumns = false;
            this.salaryview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.aIDDataGridViewTextBoxColumn,
            this.cattleDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.fatDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.literDataGridViewTextBoxColumn,
            this.tpriceDataGridViewTextBoxColumn,
            this.rdateDataGridViewTextBoxColumn});
            this.salaryview.DataSource = this.milkbuydbBindingSource;
            this.salaryview.Location = new System.Drawing.Point(10, 19);
            this.salaryview.Name = "salaryview";
            this.salaryview.Size = new System.Drawing.Size(670, 273);
            this.salaryview.TabIndex = 0;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "BID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "MILK ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "AID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "ACCOUNT NO";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            // 
            // cattleDataGridViewTextBoxColumn
            // 
            this.cattleDataGridViewTextBoxColumn.DataPropertyName = "cattle";
            this.cattleDataGridViewTextBoxColumn.HeaderText = "CATTLE";
            this.cattleDataGridViewTextBoxColumn.Name = "cattleDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "TIME";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // fatDataGridViewTextBoxColumn
            // 
            this.fatDataGridViewTextBoxColumn.DataPropertyName = "fat";
            this.fatDataGridViewTextBoxColumn.HeaderText = "FAT";
            this.fatDataGridViewTextBoxColumn.Name = "fatDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "PRICE/LITER";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // literDataGridViewTextBoxColumn
            // 
            this.literDataGridViewTextBoxColumn.DataPropertyName = "liter";
            this.literDataGridViewTextBoxColumn.HeaderText = "LITER";
            this.literDataGridViewTextBoxColumn.Name = "literDataGridViewTextBoxColumn";
            // 
            // tpriceDataGridViewTextBoxColumn
            // 
            this.tpriceDataGridViewTextBoxColumn.DataPropertyName = "tprice";
            this.tpriceDataGridViewTextBoxColumn.HeaderText = "TOTAL PRICE";
            this.tpriceDataGridViewTextBoxColumn.Name = "tpriceDataGridViewTextBoxColumn";
            // 
            // rdateDataGridViewTextBoxColumn
            // 
            this.rdateDataGridViewTextBoxColumn.DataPropertyName = "rdate";
            this.rdateDataGridViewTextBoxColumn.HeaderText = "REGISTER DATE";
            this.rdateDataGridViewTextBoxColumn.Name = "rdateDataGridViewTextBoxColumn";
            // 
            // milkbuydbBindingSource
            // 
            this.milkbuydbBindingSource.DataMember = "Milkbuydb";
            this.milkbuydbBindingSource.DataSource = this.milkbuyds;
            // 
            // milkbuyds
            // 
            this.milkbuyds.DataSetName = "milkbuyds";
            this.milkbuyds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // milkbuydbTableAdapter
            // 
            this.milkbuydbTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(360, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "SALARY GENERATE";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(999, 568);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(140, 73);
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sallary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuydbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuyds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView salaryview;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox AID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label salaryamount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label cattle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tliter;
        private System.Windows.Forms.Label literprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fid;
        private DS.milkbuyds milkbuyds;
        private System.Windows.Forms.BindingSource milkbuydbBindingSource;
        private DS.milkbuydsTableAdapters.MilkbuydbTableAdapter milkbuydbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cattleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn literDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
    }
}