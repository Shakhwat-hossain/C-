namespace EcShop
{
    partial class ProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.txtProPrice = new System.Windows.Forms.RichTextBox();
            this.btnProRef = new System.Windows.Forms.Button();
            this.grdProductView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProDel = new System.Windows.Forms.Button();
            this.btnProEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbProdCat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProQn = new System.Windows.Forms.RichTextBox();
            this.txtProName = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProId = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.txtProPrice);
            this.panel1.Controls.Add(this.btnProRef);
            this.panel1.Controls.Add(this.grdProductView);
            this.panel1.Controls.Add(this.btnProDel);
            this.panel1.Controls.Add(this.btnProEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cmbProdCat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProQn);
            this.panel1.Controls.Add(this.txtProName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(107, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 583);
            this.panel1.TabIndex = 0;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtAutoSearch.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAutoSearch.Location = new System.Drawing.Point(392, 71);
            this.txtAutoSearch.Multiline = true;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(358, 27);
            this.txtAutoSearch.TabIndex = 40;
            this.txtAutoSearch.Text = "🔍 Search Product Name ";
            this.txtAutoSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAutoSearch.Click += new System.EventHandler(this.txtAutoSearch_Click);
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // txtProPrice
            // 
            this.txtProPrice.Location = new System.Drawing.Point(112, 215);
            this.txtProPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(227, 26);
            this.txtProPrice.TabIndex = 39;
            this.txtProPrice.Text = "";
            // 
            // btnProRef
            // 
            this.btnProRef.BackColor = System.Drawing.Color.Coral;
            this.btnProRef.FlatAppearance.BorderSize = 0;
            this.btnProRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProRef.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProRef.Location = new System.Drawing.Point(756, 71);
            this.btnProRef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProRef.Name = "btnProRef";
            this.btnProRef.Size = new System.Drawing.Size(82, 32);
            this.btnProRef.TabIndex = 38;
            this.btnProRef.Text = "Refresh";
            this.btnProRef.UseVisualStyleBackColor = false;
            this.btnProRef.Click += new System.EventHandler(this.btnProRef_Click);
            // 
            // grdProductView
            // 
            this.grdProductView.AllowUserToAddRows = false;
            this.grdProductView.AllowUserToDeleteRows = false;
            this.grdProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProName,
            this.ProQty,
            this.ProPrice,
            this.ProCat});
            this.grdProductView.Location = new System.Drawing.Point(362, 114);
            this.grdProductView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdProductView.Name = "grdProductView";
            this.grdProductView.ReadOnly = true;
            this.grdProductView.RowTemplate.Height = 28;
            this.grdProductView.Size = new System.Drawing.Size(499, 462);
            this.grdProductView.TabIndex = 36;
            this.grdProductView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grdProductView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ProName
            // 
            this.ProName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProName.DataPropertyName = "ProName";
            this.ProName.HeaderText = "Product name";
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            // 
            // ProQty
            // 
            this.ProQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProQty.DataPropertyName = "ProQty";
            this.ProQty.HeaderText = "Product Quantity";
            this.ProQty.Name = "ProQty";
            this.ProQty.ReadOnly = true;
            // 
            // ProPrice
            // 
            this.ProPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProPrice.DataPropertyName = "ProPrice";
            this.ProPrice.HeaderText = "Product Price";
            this.ProPrice.Name = "ProPrice";
            this.ProPrice.ReadOnly = true;
            // 
            // ProCat
            // 
            this.ProCat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProCat.DataPropertyName = "ProCat";
            this.ProCat.HeaderText = "Product Category";
            this.ProCat.Name = "ProCat";
            this.ProCat.ReadOnly = true;
            // 
            // btnProDel
            // 
            this.btnProDel.BackColor = System.Drawing.Color.Coral;
            this.btnProDel.FlatAppearance.BorderSize = 0;
            this.btnProDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProDel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProDel.Location = new System.Drawing.Point(269, 353);
            this.btnProDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProDel.Name = "btnProDel";
            this.btnProDel.Size = new System.Drawing.Size(82, 32);
            this.btnProDel.TabIndex = 35;
            this.btnProDel.Text = "Delete";
            this.btnProDel.UseVisualStyleBackColor = false;
            this.btnProDel.Click += new System.EventHandler(this.btnProDel_Click);
            // 
            // btnProEdit
            // 
            this.btnProEdit.BackColor = System.Drawing.Color.Coral;
            this.btnProEdit.FlatAppearance.BorderSize = 0;
            this.btnProEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProEdit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProEdit.Location = new System.Drawing.Point(149, 353);
            this.btnProEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProEdit.Name = "btnProEdit";
            this.btnProEdit.Size = new System.Drawing.Size(82, 32);
            this.btnProEdit.TabIndex = 34;
            this.btnProEdit.Text = "Edit";
            this.btnProEdit.UseVisualStyleBackColor = false;
            this.btnProEdit.Click += new System.EventHandler(this.btnProEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Coral;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Location = new System.Drawing.Point(24, 353);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbProdCat
            // 
            this.cmbProdCat.FormattingEnabled = true;
            this.cmbProdCat.Location = new System.Drawing.Point(112, 268);
            this.cmbProdCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProdCat.Name = "cmbProdCat";
            this.cmbProdCat.Size = new System.Drawing.Size(227, 24);
            this.cmbProdCat.TabIndex = 33;
            this.cmbProdCat.Text = "Select Catagory";
            this.cmbProdCat.SelectedIndexChanged += new System.EventHandler(this.cmbProdCat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Price";
            // 
            // txtProQn
            // 
            this.txtProQn.Location = new System.Drawing.Point(112, 167);
            this.txtProQn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProQn.Name = "txtProQn";
            this.txtProQn.Size = new System.Drawing.Size(227, 26);
            this.txtProQn.TabIndex = 30;
            this.txtProQn.Text = "";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(112, 120);
            this.txtProName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(227, 26);
            this.txtProName.TabIndex = 29;
            this.txtProName.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name";
            // 
            // txtProId
            // 
            this.txtProId.Location = new System.Drawing.Point(112, 81);
            this.txtProId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProId.Name = "txtProId";
            this.txtProId.Size = new System.Drawing.Size(227, 26);
            this.txtProId.TabIndex = 26;
            this.txtProId.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblClose.Location = new System.Drawing.Point(915, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 27);
            this.lblClose.TabIndex = 24;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F);
            this.label1.Location = new System.Drawing.Point(314, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(12, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seller";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Azure;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCategory.Location = new System.Drawing.Point(12, 131);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(82, 32);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Catagory";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(12, 187);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Selling Histry";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(12, 555);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 32);
            this.button2.TabIndex = 53;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 605);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.RichTextBox txtProId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProRef;
        private System.Windows.Forms.DataGridView grdProductView;
        private System.Windows.Forms.Button btnProDel;
        private System.Windows.Forms.Button btnProEdit;
        private System.Windows.Forms.ComboBox cmbProdCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtProQn;
        private System.Windows.Forms.RichTextBox txtProName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtProPrice;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCat;
        private System.Windows.Forms.Button button2;
    }
}