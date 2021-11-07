
namespace ComputerShop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.cmbPF = new MetroFramework.Controls.MetroComboBox();
            this.btnProRef = new System.Windows.Forms.Button();
            this.btnProDel = new System.Windows.Forms.Button();
            this.btnProEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPF = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtProPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtProQty = new MetroFramework.Controls.MetroTextBox();
            this.txtProName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblSeller = new MetroFramework.Controls.MetroLabel();
            this.lblSelling = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(286, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCT";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroPanel1.Controls.Add(this.txtAutoSearch);
            this.metroPanel1.Controls.Add(this.cmbPF);
            this.metroPanel1.Controls.Add(this.btnProRef);
            this.metroPanel1.Controls.Add(this.btnProDel);
            this.metroPanel1.Controls.Add(this.btnProEdit);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.dgvPF);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtProPrice);
            this.metroPanel1.Controls.Add(this.txtProQty);
            this.metroPanel1.Controls.Add(this.txtProName);
            this.metroPanel1.Controls.Add(this.txtId);
            this.metroPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(68, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(733, 435);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
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
            this.txtAutoSearch.Location = new System.Drawing.Point(353, 15);
            this.txtAutoSearch.MaxLength = 32767;
            this.txtAutoSearch.Multiline = true;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.PasswordChar = '\0';
            this.txtAutoSearch.PromptText = "🔍 Search Product Name";
            this.txtAutoSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutoSearch.SelectedText = "";
            this.txtAutoSearch.SelectionLength = 0;
            this.txtAutoSearch.SelectionStart = 0;
            this.txtAutoSearch.ShortcutsEnabled = true;
            this.txtAutoSearch.Size = new System.Drawing.Size(186, 23);
            this.txtAutoSearch.TabIndex = 51;
            this.txtAutoSearch.UseSelectable = true;
            this.txtAutoSearch.WaterMark = "🔍 Search Product Name";
            this.txtAutoSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAutoSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            this.txtAutoSearch.Click += new System.EventHandler(this.txtAutoSearch_Click);
            // 
            // cmbPF
            // 
            this.cmbPF.FormattingEnabled = true;
            this.cmbPF.ItemHeight = 23;
            this.cmbPF.Items.AddRange(new object[] {
            "Laptop",
            "PC"});
            this.cmbPF.Location = new System.Drawing.Point(104, 174);
            this.cmbPF.Name = "cmbPF";
            this.cmbPF.Size = new System.Drawing.Size(122, 29);
            this.cmbPF.TabIndex = 50;
            this.cmbPF.UseSelectable = true;
            this.cmbPF.SelectedIndexChanged += new System.EventHandler(this.cmbPF_SelectedIndexChanged);
            // 
            // btnProRef
            // 
            this.btnProRef.BackColor = System.Drawing.Color.Coral;
            this.btnProRef.FlatAppearance.BorderSize = 0;
            this.btnProRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProRef.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProRef.Location = new System.Drawing.Point(584, 15);
            this.btnProRef.Margin = new System.Windows.Forms.Padding(2);
            this.btnProRef.Name = "btnProRef";
            this.btnProRef.Size = new System.Drawing.Size(53, 24);
            this.btnProRef.TabIndex = 49;
            this.btnProRef.Text = "Refresh";
            this.btnProRef.UseVisualStyleBackColor = false;
            this.btnProRef.Click += new System.EventHandler(this.btnProRef_Click);
            // 
            // btnProDel
            // 
            this.btnProDel.BackColor = System.Drawing.Color.Coral;
            this.btnProDel.FlatAppearance.BorderSize = 0;
            this.btnProDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProDel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProDel.Location = new System.Drawing.Point(192, 222);
            this.btnProDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnProDel.Name = "btnProDel";
            this.btnProDel.Size = new System.Drawing.Size(53, 24);
            this.btnProDel.TabIndex = 48;
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
            this.btnProEdit.Location = new System.Drawing.Point(115, 222);
            this.btnProEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnProEdit.Name = "btnProEdit";
            this.btnProEdit.Size = new System.Drawing.Size(53, 24);
            this.btnProEdit.TabIndex = 47;
            this.btnProEdit.Text = "Edit";
            this.btnProEdit.UseVisualStyleBackColor = false;
            this.btnProEdit.Click += new System.EventHandler(this.btnProEdit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(34, 222);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 24);
            this.button1.TabIndex = 46;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPF
            // 
            this.dgvPF.AllowUserToAddRows = false;
            this.dgvPF.AllowUserToDeleteRows = false;
            this.dgvPF.AllowUserToResizeRows = false;
            this.dgvPF.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProName,
            this.ProQty,
            this.ProPrice,
            this.ProCat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPF.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPF.EnableHeadersVisualStyles = false;
            this.dgvPF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPF.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPF.Location = new System.Drawing.Point(296, 52);
            this.dgvPF.Name = "dgvPF";
            this.dgvPF.ReadOnly = true;
            this.dgvPF.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPF.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPF.Size = new System.Drawing.Size(417, 362);
            this.dgvPF.TabIndex = 12;
            this.dgvPF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPF_CellContentClick);
            this.dgvPF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPF_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Product ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ProName
            // 
            this.ProName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProName.DataPropertyName = "ProName";
            this.ProName.HeaderText = "Product Name";
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(5, 174);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Category";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel4.Location = new System.Drawing.Point(5, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Price";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel3.Location = new System.Drawing.Point(5, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Quantity";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel2.Location = new System.Drawing.Point(5, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Product Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel1.Location = new System.Drawing.Point(5, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Bill ID";
            // 
            // txtProPrice
            // 
            // 
            // 
            // 
            this.txtProPrice.CustomButton.Image = null;
            this.txtProPrice.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtProPrice.CustomButton.Name = "";
            this.txtProPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProPrice.CustomButton.TabIndex = 1;
            this.txtProPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProPrice.CustomButton.UseSelectable = true;
            this.txtProPrice.CustomButton.Visible = false;
            this.txtProPrice.Lines = new string[0];
            this.txtProPrice.Location = new System.Drawing.Point(104, 139);
            this.txtProPrice.MaxLength = 32767;
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.PasswordChar = '\0';
            this.txtProPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProPrice.SelectedText = "";
            this.txtProPrice.SelectionLength = 0;
            this.txtProPrice.SelectionStart = 0;
            this.txtProPrice.ShortcutsEnabled = true;
            this.txtProPrice.Size = new System.Drawing.Size(186, 23);
            this.txtProPrice.TabIndex = 5;
            this.txtProPrice.UseSelectable = true;
            this.txtProPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProQty
            // 
            // 
            // 
            // 
            this.txtProQty.CustomButton.Image = null;
            this.txtProQty.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtProQty.CustomButton.Name = "";
            this.txtProQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProQty.CustomButton.TabIndex = 1;
            this.txtProQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProQty.CustomButton.UseSelectable = true;
            this.txtProQty.CustomButton.Visible = false;
            this.txtProQty.Lines = new string[0];
            this.txtProQty.Location = new System.Drawing.Point(104, 110);
            this.txtProQty.MaxLength = 32767;
            this.txtProQty.Name = "txtProQty";
            this.txtProQty.PasswordChar = '\0';
            this.txtProQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProQty.SelectedText = "";
            this.txtProQty.SelectionLength = 0;
            this.txtProQty.SelectionStart = 0;
            this.txtProQty.ShortcutsEnabled = true;
            this.txtProQty.Size = new System.Drawing.Size(186, 23);
            this.txtProQty.TabIndex = 4;
            this.txtProQty.UseSelectable = true;
            this.txtProQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProName
            // 
            // 
            // 
            // 
            this.txtProName.CustomButton.Image = null;
            this.txtProName.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtProName.CustomButton.Name = "";
            this.txtProName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProName.CustomButton.TabIndex = 1;
            this.txtProName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProName.CustomButton.UseSelectable = true;
            this.txtProName.CustomButton.Visible = false;
            this.txtProName.Lines = new string[0];
            this.txtProName.Location = new System.Drawing.Point(104, 81);
            this.txtProName.MaxLength = 32767;
            this.txtProName.Name = "txtProName";
            this.txtProName.PasswordChar = '\0';
            this.txtProName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProName.SelectedText = "";
            this.txtProName.SelectionLength = 0;
            this.txtProName.SelectionStart = 0;
            this.txtProName.ShortcutsEnabled = true;
            this.txtProName.Size = new System.Drawing.Size(186, 23);
            this.txtProName.TabIndex = 3;
            this.txtProName.UseSelectable = true;
            this.txtProName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(104, 52);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PromptText = "AutoGenerate[NO INPUT REQUIRED]";
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(186, 23);
            this.txtId.TabIndex = 2;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMark = "AutoGenerate[NO INPUT REQUIRED]";
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(62, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 19);
            this.metroLabel6.TabIndex = 52;
            this.metroLabel6.Text = "Category";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(12, 16);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(41, 19);
            this.lblSeller.TabIndex = 53;
            this.lblSeller.Text = "Seller";
            this.lblSeller.Click += new System.EventHandler(this.lblSeller_Click);
            // 
            // lblSelling
            // 
            this.lblSelling.AutoSize = true;
            this.lblSelling.Location = new System.Drawing.Point(132, 16);
            this.lblSelling.Name = "lblSelling";
            this.lblSelling.Size = new System.Drawing.Size(47, 19);
            this.lblSelling.TabIndex = 54;
            this.lblSelling.Text = "Selling";
            this.lblSelling.Click += new System.EventHandler(this.lblSelling_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblSelling);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProductForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtProPrice;
        private MetroFramework.Controls.MetroTextBox txtProQty;
        private MetroFramework.Controls.MetroTextBox txtProName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroGrid dgvPF;
        private System.Windows.Forms.Button btnProRef;
        private System.Windows.Forms.Button btnProDel;
        private System.Windows.Forms.Button btnProEdit;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroComboBox cmbPF;
        private MetroFramework.Controls.MetroTextBox txtAutoSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCat;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblSeller;
        private MetroFramework.Controls.MetroLabel lblSelling;
    }
}