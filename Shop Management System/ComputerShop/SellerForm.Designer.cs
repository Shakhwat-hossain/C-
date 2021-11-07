
namespace ComputerShop
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtSellerPass = new MetroFramework.Controls.MetroTextBox();
            this.txtAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSlrRef = new System.Windows.Forms.Button();
            this.btnSlrDel = new System.Windows.Forms.Button();
            this.btnSlrEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSlrF = new MetroFramework.Controls.MetroGrid();
            this.SellerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSellerPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtSellerAge = new MetroFramework.Controls.MetroTextBox();
            this.txtSellerName = new MetroFramework.Controls.MetroTextBox();
            this.txtSellerId = new MetroFramework.Controls.MetroTextBox();
            this.lblProductForm = new MetroFramework.Controls.MetroLabel();
            this.lblCategory = new MetroFramework.Controls.MetroLabel();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlrF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(286, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE SELLER";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroPanel1.Controls.Add(this.btnClearOrder);
            this.metroPanel1.Controls.Add(this.txtSellerPass);
            this.metroPanel1.Controls.Add(this.txtAutoSearch);
            this.metroPanel1.Controls.Add(this.btnSlrRef);
            this.metroPanel1.Controls.Add(this.btnSlrDel);
            this.metroPanel1.Controls.Add(this.btnSlrEdit);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.dgvSlrF);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtSellerPhone);
            this.metroPanel1.Controls.Add(this.txtSellerAge);
            this.metroPanel1.Controls.Add(this.txtSellerName);
            this.metroPanel1.Controls.Add(this.txtSellerId);
            this.metroPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(56, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(745, 435);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtSellerPass
            // 
            // 
            // 
            // 
            this.txtSellerPass.CustomButton.Image = null;
            this.txtSellerPass.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtSellerPass.CustomButton.Name = "";
            this.txtSellerPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSellerPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSellerPass.CustomButton.TabIndex = 1;
            this.txtSellerPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSellerPass.CustomButton.UseSelectable = true;
            this.txtSellerPass.CustomButton.Visible = false;
            this.txtSellerPass.Lines = new string[0];
            this.txtSellerPass.Location = new System.Drawing.Point(109, 182);
            this.txtSellerPass.MaxLength = 32767;
            this.txtSellerPass.Name = "txtSellerPass";
            this.txtSellerPass.PasswordChar = '\0';
            this.txtSellerPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSellerPass.SelectedText = "";
            this.txtSellerPass.SelectionLength = 0;
            this.txtSellerPass.SelectionStart = 0;
            this.txtSellerPass.ShortcutsEnabled = true;
            this.txtSellerPass.Size = new System.Drawing.Size(186, 23);
            this.txtSellerPass.TabIndex = 52;
            this.txtSellerPass.UseSelectable = true;
            this.txtSellerPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSellerPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtAutoSearch.Location = new System.Drawing.Point(344, 23);
            this.txtAutoSearch.MaxLength = 32767;
            this.txtAutoSearch.Multiline = true;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.PasswordChar = '\0';
            this.txtAutoSearch.PromptText = "🔍 Search Name";
            this.txtAutoSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutoSearch.SelectedText = "";
            this.txtAutoSearch.SelectionLength = 0;
            this.txtAutoSearch.SelectionStart = 0;
            this.txtAutoSearch.ShortcutsEnabled = true;
            this.txtAutoSearch.Size = new System.Drawing.Size(186, 23);
            this.txtAutoSearch.TabIndex = 51;
            this.txtAutoSearch.UseSelectable = true;
            this.txtAutoSearch.WaterMark = "🔍 Search Name";
            this.txtAutoSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAutoSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            this.txtAutoSearch.Click += new System.EventHandler(this.txtAutoSearch_Click);
            // 
            // btnSlrRef
            // 
            this.btnSlrRef.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSlrRef.FlatAppearance.BorderSize = 0;
            this.btnSlrRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlrRef.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSlrRef.Location = new System.Drawing.Point(566, 23);
            this.btnSlrRef.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlrRef.Name = "btnSlrRef";
            this.btnSlrRef.Size = new System.Drawing.Size(53, 24);
            this.btnSlrRef.TabIndex = 49;
            this.btnSlrRef.Text = "Refresh";
            this.btnSlrRef.UseVisualStyleBackColor = false;
            this.btnSlrRef.Click += new System.EventHandler(this.btnSlrRef_Click);
            // 
            // btnSlrDel
            // 
            this.btnSlrDel.BackColor = System.Drawing.Color.Coral;
            this.btnSlrDel.FlatAppearance.BorderSize = 0;
            this.btnSlrDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlrDel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSlrDel.Location = new System.Drawing.Point(197, 230);
            this.btnSlrDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlrDel.Name = "btnSlrDel";
            this.btnSlrDel.Size = new System.Drawing.Size(53, 24);
            this.btnSlrDel.TabIndex = 48;
            this.btnSlrDel.Text = "Delete";
            this.btnSlrDel.UseVisualStyleBackColor = false;
            this.btnSlrDel.Click += new System.EventHandler(this.btnSlrDel_Click);
            // 
            // btnSlrEdit
            // 
            this.btnSlrEdit.BackColor = System.Drawing.Color.Coral;
            this.btnSlrEdit.FlatAppearance.BorderSize = 0;
            this.btnSlrEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlrEdit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSlrEdit.Location = new System.Drawing.Point(120, 230);
            this.btnSlrEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlrEdit.Name = "btnSlrEdit";
            this.btnSlrEdit.Size = new System.Drawing.Size(53, 24);
            this.btnSlrEdit.TabIndex = 47;
            this.btnSlrEdit.Text = "Edit";
            this.btnSlrEdit.UseVisualStyleBackColor = false;
            this.btnSlrEdit.Click += new System.EventHandler(this.btnSlrEdit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(39, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 24);
            this.button1.TabIndex = 46;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSlrF
            // 
            this.dgvSlrF.AllowUserToAddRows = false;
            this.dgvSlrF.AllowUserToDeleteRows = false;
            this.dgvSlrF.AllowUserToResizeRows = false;
            this.dgvSlrF.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvSlrF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSlrF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSlrF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSlrF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSlrF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlrF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellerId,
            this.SellerName,
            this.SellerAge,
            this.SellerPhone,
            this.SellerPass});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSlrF.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSlrF.EnableHeadersVisualStyles = false;
            this.dgvSlrF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSlrF.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSlrF.Location = new System.Drawing.Point(312, 60);
            this.dgvSlrF.Name = "dgvSlrF";
            this.dgvSlrF.ReadOnly = true;
            this.dgvSlrF.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSlrF.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSlrF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSlrF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlrF.Size = new System.Drawing.Size(417, 362);
            this.dgvSlrF.TabIndex = 12;
            this.dgvSlrF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlrF_CellClick);
            this.dgvSlrF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlrF_CellContentClick);
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
            this.SellerAge.HeaderText = "Seller Age";
            this.SellerAge.Name = "SellerAge";
            this.SellerAge.ReadOnly = true;
            // 
            // SellerPhone
            // 
            this.SellerPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellerPhone.DataPropertyName = "SellerPhone";
            this.SellerPhone.HeaderText = "Seller Phone";
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(10, 182);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Password";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel4.Location = new System.Drawing.Point(10, 153);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Phone";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel3.Location = new System.Drawing.Point(10, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Age";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel2.Location = new System.Drawing.Point(10, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel1.Location = new System.Drawing.Point(10, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Seller ID";
            // 
            // txtSellerPhone
            // 
            // 
            // 
            // 
            this.txtSellerPhone.CustomButton.Image = null;
            this.txtSellerPhone.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtSellerPhone.CustomButton.Name = "";
            this.txtSellerPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSellerPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSellerPhone.CustomButton.TabIndex = 1;
            this.txtSellerPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSellerPhone.CustomButton.UseSelectable = true;
            this.txtSellerPhone.CustomButton.Visible = false;
            this.txtSellerPhone.Lines = new string[0];
            this.txtSellerPhone.Location = new System.Drawing.Point(109, 147);
            this.txtSellerPhone.MaxLength = 32767;
            this.txtSellerPhone.Name = "txtSellerPhone";
            this.txtSellerPhone.PasswordChar = '\0';
            this.txtSellerPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSellerPhone.SelectedText = "";
            this.txtSellerPhone.SelectionLength = 0;
            this.txtSellerPhone.SelectionStart = 0;
            this.txtSellerPhone.ShortcutsEnabled = true;
            this.txtSellerPhone.Size = new System.Drawing.Size(186, 23);
            this.txtSellerPhone.TabIndex = 5;
            this.txtSellerPhone.UseSelectable = true;
            this.txtSellerPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSellerPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSellerAge
            // 
            // 
            // 
            // 
            this.txtSellerAge.CustomButton.Image = null;
            this.txtSellerAge.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtSellerAge.CustomButton.Name = "";
            this.txtSellerAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSellerAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSellerAge.CustomButton.TabIndex = 1;
            this.txtSellerAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSellerAge.CustomButton.UseSelectable = true;
            this.txtSellerAge.CustomButton.Visible = false;
            this.txtSellerAge.Lines = new string[0];
            this.txtSellerAge.Location = new System.Drawing.Point(109, 118);
            this.txtSellerAge.MaxLength = 32767;
            this.txtSellerAge.Name = "txtSellerAge";
            this.txtSellerAge.PasswordChar = '\0';
            this.txtSellerAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSellerAge.SelectedText = "";
            this.txtSellerAge.SelectionLength = 0;
            this.txtSellerAge.SelectionStart = 0;
            this.txtSellerAge.ShortcutsEnabled = true;
            this.txtSellerAge.Size = new System.Drawing.Size(186, 23);
            this.txtSellerAge.TabIndex = 4;
            this.txtSellerAge.UseSelectable = true;
            this.txtSellerAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSellerAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSellerName
            // 
            // 
            // 
            // 
            this.txtSellerName.CustomButton.Image = null;
            this.txtSellerName.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtSellerName.CustomButton.Name = "";
            this.txtSellerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSellerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSellerName.CustomButton.TabIndex = 1;
            this.txtSellerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSellerName.CustomButton.UseSelectable = true;
            this.txtSellerName.CustomButton.Visible = false;
            this.txtSellerName.Lines = new string[0];
            this.txtSellerName.Location = new System.Drawing.Point(109, 89);
            this.txtSellerName.MaxLength = 32767;
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.PasswordChar = '\0';
            this.txtSellerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSellerName.SelectedText = "";
            this.txtSellerName.SelectionLength = 0;
            this.txtSellerName.SelectionStart = 0;
            this.txtSellerName.ShortcutsEnabled = true;
            this.txtSellerName.Size = new System.Drawing.Size(186, 23);
            this.txtSellerName.TabIndex = 3;
            this.txtSellerName.UseSelectable = true;
            this.txtSellerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSellerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSellerId
            // 
            // 
            // 
            // 
            this.txtSellerId.CustomButton.Image = null;
            this.txtSellerId.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtSellerId.CustomButton.Name = "";
            this.txtSellerId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSellerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSellerId.CustomButton.TabIndex = 1;
            this.txtSellerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSellerId.CustomButton.UseSelectable = true;
            this.txtSellerId.CustomButton.Visible = false;
            this.txtSellerId.Lines = new string[0];
            this.txtSellerId.Location = new System.Drawing.Point(109, 60);
            this.txtSellerId.MaxLength = 32767;
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.PasswordChar = '\0';
            this.txtSellerId.PromptText = "AutoGenerate";
            this.txtSellerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSellerId.SelectedText = "";
            this.txtSellerId.SelectionLength = 0;
            this.txtSellerId.SelectionStart = 0;
            this.txtSellerId.ShortcutsEnabled = true;
            this.txtSellerId.Size = new System.Drawing.Size(186, 23);
            this.txtSellerId.TabIndex = 2;
            this.txtSellerId.UseSelectable = true;
            this.txtSellerId.WaterMark = "AutoGenerate";
            this.txtSellerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSellerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProductForm
            // 
            this.lblProductForm.AutoSize = true;
            this.lblProductForm.Location = new System.Drawing.Point(8, 23);
            this.lblProductForm.Name = "lblProductForm";
            this.lblProductForm.Size = new System.Drawing.Size(91, 19);
            this.lblProductForm.TabIndex = 3;
            this.lblProductForm.Text = "Product Form";
            this.lblProductForm.Click += new System.EventHandler(this.lblProductForm_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(105, 23);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 19);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category Form";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.Coral;
            this.btnClearOrder.FlatAppearance.BorderSize = 0;
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearOrder.Location = new System.Drawing.Point(651, 24);
            this.btnClearOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(53, 23);
            this.btnClearOrder.TabIndex = 59;
            this.btnClearOrder.Text = "Clear";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProductForm);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label1);
            this.Name = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlrF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtSellerPass;
        private MetroFramework.Controls.MetroTextBox txtAutoSearch;
        private System.Windows.Forms.Button btnSlrRef;
        private System.Windows.Forms.Button btnSlrDel;
        private System.Windows.Forms.Button btnSlrEdit;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroGrid dgvSlrF;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSellerPhone;
        private MetroFramework.Controls.MetroTextBox txtSellerAge;
        private MetroFramework.Controls.MetroTextBox txtSellerName;
        private MetroFramework.Controls.MetroTextBox txtSellerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerPass;
        private MetroFramework.Controls.MetroLabel lblProductForm;
        private MetroFramework.Controls.MetroLabel lblCategory;
        private System.Windows.Forms.Button btnClearOrder;
    }
}