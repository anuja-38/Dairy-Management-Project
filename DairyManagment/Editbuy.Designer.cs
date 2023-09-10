namespace DairyManagment
{
    partial class Editbuy
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
            this.cattle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.AID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editview = new System.Windows.Forms.DataGridView();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cattleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milkbuydbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkbuyds = new DairyManagment.DS.milkbuyds();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tprice = new System.Windows.Forms.TextBox();
            this.liter = new System.Windows.Forms.TextBox();
            this.fat = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.BID = new System.Windows.Forms.TextBox();
            this.milkbuydbTableAdapter = new DairyManagment.DS.milkbuydsTableAdapters.MilkbuydbTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuydbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuyds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cattle);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.AID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 118);
            this.panel1.TabIndex = 0;
            // 
            // cattle
            // 
            this.cattle.AutoSize = true;
            this.cattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cattle.Location = new System.Drawing.Point(289, 92);
            this.cattle.Name = "cattle";
            this.cattle.Size = new System.Drawing.Size(70, 13);
            this.cattle.TabIndex = 8;
            this.cattle.Text = "_________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(222, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "CATTLE";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(289, 59);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(70, 13);
            this.address.TabIndex = 6;
            this.address.Text = "_________";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(370, 25);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(63, 13);
            this.lname.TabIndex = 5;
            this.lname.Text = "________";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(289, 24);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(70, 13);
            this.fname.TabIndex = 4;
            this.fname.Text = "_________";
            // 
            // AID
            // 
            this.AID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AID.Location = new System.Drawing.Point(110, 17);
            this.AID.Name = "AID";
            this.AID.Size = new System.Drawing.Size(100, 20);
            this.AID.TabIndex = 1;
            this.AID.TextChanged += new System.EventHandler(this.AID_TextChanged);
            this.AID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ADDRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACCOUNT NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "PRICE/LITER";
            // 
            // editview
            // 
            this.editview.AutoGenerateColumns = false;
            this.editview.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.editview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.aIDDataGridViewTextBoxColumn,
            this.rdateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.cattleDataGridViewTextBoxColumn,
            this.fatDataGridViewTextBoxColumn,
            this.literDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.tpriceDataGridViewTextBoxColumn});
            this.editview.DataSource = this.milkbuydbBindingSource;
            this.editview.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editview.Location = new System.Drawing.Point(12, 227);
            this.editview.Name = "editview";
            this.editview.ReadOnly = true;
            this.editview.Size = new System.Drawing.Size(658, 308);
            this.editview.TabIndex = 1;
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
            this.aIDDataGridViewTextBoxColumn.HeaderText = "ACCOUNT NO.";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rdateDataGridViewTextBoxColumn
            // 
            this.rdateDataGridViewTextBoxColumn.DataPropertyName = "rdate";
            this.rdateDataGridViewTextBoxColumn.HeaderText = "REGISTER DATE";
            this.rdateDataGridViewTextBoxColumn.Name = "rdateDataGridViewTextBoxColumn";
            this.rdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "TIME";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tprice);
            this.groupBox1.Controls.Add(this.liter);
            this.groupBox1.Controls.Add(this.fat);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.BID);
            this.groupBox1.Location = new System.Drawing.Point(696, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 441);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "MILK ID";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.price.Location = new System.Drawing.Point(150, 105);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 13;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(150, 257);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(150, 218);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 11;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "TOTAL PRICE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "LITER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FAT";
            // 
            // tprice
            // 
            this.tprice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tprice.Location = new System.Drawing.Point(150, 176);
            this.tprice.Name = "tprice";
            this.tprice.ReadOnly = true;
            this.tprice.Size = new System.Drawing.Size(100, 20);
            this.tprice.TabIndex = 6;
            // 
            // liter
            // 
            this.liter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.liter.Location = new System.Drawing.Point(150, 140);
            this.liter.Name = "liter";
            this.liter.Size = new System.Drawing.Size(100, 20);
            this.liter.TabIndex = 5;
            this.liter.TextChanged += new System.EventHandler(this.liter_TextChanged);
            this.liter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.liter_KeyPress);
            // 
            // fat
            // 
            this.fat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fat.Location = new System.Drawing.Point(150, 74);
            this.fat.Name = "fat";
            this.fat.Size = new System.Drawing.Size(100, 20);
            this.fat.TabIndex = 4;
            this.fat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fat_KeyPress);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search.Location = new System.Drawing.Point(196, 25);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 3;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // BID
            // 
            this.BID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BID.Location = new System.Drawing.Point(80, 28);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(100, 20);
            this.BID.TabIndex = 2;
            // 
            // milkbuydbTableAdapter
            // 
            this.milkbuydbTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MintCream;
            this.label9.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 34);
            this.label9.TabIndex = 3;
            this.label9.Text = "EDIT MILK DETAILS";
            // 
            // Editbuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(999, 568);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editview);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(140, 73);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editbuy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Editbuy";
            this.Load += new System.EventHandler(this.Editbuy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuydbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkbuyds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView editview;
        private System.Windows.Forms.Label cattle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.TextBox liter;
        private System.Windows.Forms.TextBox fat;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox BID;
        private System.Windows.Forms.Button delete;
        private DS.milkbuyds milkbuyds;
        private System.Windows.Forms.BindingSource milkbuydbBindingSource;
        private DS.milkbuydsTableAdapters.MilkbuydbTableAdapter milkbuydbTableAdapter;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cattleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn literDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
    }
}