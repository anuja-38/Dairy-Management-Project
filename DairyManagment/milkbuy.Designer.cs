namespace DairyManagment
{
    partial class milkbuy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cattle = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addrecord = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lebelliter = new System.Windows.Forms.Label();
            this.mtprice = new System.Windows.Forms.TextBox();
            this.mfat = new System.Windows.Forms.TextBox();
            this.mprice = new System.Windows.Forms.TextBox();
            this.liter = new System.Windows.Forms.TextBox();
            this.viewrecord = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cattleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milkbuydbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkbuyds = new DairyManagment.DS.milkbuyds();
            this.milkbuydbTableAdapter = new DairyManagment.DS.milkbuydsTableAdapters.MilkbuydbTableAdapter();
            this.todayview = new System.Windows.Forms.DataGridView();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cattleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milkbuydbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewrecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuydbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuyds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuydbBindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.cattle);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AID);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // cattle
            // 
            this.cattle.AutoSize = true;
            this.cattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cattle.Location = new System.Drawing.Point(461, 64);
            this.cattle.Name = "cattle";
            this.cattle.Size = new System.Drawing.Size(77, 13);
            this.cattle.TabIndex = 6;
            this.cattle.Text = "__________";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(384, 64);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(54, 13);
            this.c.TabIndex = 5;
            this.c.Text = "CATTLE";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(557, 29);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(77, 13);
            this.lname.TabIndex = 4;
            this.lname.Text = "__________";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(461, 29);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(77, 13);
            this.fname.TabIndex = 3;
            this.fname.Text = "__________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACCOUNT NO";
            // 
            // AID
            // 
            this.AID.BackColor = System.Drawing.Color.White;
            this.AID.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AID.Location = new System.Drawing.Point(182, 29);
            this.AID.Name = "AID";
            this.AID.Size = new System.Drawing.Size(100, 21);
            this.AID.TabIndex = 0;
            this.AID.TextChanged += new System.EventHandler(this.AID_TextChanged_1);
            this.AID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AID_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.addrecord);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lebelliter);
            this.groupBox2.Controls.Add(this.mtprice);
            this.groupBox2.Controls.Add(this.mfat);
            this.groupBox2.Controls.Add(this.mprice);
            this.groupBox2.Controls.Add(this.liter);
            this.groupBox2.Location = new System.Drawing.Point(1, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "milk detail";
            // 
            // addrecord
            // 
            this.addrecord.BackColor = System.Drawing.Color.Gray;
            this.addrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrecord.Location = new System.Drawing.Point(387, 103);
            this.addrecord.Name = "addrecord";
            this.addrecord.Size = new System.Drawing.Size(100, 23);
            this.addrecord.TabIndex = 12;
            this.addrecord.Text = "ADD RECORD";
            this.addrecord.UseVisualStyleBackColor = false;
            this.addrecord.Click += new System.EventHandler(this.addrecord_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(289, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "TOTAL PRICE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "FAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(291, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "PRICE/LITER";
            // 
            // lebelliter
            // 
            this.lebelliter.AutoSize = true;
            this.lebelliter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebelliter.Location = new System.Drawing.Point(30, 26);
            this.lebelliter.Name = "lebelliter";
            this.lebelliter.Size = new System.Drawing.Size(43, 13);
            this.lebelliter.TabIndex = 8;
            this.lebelliter.Text = "LITER";
            // 
            // mtprice
            // 
            this.mtprice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mtprice.Location = new System.Drawing.Point(387, 63);
            this.mtprice.Name = "mtprice";
            this.mtprice.Size = new System.Drawing.Size(100, 20);
            this.mtprice.TabIndex = 4;
            // 
            // mfat
            // 
            this.mfat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mfat.Location = new System.Drawing.Point(119, 59);
            this.mfat.Name = "mfat";
            this.mfat.Size = new System.Drawing.Size(100, 20);
            this.mfat.TabIndex = 3;
            this.mfat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mfat_KeyPress);
            // 
            // mprice
            // 
            this.mprice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mprice.Location = new System.Drawing.Point(387, 26);
            this.mprice.Name = "mprice";
            this.mprice.Size = new System.Drawing.Size(100, 20);
            this.mprice.TabIndex = 2;
            // 
            // liter
            // 
            this.liter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.liter.Location = new System.Drawing.Point(119, 23);
            this.liter.Name = "liter";
            this.liter.Size = new System.Drawing.Size(100, 20);
            this.liter.TabIndex = 1;
            this.liter.TextChanged += new System.EventHandler(this.liter_TextChanged);
            this.liter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.liter_KeyPress);
            // 
            // viewrecord
            // 
            this.viewrecord.AutoGenerateColumns = false;
            this.viewrecord.BackgroundColor = System.Drawing.Color.Black;
            this.viewrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewrecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.BID,
            this.cattleDataGridViewTextBoxColumn,
            this.fatDataGridViewTextBoxColumn,
            this.literDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.tpriceDataGridViewTextBoxColumn});
            this.viewrecord.DataSource = this.milkbuydbBindingSource;
            this.viewrecord.GridColor = System.Drawing.Color.Black;
            this.viewrecord.Location = new System.Drawing.Point(1, 326);
            this.viewrecord.Name = "viewrecord";
            this.viewrecord.Size = new System.Drawing.Size(526, 230);
            this.viewrecord.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ACCOUNT NO.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // BID
            // 
            this.BID.DataPropertyName = "BID";
            this.BID.HeaderText = "MILK ID";
            this.BID.Name = "BID";
            this.BID.ReadOnly = true;
            // 
            // cattleDataGridViewTextBoxColumn
            // 
            this.cattleDataGridViewTextBoxColumn.DataPropertyName = "cattle";
            this.cattleDataGridViewTextBoxColumn.HeaderText = "CATTLE";
            this.cattleDataGridViewTextBoxColumn.Name = "cattleDataGridViewTextBoxColumn";
            this.cattleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatDataGridViewTextBoxColumn
            // 
            this.fatDataGridViewTextBoxColumn.DataPropertyName = "fat";
            this.fatDataGridViewTextBoxColumn.HeaderText = "FAT";
            this.fatDataGridViewTextBoxColumn.Name = "fatDataGridViewTextBoxColumn";
            this.fatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // literDataGridViewTextBoxColumn
            // 
            this.literDataGridViewTextBoxColumn.DataPropertyName = "liter";
            this.literDataGridViewTextBoxColumn.HeaderText = "LITER";
            this.literDataGridViewTextBoxColumn.Name = "literDataGridViewTextBoxColumn";
            this.literDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "PRICE/LITER";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tpriceDataGridViewTextBoxColumn
            // 
            this.tpriceDataGridViewTextBoxColumn.DataPropertyName = "tprice";
            this.tpriceDataGridViewTextBoxColumn.HeaderText = "TOTAL PRICE";
            this.tpriceDataGridViewTextBoxColumn.Name = "tpriceDataGridViewTextBoxColumn";
            this.tpriceDataGridViewTextBoxColumn.ReadOnly = true;
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
            // todayview
            // 
            this.todayview.AutoGenerateColumns = false;
            this.todayview.BackgroundColor = System.Drawing.Color.Black;
            this.todayview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todayview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn,
            this.rdateDataGridViewTextBoxColumn,
            this.cattleDataGridViewTextBoxColumn1,
            this.fatDataGridViewTextBoxColumn1,
            this.literDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.tpriceDataGridViewTextBoxColumn1});
            this.todayview.DataSource = this.milkbuydbBindingSource1;
            this.todayview.GridColor = System.Drawing.Color.Black;
            this.todayview.Location = new System.Drawing.Point(3, 106);
            this.todayview.Name = "todayview";
            this.todayview.Size = new System.Drawing.Size(451, 262);
            this.todayview.TabIndex = 3;
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "AID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "ACCOUNT NO";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            // 
            // rdateDataGridViewTextBoxColumn
            // 
            this.rdateDataGridViewTextBoxColumn.DataPropertyName = "rdate";
            this.rdateDataGridViewTextBoxColumn.HeaderText = "ENTRY DATE";
            this.rdateDataGridViewTextBoxColumn.Name = "rdateDataGridViewTextBoxColumn";
            // 
            // cattleDataGridViewTextBoxColumn1
            // 
            this.cattleDataGridViewTextBoxColumn1.DataPropertyName = "cattle";
            this.cattleDataGridViewTextBoxColumn1.HeaderText = "CATTLE";
            this.cattleDataGridViewTextBoxColumn1.Name = "cattleDataGridViewTextBoxColumn1";
            // 
            // fatDataGridViewTextBoxColumn1
            // 
            this.fatDataGridViewTextBoxColumn1.DataPropertyName = "fat";
            this.fatDataGridViewTextBoxColumn1.HeaderText = "FAT";
            this.fatDataGridViewTextBoxColumn1.Name = "fatDataGridViewTextBoxColumn1";
            // 
            // literDataGridViewTextBoxColumn1
            // 
            this.literDataGridViewTextBoxColumn1.DataPropertyName = "liter";
            this.literDataGridViewTextBoxColumn1.HeaderText = "LITER";
            this.literDataGridViewTextBoxColumn1.Name = "literDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "PRICE/LITER";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // tpriceDataGridViewTextBoxColumn1
            // 
            this.tpriceDataGridViewTextBoxColumn1.DataPropertyName = "tprice";
            this.tpriceDataGridViewTextBoxColumn1.HeaderText = "TOTAL PRICE";
            this.tpriceDataGridViewTextBoxColumn1.Name = "tpriceDataGridViewTextBoxColumn1";
            // 
            // milkbuydbBindingSource1
            // 
            this.milkbuydbBindingSource1.DataMember = "Milkbuydb";
            this.milkbuydbBindingSource1.DataSource = this.milkbuyds;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.todayview);
            this.groupBox3.Location = new System.Drawing.Point(533, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 368);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(42, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "TODAY SESSION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(380, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "MILK BUY ";
            // 
            // milkbuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(999, 568);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.viewrecord);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(140, 73);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "milkbuy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.milkbuy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewrecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuydbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuyds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuydbBindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cattle;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addrecord;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lebelliter;
        private System.Windows.Forms.TextBox mtprice;
        private System.Windows.Forms.TextBox mfat;
        private System.Windows.Forms.TextBox mprice;
        private System.Windows.Forms.TextBox liter;
        private System.Windows.Forms.DataGridView viewrecord;
        private DS.milkbuyds milkbuyds;
        private System.Windows.Forms.BindingSource milkbuydbBindingSource;
        private DS.milkbuydsTableAdapters.MilkbuydbTableAdapter milkbuydbTableAdapter;
        private System.Windows.Forms.DataGridView todayview;
        private System.Windows.Forms.BindingSource milkbuydbBindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cattleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn literDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cattleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn literDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpriceDataGridViewTextBoxColumn1;
    }
}