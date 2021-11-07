
namespace PythonComputersShop
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSeller = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAMOUNT = new System.Windows.Forms.Label();
            this.dgvORDER = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddSF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProdQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvSellingForm = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnADDPF = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbCATPROD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnREFRESH = new System.Windows.Forms.Button();
            this.dgvPF = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExit.Location = new System.Drawing.Point(786, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 24);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lblSeller);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblAMOUNT);
            this.panel1.Controls.Add(this.dgvORDER);
            this.panel1.Controls.Add(this.AddSF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.dgvSellingForm);
            this.panel1.Controls.Add(this.btnADDPF);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.cmbCATPROD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.btnREFRESH);
            this.panel1.Controls.Add(this.dgvPF);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProdId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(136, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 582);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.BackColor = System.Drawing.Color.Green;
            this.lblSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeller.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeller.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSeller.Location = new System.Drawing.Point(3, 3);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(61, 21);
            this.lblSeller.TabIndex = 45;
            this.lblSeller.Text = "Seller";
            this.lblSeller.Click += new System.EventHandler(this.lblSeller_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(498, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 27);
            this.label10.TabIndex = 43;
            this.label10.Text = "SELLS LIST";
            // 
            // lblAMOUNT
            // 
            this.lblAMOUNT.AutoSize = true;
            this.lblAMOUNT.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMOUNT.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAMOUNT.Location = new System.Drawing.Point(572, 247);
            this.lblAMOUNT.Name = "lblAMOUNT";
            this.lblAMOUNT.Size = new System.Drawing.Size(51, 25);
            this.lblAMOUNT.TabIndex = 42;
            this.lblAMOUNT.Text = "Rs";
            // 
            // dgvORDER
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvORDER.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvORDER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvORDER.BackgroundColor = System.Drawing.Color.White;
            this.dgvORDER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvORDER.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvORDER.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvORDER.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvORDER.ColumnHeadersHeight = 4;
            this.dgvORDER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.PName,
            this.PQty,
            this.PPrice,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvORDER.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvORDER.EnableHeadersVisualStyles = false;
            this.dgvORDER.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvORDER.Location = new System.Drawing.Point(360, 62);
            this.dgvORDER.Name = "dgvORDER";
            this.dgvORDER.RowHeadersVisible = false;
            this.dgvORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvORDER.Size = new System.Drawing.Size(504, 179);
            this.dgvORDER.TabIndex = 41;
            this.dgvORDER.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvORDER.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvORDER.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvORDER.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvORDER.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvORDER.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvORDER.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvORDER.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvORDER.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvORDER.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvORDER.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvORDER.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvORDER.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvORDER.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvORDER.ThemeStyle.ReadOnly = false;
            this.dgvORDER.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvORDER.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvORDER.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvORDER.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvORDER.ThemeStyle.RowsStyle.Height = 22;
            this.dgvORDER.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvORDER.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvORDER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvORDER_CellContentClick);
            // 
            // PID
            // 
            this.PID.DataPropertyName = "prodid";
            this.PID.HeaderText = "ProdId";
            this.PID.Name = "PID";
            // 
            // PName
            // 
            this.PName.DataPropertyName = "prodname";
            this.PName.HeaderText = "ProdName";
            this.PName.Name = "PName";
            // 
            // PQty
            // 
            this.PQty.DataPropertyName = "prodqty";
            this.PQty.HeaderText = "ProdQty";
            this.PQty.Name = "PQty";
            // 
            // PPrice
            // 
            this.PPrice.DataPropertyName = "prodprice";
            this.PPrice.HeaderText = "ProdPrice";
            this.PPrice.Name = "PPrice";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "total";
            this.Total.Name = "Total";
            // 
            // AddSF
            // 
            this.AddSF.BackColor = System.Drawing.Color.Green;
            this.AddSF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddSF.FlatAppearance.BorderSize = 0;
            this.AddSF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.AddSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSF.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSF.ForeColor = System.Drawing.Color.Lime;
            this.AddSF.Location = new System.Drawing.Point(414, 538);
            this.AddSF.Name = "AddSF";
            this.AddSF.Size = new System.Drawing.Size(70, 29);
            this.AddSF.TabIndex = 40;
            this.AddSF.Text = "ADD";
            this.AddSF.UseVisualStyleBackColor = false;
            this.AddSF.Click += new System.EventHandler(this.AddSF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(442, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "Amount RS";
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.LimeGreen;
            this.ProdName.BorderThickness = 2;
            this.ProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdName.DefaultText = "";
            this.ProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdName.DisabledState.Parent = this.ProdName;
            this.ProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdName.FillColor = System.Drawing.Color.Green;
            this.ProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdName.FocusedState.Parent = this.ProdName;
            this.ProdName.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.ForeColor = System.Drawing.SystemColors.Control;
            this.ProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdName.HoverState.Parent = this.ProdName;
            this.ProdName.Location = new System.Drawing.Point(122, 72);
            this.ProdName.Margin = new System.Windows.Forms.Padding(4);
            this.ProdName.Name = "ProdName";
            this.ProdName.PasswordChar = '\0';
            this.ProdName.PlaceholderText = "";
            this.ProdName.SelectedText = "";
            this.ProdName.ShadowDecoration.Parent = this.ProdName;
            this.ProdName.Size = new System.Drawing.Size(228, 29);
            this.ProdName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProdName.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(3, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(4, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "PROD NAME";
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.Color.LimeGreen;
            this.ProdQty.BorderThickness = 2;
            this.ProdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQty.DefaultText = "";
            this.ProdQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQty.DisabledState.Parent = this.ProdQty;
            this.ProdQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQty.FillColor = System.Drawing.Color.Green;
            this.ProdQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdQty.FocusedState.Parent = this.ProdQty;
            this.ProdQty.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.ForeColor = System.Drawing.SystemColors.Control;
            this.ProdQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdQty.HoverState.Parent = this.ProdQty;
            this.ProdQty.Location = new System.Drawing.Point(122, 134);
            this.ProdQty.Margin = new System.Windows.Forms.Padding(4);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.PasswordChar = '\0';
            this.ProdQty.PlaceholderText = "";
            this.ProdQty.SelectedText = "";
            this.ProdQty.ShadowDecoration.Parent = this.ProdQty;
            this.ProdQty.Size = new System.Drawing.Size(228, 31);
            this.ProdQty.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProdQty.TabIndex = 4;
            // 
            // dgvSellingForm
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvSellingForm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSellingForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSellingForm.BackgroundColor = System.Drawing.Color.White;
            this.dgvSellingForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSellingForm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSellingForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellingForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSellingForm.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellingForm.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSellingForm.EnableHeadersVisualStyles = false;
            this.dgvSellingForm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSellingForm.Location = new System.Drawing.Point(18, 247);
            this.dgvSellingForm.Name = "dgvSellingForm";
            this.dgvSellingForm.RowHeadersVisible = false;
            this.dgvSellingForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSellingForm.Size = new System.Drawing.Size(305, 312);
            this.dgvSellingForm.TabIndex = 35;
            this.dgvSellingForm.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvSellingForm.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSellingForm.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSellingForm.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSellingForm.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSellingForm.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSellingForm.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSellingForm.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSellingForm.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSellingForm.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSellingForm.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSellingForm.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSellingForm.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSellingForm.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvSellingForm.ThemeStyle.ReadOnly = false;
            this.dgvSellingForm.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSellingForm.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSellingForm.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSellingForm.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSellingForm.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSellingForm.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSellingForm.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSellingForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellingForm_CellContentClick);
            // 
            // btnADDPF
            // 
            this.btnADDPF.BackColor = System.Drawing.Color.Green;
            this.btnADDPF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnADDPF.FlatAppearance.BorderSize = 0;
            this.btnADDPF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnADDPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDPF.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDPF.ForeColor = System.Drawing.Color.Lime;
            this.btnADDPF.Location = new System.Drawing.Point(112, 167);
            this.btnADDPF.Name = "btnADDPF";
            this.btnADDPF.Size = new System.Drawing.Size(148, 29);
            this.btnADDPF.TabIndex = 34;
            this.btnADDPF.Text = "Add Product";
            this.btnADDPF.UseVisualStyleBackColor = false;
            this.btnADDPF.Click += new System.EventHandler(this.btnADDPF_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Lime;
            this.button7.Location = new System.Drawing.Point(593, 538);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 29);
            this.button7.TabIndex = 33;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Green;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Lime;
            this.btnPrint.Location = new System.Drawing.Point(478, 538);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 29);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "PRICE";
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.Color.LimeGreen;
            this.ProdPrice.BorderThickness = 2;
            this.ProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdPrice.DefaultText = "";
            this.ProdPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdPrice.DisabledState.Parent = this.ProdPrice;
            this.ProdPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdPrice.FillColor = System.Drawing.Color.Green;
            this.ProdPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdPrice.FocusedState.Parent = this.ProdPrice;
            this.ProdPrice.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.ProdPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdPrice.HoverState.Parent = this.ProdPrice;
            this.ProdPrice.Location = new System.Drawing.Point(122, 99);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.PasswordChar = '\0';
            this.ProdPrice.PlaceholderText = "";
            this.ProdPrice.SelectedText = "";
            this.ProdPrice.ShadowDecoration.Parent = this.ProdPrice;
            this.ProdPrice.Size = new System.Drawing.Size(228, 35);
            this.ProdPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProdPrice.TabIndex = 28;
            // 
            // cmbCATPROD
            // 
            this.cmbCATPROD.BackColor = System.Drawing.Color.LimeGreen;
            this.cmbCATPROD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCATPROD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCATPROD.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbCATPROD.FormattingEnabled = true;
            this.cmbCATPROD.Location = new System.Drawing.Point(18, 215);
            this.cmbCATPROD.Name = "cmbCATPROD";
            this.cmbCATPROD.Size = new System.Drawing.Size(200, 26);
            this.cmbCATPROD.TabIndex = 27;
            this.cmbCATPROD.Text = "Select Category";
            this.cmbCATPROD.SelectedIndexChanged += new System.EventHandler(this.cmbCATPROD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "QUANTITY";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(806, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 18);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Date";
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.BackColor = System.Drawing.Color.Green;
            this.btnREFRESH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnREFRESH.FlatAppearance.BorderSize = 0;
            this.btnREFRESH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnREFRESH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREFRESH.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREFRESH.ForeColor = System.Drawing.Color.Lime;
            this.btnREFRESH.Location = new System.Drawing.Point(224, 212);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(109, 29);
            this.btnREFRESH.TabIndex = 21;
            this.btnREFRESH.Text = "REFRESH";
            this.btnREFRESH.UseVisualStyleBackColor = false;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // dgvPF
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvPF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPF.BackgroundColor = System.Drawing.Color.White;
            this.dgvPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPF.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPF.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPF.EnableHeadersVisualStyles = false;
            this.dgvPF.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPF.Location = new System.Drawing.Point(348, 320);
            this.dgvPF.Name = "dgvPF";
            this.dgvPF.RowHeadersVisible = false;
            this.dgvPF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPF.Size = new System.Drawing.Size(504, 179);
            this.dgvPF.TabIndex = 16;
            this.dgvPF.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPF.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPF.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPF.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPF.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPF.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPF.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPF.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPF.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPF.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPF.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPF.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPF.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPF.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPF.ThemeStyle.ReadOnly = false;
            this.dgvPF.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPF.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPF.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPF.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPF.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPF.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPF.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPF_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "BILL ID";
            // 
            // ProdId
            // 
            this.ProdId.BackColor = System.Drawing.Color.LimeGreen;
            this.ProdId.BorderThickness = 2;
            this.ProdId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdId.DefaultText = "";
            this.ProdId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdId.DisabledState.Parent = this.ProdId;
            this.ProdId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdId.FillColor = System.Drawing.Color.Green;
            this.ProdId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdId.FocusedState.Parent = this.ProdId;
            this.ProdId.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdId.ForeColor = System.Drawing.SystemColors.Control;
            this.ProdId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdId.HoverState.Parent = this.ProdId;
            this.ProdId.Location = new System.Drawing.Point(122, 43);
            this.ProdId.Margin = new System.Windows.Forms.Padding(4);
            this.ProdId.Name = "ProdId";
            this.ProdId.PasswordChar = '\0';
            this.ProdId.PlaceholderText = "";
            this.ProdId.SelectedText = "";
            this.ProdId.ShadowDecoration.Parent = this.ProdId;
            this.ProdId.Size = new System.Drawing.Size(228, 28);
            this.ProdId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProdId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(376, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLING";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.SystemColors.Control;
            this.lblLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogout.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLogout.Location = new System.Drawing.Point(29, 553);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(64, 18);
            this.lblLogout.TabIndex = 44;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
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
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox ProdQty;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSellingForm;
        private System.Windows.Forms.Button btnADDPF;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnPrint;
        private Guna.UI2.WinForms.Guna2TextBox ProdPrice;
        private System.Windows.Forms.ComboBox cmbCATPROD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnREFRESH;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPF;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox ProdId;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox ProdName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAMOUNT;
        private Guna.UI2.WinForms.Guna2DataGridView dgvORDER;
        private System.Windows.Forms.Button AddSF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblSeller;
    }
}