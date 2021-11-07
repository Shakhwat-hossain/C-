namespace EcShop
{
    partial class CategoryForm
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
            this.Selling = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProRef = new System.Windows.Forms.Button();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.grdCatView = new System.Windows.Forms.DataGridView();
            this.catId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCatDesc = new System.Windows.Forms.RichTextBox();
            this.txtCatName = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCatIdTbl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCatView)).BeginInit();
            this.SuspendLayout();
            // 
            // Selling
            // 
            this.Selling.BackColor = System.Drawing.Color.Azure;
            this.Selling.FlatAppearance.BorderSize = 0;
            this.Selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selling.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Selling.Location = new System.Drawing.Point(14, 170);
            this.Selling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Selling.Name = "Selling";
            this.Selling.Size = new System.Drawing.Size(82, 45);
            this.Selling.TabIndex = 11;
            this.Selling.Text = "Selling Histry";
            this.Selling.UseVisualStyleBackColor = false;
            this.Selling.Click += new System.EventHandler(this.Selling_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Azure;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProduct.Location = new System.Drawing.Point(14, 114);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(82, 32);
            this.btnProduct.TabIndex = 10;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Azure;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProducts.Location = new System.Drawing.Point(14, 59);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(82, 32);
            this.btnProducts.TabIndex = 9;
            this.btnProducts.Text = "Sellers";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnProRef);
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.grdCatView);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtCatDesc);
            this.panel1.Controls.Add(this.txtCatName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCatIdTbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(107, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 583);
            this.panel1.TabIndex = 8;
            // 
            // btnProRef
            // 
            this.btnProRef.BackColor = System.Drawing.Color.Coral;
            this.btnProRef.FlatAppearance.BorderSize = 0;
            this.btnProRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProRef.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProRef.Location = new System.Drawing.Point(788, 69);
            this.btnProRef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProRef.Name = "btnProRef";
            this.btnProRef.Size = new System.Drawing.Size(82, 32);
            this.btnProRef.TabIndex = 39;
            this.btnProRef.Text = "Refresh";
            this.btnProRef.UseVisualStyleBackColor = false;
            this.btnProRef.Click += new System.EventHandler(this.btnProRef_Click);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtAutoSearch.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAutoSearch.Location = new System.Drawing.Point(412, 69);
            this.txtAutoSearch.Multiline = true;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(358, 27);
            this.txtAutoSearch.TabIndex = 37;
            this.txtAutoSearch.Text = "🔍 Search Category Name ";
            this.txtAutoSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAutoSearch.Click += new System.EventHandler(this.txtAutoSearch_Click);
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // grdCatView
            // 
            this.grdCatView.AllowUserToAddRows = false;
            this.grdCatView.AllowUserToDeleteRows = false;
            this.grdCatView.BackgroundColor = System.Drawing.Color.DimGray;
            this.grdCatView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCatView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catId,
            this.catName,
            this.catDesc});
            this.grdCatView.Location = new System.Drawing.Point(361, 113);
            this.grdCatView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCatView.Name = "grdCatView";
            this.grdCatView.ReadOnly = true;
            this.grdCatView.RowTemplate.Height = 28;
            this.grdCatView.Size = new System.Drawing.Size(541, 449);
            this.grdCatView.TabIndex = 36;
            this.grdCatView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCatView_CellContentClick);
            this.grdCatView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCatView_CellContentClick);
            // 
            // catId
            // 
            this.catId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catId.DataPropertyName = "CatId";
            this.catId.HeaderText = "ID";
            this.catId.Name = "catId";
            this.catId.ReadOnly = true;
            // 
            // catName
            // 
            this.catName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catName.DataPropertyName = "CatName";
            this.catName.HeaderText = "Name";
            this.catName.Name = "catName";
            this.catName.ReadOnly = true;
            // 
            // catDesc
            // 
            this.catDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catDesc.DataPropertyName = "CatDesc";
            this.catDesc.HeaderText = "Description";
            this.catDesc.Name = "catDesc";
            this.catDesc.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Coral;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Location = new System.Drawing.Point(257, 322);
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
            this.btnEdit.Location = new System.Drawing.Point(143, 322);
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
            // txtCatDesc
            // 
            this.txtCatDesc.Location = new System.Drawing.Point(112, 178);
            this.txtCatDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(227, 26);
            this.txtCatDesc.TabIndex = 30;
            this.txtCatDesc.Text = "";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(112, 131);
            this.txtCatName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(227, 26);
            this.txtCatName.TabIndex = 29;
            this.txtCatName.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Discription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name";
            // 
            // txtCatIdTbl
            // 
            this.txtCatIdTbl.Enabled = false;
            this.txtCatIdTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatIdTbl.Location = new System.Drawing.Point(112, 92);
            this.txtCatIdTbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCatIdTbl.Name = "txtCatIdTbl";
            this.txtCatIdTbl.ReadOnly = true;
            this.txtCatIdTbl.Size = new System.Drawing.Size(227, 26);
            this.txtCatIdTbl.TabIndex = 26;
            this.txtCatIdTbl.Text = "Auto Generate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
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
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Catagories";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(12, 562);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 32);
            this.button2.TabIndex = 53;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1061, 605);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Selling);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCatView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Selling;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdCatView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox txtCatDesc;
        private System.Windows.Forms.RichTextBox txtCatName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtCatIdTbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn catId;
        private System.Windows.Forms.DataGridViewTextBoxColumn catName;
        private System.Windows.Forms.DataGridViewTextBoxColumn catDesc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProRef;
    }
}