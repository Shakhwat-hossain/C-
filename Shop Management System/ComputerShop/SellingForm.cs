using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ComputerShop
{
    public partial class SellingForm : MetroForm
    {
        //Auto Implemented Property:
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        internal string Sql { get; set; }
        internal string SP { get; set; } //CATEGORY COMBOBOX
        public SellingForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();//initializing the constructor-That will create connection with Database
            this.PopulateGridView();
            this.PopulateGridView1();
            
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=ARABI;Initial Catalog=pcdb;Integrated Security=True");
        private void SellingForm_Load(object sender, EventArgs e)
        {
            lblSeller.Text = Login.Sellername;
            PopulateGridView1();
        }
        private void PopulateGridView(string sql = "select * from ProductTbl")
        {
            this.Ds = this.Da.ExecuteQuery(sql);//Executing the sql query ,and then we will allocate the query in the Ds (DataSet variable)
         
            this.dgvSF.AutoGenerateColumns = true;
            this.dgvSF.DataSource = Ds.Tables[0];
        }
        private void PopulateGridView1(string sql = "select * from BillTbl")
        {
            this.Ds = this.Da.ExecuteQuery(sql);//Executing the sql query ,and then we will allocate the query in the Ds (DataSet variable)

            this.dgvSFSellsList.AutoGenerateColumns = true;
            this.dgvSFSellsList.DataSource = Ds.Tables[0];
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from ProductTbl where ProName like '" + txtAutoSearch.Text + "%'";
            this.PopulateGridView(Sql);
        }

        private void txtAutoSearch_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Text = "";
        }

        private void btnProRef_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            txtProName.Text = ""; txtProPrice.Text = ""; txtProQty.Text = "";
            this.txtAutoSearch.Text = " ";
        }

       /* private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtProName.Text == "" || txtProPrice.Text == "" || txtProQty.Text == "")
                {
                    MessageBox.Show("You must fill textbox");
                }
                else
                {
                    try
                    {
                        //this.txtId.ReadOnly = true;
                        this.Sql = @"insert into ProductTbl values('" + txtId.Text + "','" + txtProName.Text + "','" + txtProQty.Text + "','" + txtProPrice.Text + "','" + SP + "');";
                        int count = Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                            MessageBox.Show("Successfully Product added to database");

                        else
                            MessageBox.Show("Insert unsuccessful");
                        this.PopulateGridView();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }*/

        private void dgvPF_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = this.dgvSF.CurrentRow.Cells["id"].Value.ToString();
            // txtProName.Text = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProName.Text = this.dgvSF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProQty.Text = this.dgvSF.CurrentRow.Cells["ProQty"].Value.ToString();
            txtProPrice.Text = this.dgvSF.CurrentRow.Cells["ProPrice"].Value.ToString();
            cmbPF.Text = this.dgvSF.CurrentRow.Cells["ProCat"].Value.ToString();
        }

        private void dgvPF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txtId.Text = this.dgvSF.CurrentRow.Cells["id"].Value.ToString();
            // txtProName.Text = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProName.Text = this.dgvSF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProQty.Text = this.dgvSF.CurrentRow.Cells["ProQty"].Value.ToString();
           txtProPrice.Text = this.dgvSF.CurrentRow.Cells["ProPrice"].Value.ToString();
            cmbPF.Text = this.dgvSF.CurrentRow.Cells["ProCat"].Value.ToString();
        }
        int n = 0, Grdtotal = 0;
        DataTable Table = new DataTable();
        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            try {
                int rowIndex = dgvSFOrder.CurrentCell.RowIndex;
                dgvSFOrder.Rows.RemoveAt(rowIndex);


                dgvSFOrder.Refresh();
            }
            catch(Exception exc)
            {
                exc= null;
            }
           

        }

        private void dgvSFOrder_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            dgvSFOrder.ClearSelection();
        }

        

        private void dgvSFSellsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          txtId.Text = this.dgvSFSellsList.CurrentRow.Cells["BillId"].Value.ToString();
            // txtProName.Text = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
            lblSeller.Text = this.dgvSFSellsList.CurrentRow.Cells["SellerName"].Value.ToString();
            lblDate.Text = this.dgvSFSellsList.CurrentRow.Cells["BillDate"].Value.ToString();
            txtAmount.Text = this.dgvSFSellsList.CurrentRow.Cells["TotalAmount"].Value.ToString();
            //cmbPF.Text = this.dgvSF.CurrentRow.Cells["ProCat"].Value.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            if (txtProName.Text == "" || txtProQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(txtProPrice.Text) * Convert.ToInt32(txtProQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvSFOrder);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtProName.Text;
                newRow.Cells[2].Value = txtProQty.Text;
                newRow.Cells[3].Value = txtProPrice.Text;
                newRow.Cells[4].Value = Convert.ToInt32(txtProPrice.Text) * Convert.ToInt32(txtProQty.Text);
                //newRow.Cells[4].Value = SP;


                //newRow.Cells[4].Value = SP;
                dgvSFOrder.Rows.Add(newRow);
                Grdtotal = Grdtotal + total;
               txtAmount.Text = "" + Grdtotal;

            }
        }

        private void dgvSF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = this.dgvSF.CurrentRow.Cells["id"].Value.ToString();
            // txtProName.Text = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProName.Text = this.dgvSF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProQty.Text = this.dgvSF.CurrentRow.Cells["ProQty"].Value.ToString();
            txtProPrice.Text = this.dgvSF.CurrentRow.Cells["ProPrice"].Value.ToString();
            cmbPF.Text = this.dgvSF.CurrentRow.Cells["ProCat"].Value.ToString();
        }

        private void dgvSF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = this.dgvSF.CurrentRow.Cells["id"].Value.ToString();
            // txtProName.Text = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProName.Text = this.dgvSF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProQty.Text = this.dgvSF.CurrentRow.Cells["ProQty"].Value.ToString();
            txtProPrice.Text = this.dgvSF.CurrentRow.Cells["ProPrice"].Value.ToString();
            cmbPF.Text = this.dgvSF.CurrentRow.Cells["ProCat"].Value.ToString();
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.lblSeller.Text) || String.IsNullOrEmpty(this.lblDate.Text) ||
                String.IsNullOrEmpty(this.txtAmount.Text))
            {
                return false;

            }
            else
            {
                return true;

            }
        }

        private void btnSLDel_Click(object sender, EventArgs e)
        {

            try
            {
                string Id = this.dgvSFSellsList.CurrentRow.Cells["BillId"].Value.ToString();
                string name = this.dgvSFSellsList.CurrentRow.Cells["SellerName"].Value.ToString();


                this.Sql = @"delete from BillTbl where BillId='" + Id + "';";
                //  MessageBox.Show("Delete " + name);
                if (this.dgvSFSellsList.SelectedRows.Count > 0)

                {
                    MessageBox.Show("Delete " + Id);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //MessageBox.Show("Delete " + name);
                    if (result == DialogResult.Yes)
                    {
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show(Id + " has been deleted");
                        else
                            MessageBox.Show("Error Data deletion failed");
                        this.PopulateGridView1();

                    }
                    else if (result == DialogResult.No)
                    {

                    }
                }

                else
                {

                    MessageBox.Show("Please select a row first to delete");
                }
             
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("STARC COMPUTERS & ENGINEERS", new Font("Elephant", 20, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID:" + dgvSFOrder.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 70));
            e.Graphics.DrawString("Product Name:" + dgvSFOrder.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 100));
            e.Graphics.DrawString("Quantity:" + dgvSFOrder.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 130));
            e.Graphics.DrawString("Price:" + dgvSFOrder.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 160));
            e.Graphics.DrawString("Thanks for purchasing", new Font("Elephant", 16, FontStyle.Italic), Brushes.Red, new Point(230, 230));
        }

        private void btnPrint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
                {
                    printDocument2.Print();
                }
            }
            catch(Exception exc)
            {

            }
            
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("STARC COMPUTERS & ENGINEERS", new Font("Elephant", 20, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Product ID:" + dgvSFSellsList.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 70));
            e.Graphics.DrawString("Product Name:" + dgvSFSellsList.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 100));
            e.Graphics.DrawString("Product Quantity:" + dgvSFSellsList.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 130));
            e.Graphics.DrawString("Product Price :" + dgvSFSellsList.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 160));
            e.Graphics.DrawString("Procuct Category:" + dgvSFSellsList.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100,190));
            e.Graphics.DrawString("Thanks for purchasing", new Font("Elephant", 16, FontStyle.Italic), Brushes.Red, new Point(230, 230));
        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void dgvSFOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             
        }

        private void btnAddSellsList_Click(object sender, EventArgs e)
        {
            try
            {
                //this.txtId.ReadOnly = true;
                this.Sql = @"insert into BillTbl values('" + lblSeller.Text + "', '" + lblDate.Text + "'," + txtAmount.Text + " );";
                int count = Da.ExecuteUpdateQuery(this.Sql);
                ///if (count == 1)
                // MessageBox.Show("Successfully added to database");

                // else
                // MessageBox.Show("Insert unsuccessful");
                PopulateGridView1();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtProName.Text == "")
                {
                    MessageBox.Show("You must fill textbox");
                }
                else
                {
                    try
                    {
                        //this.txtId.ReadOnly = true;
                        this.Sql = @"insert into ProductTbl values('" + txtProName.Text + "'," + txtProQty.Text + "," + txtProPrice.Text + ",'" + cmbPF.Text + "');";
                        int count = Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                            MessageBox.Show("Successfully added to database");

                        else
                            MessageBox.Show("Insert unsuccessful");
                        this.PopulateGridView();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void dgvSFSellsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = this.dgvSF.CurrentRow.Cells["BillId"].Value.ToString();
            // txtProName.Text = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
            lblSeller.Text = this.dgvSF.CurrentRow.Cells["SellerName"].Value.ToString();
            lblDate.Text = this.dgvSF.CurrentRow.Cells["BillDate"].Value.ToString();
            txtAmount.Text = this.dgvSF.CurrentRow.Cells["TotalAmount"].Value.ToString();
        }

       /* private void btnAddSellsList_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSave())
                {

                   // this.Sql = "select * from BillTbl";// where BillId  = '" + this.BillId.DataGridView + "';";
                    DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                    if (dt.Rows.Count == 1)
                    {
                        //update operation 
                        this.Sql = @"insert into BillTbl (BillId,SellerName,BillDate,TotalAmount) values("+this.txtId.Text+",'" + this.lblSeller.Text + "', '" + this.lblDate.Text + "'," + this.txtAmount.Text + ");";

                        int row = this.Da.ExecuteUpdateQuery(this.Sql);
                        this.PopulateGridView1();
                        if (row == 1)
                            MessageBox.Show("Data updated successfully in database");
                        else
                            MessageBox.Show("Error! data updated failed");


                    }
                    else if (dt.Rows.Count == 0)
                    {
                        //insert operation 
                        this.Sql = @"insert into BillTbl (BillId,SellerName,BillDate,TotalAmount) values(" + this.txtId.Text + ",'" + this.lblSeller.Text + "', '" + this.lblDate.Text + "'," + this.txtAmount.Text + ");";
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show("Data inserted successfully in database");
                        else
                            MessageBox.Show("Data insertion failed");
                        this.PopulateGridView1();

                    }
                    this.PopulateGridView1();
                    //this.ClearContent();



                }
                else
                {
                    MessageBox.Show("Please fill all the information");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }*/

    }
}
//"insert into ProductTbl values('" + txtId.Text + "','" + txtProName.Text + "','" + txtProQty.Text + "','" + txtProPrice.Text + "','" + SP + "');";
// "insert into BillTbl values(" + txtId.Text + ",'" + lblSeller.Text + "','" + lblDate.Text + "','" + txtAmount.Text + "')";