
namespace ComputerShop
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintMenu = new System.Windows.Forms.Button();
            this.btnAddSellsList = new System.Windows.Forms.Button();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbPF = new MetroFramework.Controls.MetroComboBox();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.lblMRP = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvSFSellsList = new MetroFramework.Controls.MetroGrid();
            this.BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSFOrder = new MetroFramework.Controls.MetroGrid();
            this.ProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCattegory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnProRef = new System.Windows.Forms.Button();
            this.btnSLDel = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvSF = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtProPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtProQty = new MetroFramework.Controls.MetroTextBox();
            this.txtProName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblSeller = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblLogout = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.button1 = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSFSellsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSFOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(353, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELLING PRODUCTS";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.btnPrintMenu);
            this.metroPanel1.Controls.Add(this.btnAddSellsList);
            this.metroPanel1.Controls.Add(this.txtAmount);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.cmbPF);
            this.metroPanel1.Controls.Add(this.btnClearOrder);
            this.metroPanel1.Controls.Add(this.lblMRP);
            this.metroPanel1.Controls.Add(this.btnPrint);
            this.metroPanel1.Controls.Add(this.dgvSFSellsList);
            this.metroPanel1.Controls.Add(this.dgvSFOrder);
            this.metroPanel1.Controls.Add(this.txtAutoSearch);
            this.metroPanel1.Controls.Add(this.btnProRef);
            this.metroPanel1.Controls.Add(this.btnSLDel);
            this.metroPanel1.Controls.Add(this.btnAddProduct);
            this.metroPanel1.Controls.Add(this.dgvSF);
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
            this.metroPanel1.Location = new System.Drawing.Point(56, 55);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(917, 545);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(584, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Sold Details";
            // 
            // btnPrintMenu
            // 
            this.btnPrintMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPrintMenu.FlatAppearance.BorderSize = 0;
            this.btnPrintMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintMenu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrintMenu.Location = new System.Drawing.Point(810, 217);
            this.btnPrintMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintMenu.Name = "btnPrintMenu";
            this.btnPrintMenu.Size = new System.Drawing.Size(53, 23);
            this.btnPrintMenu.TabIndex = 58;
            this.btnPrintMenu.Text = "Print";
            this.btnPrintMenu.UseVisualStyleBackColor = false;
            this.btnPrintMenu.Click += new System.EventHandler(this.btnPrintMenu_Click);
            // 
            // btnAddSellsList
            // 
            this.btnAddSellsList.BackColor = System.Drawing.Color.Coral;
            this.btnAddSellsList.FlatAppearance.BorderSize = 0;
            this.btnAddSellsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSellsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSellsList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddSellsList.Location = new System.Drawing.Point(522, 504);
            this.btnAddSellsList.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSellsList.Name = "btnAddSellsList";
            this.btnAddSellsList.Size = new System.Drawing.Size(53, 24);
            this.btnAddSellsList.TabIndex = 60;
            this.btnAddSellsList.Text = "Add ";
            this.btnAddSellsList.UseVisualStyleBackColor = false;
            this.btnAddSellsList.Click += new System.EventHandler(this.btnAddSellsList_Click);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(600, 217);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PromptText = "TK";
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(90, 23);
            this.txtAmount.TabIndex = 59;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMark = "TK";
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 132);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Category";
            // 
            // cmbPF
            // 
            this.cmbPF.FormattingEnabled = true;
            this.cmbPF.ItemHeight = 23;
            this.cmbPF.Items.AddRange(new object[] {
            "Laptop",
            "PC"});
            this.cmbPF.Location = new System.Drawing.Point(120, 132);
            this.cmbPF.Name = "cmbPF";
            this.cmbPF.Size = new System.Drawing.Size(122, 29);
            this.cmbPF.TabIndex = 50;
            this.cmbPF.UseSelectable = true;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClearOrder.FlatAppearance.BorderSize = 0;
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearOrder.Location = new System.Drawing.Point(729, 217);
            this.btnClearOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(53, 23);
            this.btnClearOrder.TabIndex = 58;
            this.btnClearOrder.Text = "Clear";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Location = new System.Drawing.Point(455, 217);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(139, 19);
            this.lblMRP.TabIndex = 56;
            this.lblMRP.Text = "TOTAL AMOUNT MRP";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Coral;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Location = new System.Drawing.Point(627, 504);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(53, 24);
            this.btnPrint.TabIndex = 55;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPrint_Paint);
            // 
            // dgvSFSellsList
            // 
            this.dgvSFSellsList.AllowUserToAddRows = false;
            this.dgvSFSellsList.AllowUserToDeleteRows = false;
            this.dgvSFSellsList.AllowUserToResizeRows = false;
            this.dgvSFSellsList.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvSFSellsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSFSellsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSFSellsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSFSellsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSFSellsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSFSellsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillId,
            this.SellerName,
            this.BillDate,
            this.TotalAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSFSellsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSFSellsList.EnableHeadersVisualStyles = false;
            this.dgvSFSellsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSFSellsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSFSellsList.Location = new System.Drawing.Point(436, 283);
            this.dgvSFSellsList.Name = "dgvSFSellsList";
            this.dgvSFSellsList.ReadOnly = true;
            this.dgvSFSellsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSFSellsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSFSellsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSFSellsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSFSellsList.Size = new System.Drawing.Size(453, 215);
            this.dgvSFSellsList.TabIndex = 53;
            this.dgvSFSellsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSFSellsList_CellClick);
            this.dgvSFSellsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSFSellsList_CellContentClick);
            // 
            // BillId
            // 
            this.BillId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillId.DataPropertyName = "BillId";
            this.BillId.HeaderText = "Bill ID";
            this.BillId.Name = "BillId";
            this.BillId.ReadOnly = true;
            // 
            // SellerName
            // 
            this.SellerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellerName.DataPropertyName = "SellerName";
            this.SellerName.HeaderText = "Seller Name";
            this.SellerName.Name = "SellerName";
            this.SellerName.ReadOnly = true;
            // 
            // BillDate
            // 
            this.BillDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.HeaderText = "Date";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // dgvSFOrder
            // 
            this.dgvSFOrder.AllowUserToAddRows = false;
            this.dgvSFOrder.AllowUserToDeleteRows = false;
            this.dgvSFOrder.AllowUserToResizeRows = false;
            this.dgvSFOrder.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvSFOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSFOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSFOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSFOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSFOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSFOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProId,
            this.ProductName,
            this.ProductQty,
            this.ProductPrice,
            this.ProCattegory});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSFOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSFOrder.EnableHeadersVisualStyles = false;
            this.dgvSFOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSFOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSFOrder.Location = new System.Drawing.Point(436, 14);
            this.dgvSFOrder.Name = "dgvSFOrder";
            this.dgvSFOrder.ReadOnly = true;
            this.dgvSFOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSFOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSFOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSFOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSFOrder.Size = new System.Drawing.Size(453, 198);
            this.dgvSFOrder.TabIndex = 52;
            this.dgvSFOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSFOrder_CellContentClick);
            this.dgvSFOrder.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvSFOrder_ColumnRemoved);
            // 
            // ProId
            // 
            this.ProId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProId.DataPropertyName = "Id";
            this.ProId.HeaderText = "Product No";
            this.ProId.Name = "ProId";
            this.ProId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductQty
            // 
            this.ProductQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductQty.DataPropertyName = "ProQty";
            this.ProductQty.HeaderText = "Product Quantity";
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPrice.DataPropertyName = "ProPrice";
            this.ProductPrice.HeaderText = "Product Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProCattegory
            // 
            this.ProCattegory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProCattegory.DataPropertyName = "ProCat";
            this.ProCattegory.HeaderText = "Total";
            this.ProCattegory.Name = "ProCattegory";
            this.ProCattegory.ReadOnly = true;
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
            this.txtAutoSearch.Location = new System.Drawing.Point(33, 188);
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
            // btnProRef
            // 
            this.btnProRef.BackColor = System.Drawing.Color.SkyBlue;
            this.btnProRef.FlatAppearance.BorderSize = 0;
            this.btnProRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProRef.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProRef.Location = new System.Drawing.Point(253, 187);
            this.btnProRef.Margin = new System.Windows.Forms.Padding(2);
            this.btnProRef.Name = "btnProRef";
            this.btnProRef.Size = new System.Drawing.Size(53, 24);
            this.btnProRef.TabIndex = 49;
            this.btnProRef.Text = "Refresh";
            this.btnProRef.UseVisualStyleBackColor = false;
            this.btnProRef.Click += new System.EventHandler(this.btnProRef_Click);
            // 
            // btnSLDel
            // 
            this.btnSLDel.BackColor = System.Drawing.Color.Coral;
            this.btnSLDel.FlatAppearance.BorderSize = 0;
            this.btnSLDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSLDel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSLDel.Location = new System.Drawing.Point(729, 504);
            this.btnSLDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnSLDel.Name = "btnSLDel";
            this.btnSLDel.Size = new System.Drawing.Size(53, 24);
            this.btnSLDel.TabIndex = 48;
            this.btnSLDel.Text = "Delete";
            this.btnSLDel.UseVisualStyleBackColor = false;
            this.btnSLDel.Click += new System.EventHandler(this.btnSLDel_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Coral;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddProduct.Location = new System.Drawing.Point(271, 137);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(80, 24);
            this.btnAddProduct.TabIndex = 46;
            this.btnAddProduct.Text = "Sell Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvSF
            // 
            this.dgvSF.AllowUserToAddRows = false;
            this.dgvSF.AllowUserToDeleteRows = false;
            this.dgvSF.AllowUserToResizeRows = false;
            this.dgvSF.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvSF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProName,
            this.ProQty,
            this.ProPrice,
            this.ProCat});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSF.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSF.EnableHeadersVisualStyles = false;
            this.dgvSF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSF.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSF.Location = new System.Drawing.Point(3, 217);
            this.dgvSF.Name = "dgvSF";
            this.dgvSF.ReadOnly = true;
            this.dgvSF.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSF.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSF.Size = new System.Drawing.Size(397, 281);
            this.dgvSF.TabIndex = 12;
            this.dgvSF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSF_CellClick);
            this.dgvSF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSF_CellContentClick);
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel4.Location = new System.Drawing.Point(21, 109);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Price";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel3.Location = new System.Drawing.Point(21, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Quantity";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel2.Location = new System.Drawing.Point(21, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Product Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroLabel1.Location = new System.Drawing.Point(21, 22);
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
            this.txtProPrice.Location = new System.Drawing.Point(120, 103);
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
            this.txtProQty.Location = new System.Drawing.Point(120, 74);
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
            this.txtProName.Location = new System.Drawing.Point(120, 45);
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
            this.txtId.Location = new System.Drawing.Point(120, 16);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PromptText = "AutoGenerate";
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(186, 23);
            this.txtId.TabIndex = 2;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMark = "AutoGenerate";
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblSeller.Location = new System.Drawing.Point(0, 534);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(41, 19);
            this.lblSeller.TabIndex = 52;
            this.lblSeller.Text = "Seller";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(892, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 19);
            this.lblDate.TabIndex = 51;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            this.printPreviewDialog2.Load += new System.EventHandler(this.printPreviewDialog2_Load);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(0, 564);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(50, 19);
            this.lblLogout.TabIndex = 53;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CalendarTitleBackColor = System.Drawing.Color.SkyBlue;
            this.metroDateTime1.Location = new System.Drawing.Point(9, 15);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(10, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 24);
            this.button1.TabIndex = 61;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 600);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label1);
            this.Name = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSFSellsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSFOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtAutoSearch;
        private MetroFramework.Controls.MetroComboBox cmbPF;
        private System.Windows.Forms.Button btnProRef;
        private System.Windows.Forms.Button btnSLDel;
        private System.Windows.Forms.Button btnAddProduct;
        private MetroFramework.Controls.MetroGrid dgvSF;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtProPrice;
        private MetroFramework.Controls.MetroTextBox txtProQty;
        private MetroFramework.Controls.MetroTextBox txtProName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCat;
        private System.Windows.Forms.Button btnPrint;
        private MetroFramework.Controls.MetroGrid dgvSFSellsList;
        private MetroFramework.Controls.MetroGrid dgvSFOrder;
        private MetroFramework.Controls.MetroLabel lblMRP;
        private System.Windows.Forms.Button btnClearOrder;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private System.Windows.Forms.Button btnAddSellsList;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblSeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintMenu;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private MetroFramework.Controls.MetroLabel lblLogout;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProId;
        private new System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCattegory;
        private System.Windows.Forms.Button button1;
    }
}