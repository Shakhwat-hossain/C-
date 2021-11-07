
namespace ComputerShop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCat = new MetroFramework.Controls.MetroPanel();
            this.txtAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.cmbCF = new MetroFramework.Controls.MetroComboBox();
            this.btnCatRef = new System.Windows.Forms.Button();
            this.btnCatDel = new System.Windows.Forms.Button();
            this.btnCatEdit = new System.Windows.Forms.Button();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.dgvCF = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCat = new MetroFramework.Controls.MetroLabel();
            this.lblCatDesc = new MetroFramework.Controls.MetroLabel();
            this.lblCatName = new MetroFramework.Controls.MetroLabel();
            this.lblCatId = new MetroFramework.Controls.MetroLabel();
            this.txtCatDesc = new MetroFramework.Controls.MetroTextBox();
            this.txtCatName = new MetroFramework.Controls.MetroTextBox();
            this.txtCatId = new MetroFramework.Controls.MetroTextBox();
            this.lblCategory = new MetroFramework.Controls.MetroLabel();
            this.lblProductForm = new MetroFramework.Controls.MetroLabel();
            this.pnlCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(286, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE CATEGORY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlCat
            // 
            this.pnlCat.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlCat.Controls.Add(this.txtAutoSearch);
            this.pnlCat.Controls.Add(this.cmbCF);
            this.pnlCat.Controls.Add(this.btnCatRef);
            this.pnlCat.Controls.Add(this.btnCatDel);
            this.pnlCat.Controls.Add(this.btnCatEdit);
            this.pnlCat.Controls.Add(this.btnCatAdd);
            this.pnlCat.Controls.Add(this.dgvCF);
            this.pnlCat.Controls.Add(this.lblCat);
            this.pnlCat.Controls.Add(this.lblCatDesc);
            this.pnlCat.Controls.Add(this.lblCatName);
            this.pnlCat.Controls.Add(this.lblCatId);
            this.pnlCat.Controls.Add(this.txtCatDesc);
            this.pnlCat.Controls.Add(this.txtCatName);
            this.pnlCat.Controls.Add(this.txtCatId);
            this.pnlCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCat.HorizontalScrollbarBarColor = true;
            this.pnlCat.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCat.HorizontalScrollbarSize = 10;
            this.pnlCat.Location = new System.Drawing.Point(56, 63);
            this.pnlCat.Name = "pnlCat";
            this.pnlCat.Size = new System.Drawing.Size(745, 435);
            this.pnlCat.TabIndex = 2;
            this.pnlCat.VerticalScrollbarBarColor = true;
            this.pnlCat.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCat.VerticalScrollbarSize = 10;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            // 
            // 
            // 
            this.txtAutoSearch.CustomButton.Image = null;
            this.txtAutoSearch.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtAutoSearch.CustomButton.Name = "";
            this.txtAutoSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAutoSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAutoSearch.CustomButton.TabIndex = 1;
            this.txtAutoSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAutoSearch.CustomButton.UseSelectable = true;
            this.txtAutoSearch.CustomButton.Visible = false;
            this.txtAutoSearch.Lines = new string[0];
            this.txtAutoSearch.Location = new System.Drawing.Point(366, 23);
            this.txtAutoSearch.MaxLength = 32767;
            this.txtAutoSearch.Multiline = true;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.PasswordChar = '\0';
            this.txtAutoSearch.PromptText = "🔍 Search Category Name";
            this.txtAutoSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutoSearch.SelectedText = "";
            this.txtAutoSearch.SelectionLength = 0;
            this.txtAutoSearch.SelectionStart = 0;
            this.txtAutoSearch.ShortcutsEnabled = true;
            this.txtAutoSearch.Size = new System.Drawing.Size(186, 23);
            this.txtAutoSearch.TabIndex = 51;
            this.txtAutoSearch.UseSelectable = true;
            this.txtAutoSearch.WaterMark = "🔍 Search Category Name";
            this.txtAutoSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAutoSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            this.txtAutoSearch.Click += new System.EventHandler(this.txtAutoSearch_Click);
            // 
            // cmbCF
            // 
            this.cmbCF.FormattingEnabled = true;
            this.cmbCF.ItemHeight = 23;
            this.cmbCF.Items.AddRange(new object[] {
            "Laptop",
            "Pc"});
            this.cmbCF.Location = new System.Drawing.Point(109, 330);
            this.cmbCF.Name = "cmbCF";
            this.cmbCF.Size = new System.Drawing.Size(141, 29);
            this.cmbCF.TabIndex = 50;
            this.cmbCF.UseSelectable = true;
            // 
            // btnCatRef
            // 
            this.btnCatRef.BackColor = System.Drawing.Color.Coral;
            this.btnCatRef.FlatAppearance.BorderSize = 0;
            this.btnCatRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatRef.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatRef.Location = new System.Drawing.Point(600, 23);
            this.btnCatRef.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatRef.Name = "btnCatRef";
            this.btnCatRef.Size = new System.Drawing.Size(53, 24);
            this.btnCatRef.TabIndex = 49;
            this.btnCatRef.Text = "Refresh";
            this.btnCatRef.UseVisualStyleBackColor = false;
            this.btnCatRef.Click += new System.EventHandler(this.btnCatRef_Click);
            // 
            // btnCatDel
            // 
            this.btnCatDel.BackColor = System.Drawing.Color.Coral;
            this.btnCatDel.FlatAppearance.BorderSize = 0;
            this.btnCatDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatDel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatDel.Location = new System.Drawing.Point(197, 385);
            this.btnCatDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatDel.Name = "btnCatDel";
            this.btnCatDel.Size = new System.Drawing.Size(53, 24);
            this.btnCatDel.TabIndex = 48;
            this.btnCatDel.Text = "Delete";
            this.btnCatDel.UseVisualStyleBackColor = false;
            this.btnCatDel.Click += new System.EventHandler(this.btnCatDel_Click);
            // 
            // btnCatEdit
            // 
            this.btnCatEdit.BackColor = System.Drawing.Color.Coral;
            this.btnCatEdit.FlatAppearance.BorderSize = 0;
            this.btnCatEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatEdit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatEdit.Location = new System.Drawing.Point(120, 385);
            this.btnCatEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatEdit.Name = "btnCatEdit";
            this.btnCatEdit.Size = new System.Drawing.Size(53, 24);
            this.btnCatEdit.TabIndex = 47;
            this.btnCatEdit.Text = "Edit";
            this.btnCatEdit.UseVisualStyleBackColor = false;
            this.btnCatEdit.Click += new System.EventHandler(this.btnCatEdit_Click);
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.BackColor = System.Drawing.Color.Coral;
            this.btnCatAdd.FlatAppearance.BorderSize = 0;
            this.btnCatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatAdd.Location = new System.Drawing.Point(39, 385);
            this.btnCatAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(53, 24);
            this.btnCatAdd.TabIndex = 46;
            this.btnCatAdd.Text = "Add";
            this.btnCatAdd.UseVisualStyleBackColor = false;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // dgvCF
            // 
            this.dgvCF.AllowUserToAddRows = false;
            this.dgvCF.AllowUserToDeleteRows = false;
            this.dgvCF.AllowUserToResizeRows = false;
            this.dgvCF.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvCF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.CatName,
            this.CatDesc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCF.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCF.EnableHeadersVisualStyles = false;
            this.dgvCF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCF.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCF.Location = new System.Drawing.Point(312, 60);
            this.dgvCF.Name = "dgvCF";
            this.dgvCF.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCF.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCF.Size = new System.Drawing.Size(417, 362);
            this.dgvCF.TabIndex = 12;
            this.dgvCF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCF_CellContentClick);
            this.dgvCF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCF_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Category                ID";
            this.id.Name = "id";
            // 
            // CatName
            // 
            this.CatName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CatName.DataPropertyName = "CatName";
            this.CatName.HeaderText = "Category            Name";
            this.CatName.Name = "CatName";
            // 
            // CatDesc
            // 
            this.CatDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CatDesc.DataPropertyName = "CatDesc";
            this.CatDesc.HeaderText = "Description              ";
            this.CatDesc.Name = "CatDesc";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(10, 330);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(64, 19);
            this.lblCat.TabIndex = 11;
            this.lblCat.Text = "Category";
            // 
            // lblCatDesc
            // 
            this.lblCatDesc.AutoSize = true;
            this.lblCatDesc.BackColor = System.Drawing.Color.OrangeRed;
            this.lblCatDesc.Location = new System.Drawing.Point(10, 118);
            this.lblCatDesc.Name = "lblCatDesc";
            this.lblCatDesc.Size = new System.Drawing.Size(74, 19);
            this.lblCatDesc.TabIndex = 9;
            this.lblCatDesc.Text = "Description";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.BackColor = System.Drawing.Color.OrangeRed;
            this.lblCatName.Location = new System.Drawing.Point(10, 89);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(45, 19);
            this.lblCatName.TabIndex = 8;
            this.lblCatName.Text = "Name";
            // 
            // lblCatId
            // 
            this.lblCatId.AutoSize = true;
            this.lblCatId.BackColor = System.Drawing.Color.OrangeRed;
            this.lblCatId.Location = new System.Drawing.Point(10, 60);
            this.lblCatId.Name = "lblCatId";
            this.lblCatId.Size = new System.Drawing.Size(21, 19);
            this.lblCatId.TabIndex = 7;
            this.lblCatId.Text = "ID";
            // 
            // txtCatDesc
            // 
            // 
            // 
            // 
            this.txtCatDesc.CustomButton.Image = null;
            this.txtCatDesc.CustomButton.Location = new System.Drawing.Point(2, 2);
            this.txtCatDesc.CustomButton.Name = "";
            this.txtCatDesc.CustomButton.Size = new System.Drawing.Size(181, 181);
            this.txtCatDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCatDesc.CustomButton.TabIndex = 1;
            this.txtCatDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCatDesc.CustomButton.UseSelectable = true;
            this.txtCatDesc.CustomButton.Visible = false;
            this.txtCatDesc.Lines = new string[0];
            this.txtCatDesc.Location = new System.Drawing.Point(109, 118);
            this.txtCatDesc.MaxLength = 32767;
            this.txtCatDesc.Multiline = true;
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.PasswordChar = '\0';
            this.txtCatDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCatDesc.SelectedText = "";
            this.txtCatDesc.SelectionLength = 0;
            this.txtCatDesc.SelectionStart = 0;
            this.txtCatDesc.ShortcutsEnabled = true;
            this.txtCatDesc.Size = new System.Drawing.Size(186, 186);
            this.txtCatDesc.TabIndex = 4;
            this.txtCatDesc.UseSelectable = true;
            this.txtCatDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCatDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCatName
            // 
            // 
            // 
            // 
            this.txtCatName.CustomButton.Image = null;
            this.txtCatName.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtCatName.CustomButton.Name = "";
            this.txtCatName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCatName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCatName.CustomButton.TabIndex = 1;
            this.txtCatName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCatName.CustomButton.UseSelectable = true;
            this.txtCatName.CustomButton.Visible = false;
            this.txtCatName.Lines = new string[0];
            this.txtCatName.Location = new System.Drawing.Point(109, 89);
            this.txtCatName.MaxLength = 32767;
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.PasswordChar = '\0';
            this.txtCatName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCatName.SelectedText = "";
            this.txtCatName.SelectionLength = 0;
            this.txtCatName.SelectionStart = 0;
            this.txtCatName.ShortcutsEnabled = true;
            this.txtCatName.Size = new System.Drawing.Size(186, 23);
            this.txtCatName.TabIndex = 3;
            this.txtCatName.UseSelectable = true;
            this.txtCatName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCatName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCatId
            // 
            // 
            // 
            // 
            this.txtCatId.CustomButton.Image = null;
            this.txtCatId.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtCatId.CustomButton.Name = "";
            this.txtCatId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCatId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCatId.CustomButton.TabIndex = 1;
            this.txtCatId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCatId.CustomButton.UseSelectable = true;
            this.txtCatId.CustomButton.Visible = false;
            this.txtCatId.Lines = new string[0];
            this.txtCatId.Location = new System.Drawing.Point(109, 60);
            this.txtCatId.MaxLength = 32767;
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.PasswordChar = '\0';
            this.txtCatId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCatId.SelectedText = "";
            this.txtCatId.SelectionLength = 0;
            this.txtCatId.SelectionStart = 0;
            this.txtCatId.ShortcutsEnabled = true;
            this.txtCatId.Size = new System.Drawing.Size(186, 23);
            this.txtCatId.TabIndex = 2;
            this.txtCatId.UseSelectable = true;
            this.txtCatId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCatId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(102, 16);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 19);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Selling Form";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblProductForm
            // 
            this.lblProductForm.AutoSize = true;
            this.lblProductForm.Location = new System.Drawing.Point(5, 16);
            this.lblProductForm.Name = "lblProductForm";
            this.lblProductForm.Size = new System.Drawing.Size(91, 19);
            this.lblProductForm.TabIndex = 5;
            this.lblProductForm.Text = "Product Form";
            this.lblProductForm.Click += new System.EventHandler(this.lblProductForm_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProductForm);
            this.Controls.Add(this.pnlCat);
            this.Controls.Add(this.label1);
            this.Name = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.pnlCat.ResumeLayout(false);
            this.pnlCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel pnlCat;
        private MetroFramework.Controls.MetroTextBox txtAutoSearch;
        private MetroFramework.Controls.MetroComboBox cmbCF;
        private System.Windows.Forms.Button btnCatRef;
        private System.Windows.Forms.Button btnCatDel;
        private System.Windows.Forms.Button btnCatEdit;
        private System.Windows.Forms.Button btnCatAdd;
        private MetroFramework.Controls.MetroGrid dgvCF;
        private MetroFramework.Controls.MetroLabel lblCat;
        private MetroFramework.Controls.MetroLabel lblCatDesc;
        private MetroFramework.Controls.MetroLabel lblCatName;
        private MetroFramework.Controls.MetroLabel lblCatId;
        private MetroFramework.Controls.MetroTextBox txtCatDesc;
        private MetroFramework.Controls.MetroTextBox txtCatName;
        private MetroFramework.Controls.MetroTextBox txtCatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatDesc;
        private MetroFramework.Controls.MetroLabel lblCategory;
        private MetroFramework.Controls.MetroLabel lblProductForm;
    }
}