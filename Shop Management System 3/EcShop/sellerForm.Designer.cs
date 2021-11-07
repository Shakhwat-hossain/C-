namespace EcShop
{
    partial class sellerForm
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
            this.btnReff = new System.Windows.Forms.Button();
            this.dgvSellerView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdSelr = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCate = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.RichTextBox();
            this.txtPhone = new System.Windows.Forms.RichTextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SellerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReff
            // 
            this.btnReff.BackColor = System.Drawing.Color.Coral;
            this.btnReff.FlatAppearance.BorderSize = 0;
            this.btnReff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReff.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReff.Location = new System.Drawing.Point(764, 53);
            this.btnReff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReff.Name = "btnReff";
            this.btnReff.Size = new System.Drawing.Size(82, 32);
            this.btnReff.TabIndex = 38;
            this.btnReff.Text = "Refresh";
            this.btnReff.UseVisualStyleBackColor = false;
            this.btnReff.Click += new System.EventHandler(this.btnReff_Click);
            // 
            // dgvSellerView
            // 
            this.dgvSellerView.AllowUserToAddRows = false;
            this.dgvSellerView.AllowUserToDeleteRows = false;
            this.dgvSellerView.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvSellerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellerId,
            this.SellerName,
            this.SellerAge,
            this.SellerPhone,
            this.SellerPass});
            this.dgvSellerView.Location = new System.Drawing.Point(373, 99);
            this.dgvSellerView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSellerView.Name = "dgvSellerView";
            this.dgvSellerView.ReadOnly = true;
            this.dgvSellerView.RowTemplate.Height = 28;
            this.dgvSellerView.Size = new System.Drawing.Size(499, 462);
            this.dgvSellerView.TabIndex = 36;
            this.dgvSellerView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellerView_CellClick);
            this.dgvSellerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellerView_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Coral;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Location = new System.Drawing.Point(274, 322);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 32);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Coral;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.Location = new System.Drawing.Point(154, 322);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 32);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Coral;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Location = new System.Drawing.Point(29, 322);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Siyam Rupali", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Siyam Rupali", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Phone ";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(112, 162);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(227, 26);
            this.txtAge.TabIndex = 30;
            this.txtAge.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 115);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 26);
            this.txtName.TabIndex = 29;
            this.txtName.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Siyam Rupali", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Age";
            // 
            // txtIdSelr
            // 
            this.txtIdSelr.Enabled = false;
            this.txtIdSelr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSelr.Location = new System.Drawing.Point(112, 76);
            this.txtIdSelr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdSelr.Name = "txtIdSelr";
            this.txtIdSelr.Size = new System.Drawing.Size(227, 26);
            this.txtIdSelr.TabIndex = 26;
            this.txtIdSelr.Text = "Auto Generated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Siyam Rupali", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblClose.Location = new System.Drawing.Point(918, -5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 27);
            this.lblClose.TabIndex = 24;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(12, 174);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "Selling Histry";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCate
            // 
            this.btnCate.BackColor = System.Drawing.Color.Azure;
            this.btnCate.FlatAppearance.BorderSize = 0;
            this.btnCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCate.Location = new System.Drawing.Point(12, 121);
            this.btnCate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(82, 32);
            this.btnCate.TabIndex = 6;
            this.btnCate.Text = "Catagories";
            this.btnCate.UseVisualStyleBackColor = false;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Azure;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProducts.Location = new System.Drawing.Point(12, 64);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(82, 32);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Siyam Rupali", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F);
            this.label1.Location = new System.Drawing.Point(330, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Sellers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.btnReff);
            this.panel1.Controls.Add(this.dgvSellerView);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIdSelr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(113, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 583);
            this.panel1.TabIndex = 4;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtAutoSearch.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAutoSearch.Location = new System.Drawing.Point(400, 58);
            this.txtAutoSearch.Multiline = true;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(358, 27);
            this.txtAutoSearch.TabIndex = 41;
            this.txtAutoSearch.Text = "🔍 Search Seller Name ";
            this.txtAutoSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAutoSearch.Click += new System.EventHandler(this.txtAutoSearch_Click);
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(112, 267);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(227, 26);
            this.txtPass.TabIndex = 40;
            this.txtPass.Text = "";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(112, 217);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(227, 26);
            this.txtPhone.TabIndex = 39;
            this.txtPhone.Text = "";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Snow;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.Location = new System.Drawing.Point(12, 562);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 32);
            this.btnLogOut.TabIndex = 54;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // SellerId
            // 
            this.SellerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellerId.DataPropertyName = "SellerId";
            this.SellerId.HeaderText = "Seller ID";
            this.SellerId.Name = "SellerId";
            this.SellerId.ReadOnly = true;
            // 
            // SellerName
            // 
            this.SellerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellerName.DataPropertyName = "SellerName";
            this.SellerName.HeaderText = "Seller Name";
            this.SellerName.Name = "SellerName";
            this.SellerName.ReadOnly = true;
            // 
            // SellerAge
            // 
            this.SellerAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellerAge.DataPropertyName = "SellerAge";
            this.SellerAge.HeaderText = "Saller Age";
            this.SellerAge.Name = "SellerAge";
            this.SellerAge.ReadOnly = true;
            // 
            // SellerPhone
            // 
            this.SellerPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellerPhone.DataPropertyName = "SellerPhone";
            this.SellerPhone.HeaderText = "Phone Number";
            this.SellerPhone.Name = "SellerPhone";
            this.SellerPhone.ReadOnly = true;
            // 
            // SellerPass
            // 
            this.SellerPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellerPass.DataPropertyName = "SellerPass";
            this.SellerPass.HeaderText = "Seller Password";
            this.SellerPass.Name = "SellerPass";
            this.SellerPass.ReadOnly = true;
            // 
            // sellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1061, 605);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCate);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sellerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReff;
        private System.Windows.Forms.DataGridView dgvSellerView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtAge;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtIdSelr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCate;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtPhone;
        private System.Windows.Forms.RichTextBox txtPass;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerPass;
    }
}