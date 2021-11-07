using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EcShop
{
    public partial class SellingForm : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        internal string Sql2 { get; set; }

        SqlConnection sc = new SqlConnection(@"Data Source=(LOCAL);Initial Catalog=eShop;Persist Security Info=True;User ID=sa;Password=12345678");
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public SellingForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateProduct();
            PopulateBill();
            fill_combo();
            lblSellerName.Text = loginForm.Sellername;
        }
        private void PopulateProduct(string sql = "select ProName,ProQty from ProductTbl")
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.dgvSelling1.DataSource = Ds.Tables[0];
        }
        private void PopulateBill(string sql = "select * from BillTbl")
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.dgvSelling2.DataSource = Ds.Tables[0];
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            PopulateProduct();
            dgvSelling1.ClearSelection();
            dgvSelling2.ClearSelection();
        }


        private void dgvSelling1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvSelling1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProName.Text = this.dgvSelling1.CurrentRow.Cells["ProName"].Value.ToString();
            txtProQn.Text = this.dgvSelling1.CurrentRow.Cells["ProQty"].Value.ToString();
          
        }

        private void lblDate_Paint(object sender, PaintEventArgs e)
        {

            this.lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrWhiteSpace(this.txtProName.Text) || String.IsNullOrWhiteSpace(this.txtProPrice.Text) ||
                String.IsNullOrWhiteSpace(this.txtProQn.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        internal DataGridViewRow Dgv { get; set; }
        private void TemporaryDataGrid()
        {
            int quantity = int.Parse(txtProQn.Text);
            int price = int.Parse(txtProPrice.Text);
            int total = quantity * price;
            //temporary dataGrid
            this.Dgv = new DataGridViewRow();
            Dgv.CreateCells(dgvSelling3);
            Dgv.Cells[0].Value = n + 1;
            Dgv.Cells[1].Value = txtProName.Text;
            Dgv.Cells[2].Value = txtProPrice.Text;
            Dgv.Cells[3].Value = txtProQn.Text;
            Dgv.Cells[4].Value = total;
            //Convert.ToInt32(txtProPrice.Text) * Convert.ToInt32(txtProQn.Text);
            n++;
            dgvSelling3.Rows.Add(Dgv);
            GrdTotal += total;
            lblAmo.Text = "" + (GrdTotal);
        }
        int n = 0; int GrdTotal = 0;
        private void btnCart_Click(object sender, EventArgs e) // need to optimize
        {
          
            if (IsValidToSave())
            {
                // int total = Convert.ToInt32(txtProPrice.Text) * Convert.ToInt32(txtProQn.Text);
                TemporaryDataGrid();
            }
            else
                MessageBox.Show("Fill the Text Fields");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(dgvSelling1.CurrentRow.Cells[0].Value.ToString());
            try
            {
            if (IsValidToSave())
            {
                int beforeQuantity = int.Parse(dgvSelling1.CurrentRow.Cells[1].Value.ToString());
                int sellingQuantity = int.Parse(txtProQn.Text);
                int newQnty = beforeQuantity - sellingQuantity;
                string Quantity = newQnty.ToString();

                this.Sql2 = @"Update ProductTbl set ProName ='" + txtProName.Text + "',ProQty ='" + Quantity + "',ProPrice ='" + txtProPrice.Text + "',ProCat ='" + cmbProdCat.Text + "' where ProName = '" + txtProName.Text + "'";
                int count2 = Da.ExecuteUpdateQuery(this.Sql2);

                this.PopulateProduct();

                this.Sql = @"insert into BillTbl values('" + lblSellerName.Text + "','" + lblDate.Text + "','" + lblAmo.Text + "');";
                int count = Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1 || count2 == 1)
                    MessageBox.Show("Successfully billed into database");

                else
                    MessageBox.Show("Unsuccessful");
                this.PopulateBill();
                }
                else MessageBox.Show("Fill Textbox");
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
             if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void dgvSelling2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        //took help from internet!
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Tech Sop", new Font("Arial",30, FontStyle.Bold),Brushes.Green, new Point(230));
            e.Graphics.DrawString("Bill ID: "+dgvSelling2.CurrentRow.Cells[0].Value.ToString(), new Font("Arial", 16, FontStyle.Bold), Brushes.Orchid, new Point(100,70));
            e.Graphics.DrawString("Sold By:"+dgvSelling2.CurrentRow.Cells[1].Value.ToString(), new Font("Arial", 16, FontStyle.Bold), Brushes.PaleGoldenrod, new Point(100, 100));
            e.Graphics.DrawString("Bill Date"+dgvSelling2.CurrentRow.Cells[2].Value.ToString(), new Font("Arial", 16, FontStyle.Bold), Brushes.Aqua, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: "+dgvSelling2.CurrentRow.Cells[3].Value.ToString(), new Font("Arial", 16, FontStyle.Bold), Brushes.Violet, new Point(100, 160));


        }
        private void fill_combo() //optimized !! :)
        {
     
        this.Sql = "select CatName from CategoryTbl";
        DataTable dt = Da.ExecuteQueryTable(Sql);
        dt.Columns.Add("Catname", typeof(string));

        cmbProdCat.ValueMember = "CatName"; //Cames from db
        cmbProdCat.DataSource = dt; //data of comboboxx
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoGin lg = new LoGin();
            lg.Show();
        }

        private void btnBillDel_Click(object sender, EventArgs e) //need to add validation
        {
            if (dgvSelling2.SelectedRows.Count > 0) {     
            int id = int.Parse(dgvSelling2.CurrentRow.Cells[0].Value.ToString());
            this.Sql = @"delete from BillTbl where BillId = '" + id + "' ";
            this.Ds = Da.ExecuteQuery(Sql);
            this.PopulateBill();
            }
        }

        private void cmbProdCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Sql = "select ProName,ProQty from ProductTbl where ProCat like '" + cmbProdCat.Text + "%'";
            this.PopulateProduct(Sql);
        }

        private void RefreshDataGrid()  // Optimized :)
        {
            dgvSelling3.Rows.Clear();
          
        }
        private void btnProRef_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
            PopulateProduct();
            txtProName.Text = "";
            txtProPrice.Text = "";
            txtProQn.Text = "";
            this.n = 0; this.GrdTotal = 0; this.lblAmo.Text = "";


        }
    }
}
