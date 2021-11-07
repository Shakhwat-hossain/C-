using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcShop
{
    public partial class CategoryForm : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        public CategoryForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();

        }
        private void grdCatView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // txtCatIdTbl.Text = grdCatView.CurrentRow.Cells["ID"].Value.ToString();
            txtCatName.Text = grdCatView.CurrentRow.Cells["catName"].Value.ToString();
            txtCatDesc.Text = grdCatView.CurrentRow.Cells["catDesc"].Value.ToString();

        }

        private void PopulateGridView(string sql = "select * from Categorytbl")
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.grdCatView.AutoGenerateColumns = false;
            this.grdCatView.DataSource = Ds.Tables[0];

        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrWhiteSpace(this.txtCatName.Text) || String.IsNullOrWhiteSpace(this.txtCatDesc.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidToSave())
                {
                    this.Sql = @"insert into CategoryTbl(CatName,CatDesc) values('" + txtCatName.Text + "','" + txtCatDesc.Text + "');";
                    int count = Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                        MessageBox.Show("Successfully Category addted to database");

                    else
                        MessageBox.Show("Insert unsuccessful");
                    this.PopulateGridView();
                }
                else
                    MessageBox.Show("Fill the blank TextBox");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    


        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       // int i = 1;
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
           
            string sql = "select * from CategoryTbl where CatName like '" + txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);

        }

    

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grdCatView.CurrentRow.Cells[0].Value.ToString());
           

                try{
                if (IsValidToSave())
                {
                    this.Sql = @"Update CategoryTbl set CatName ='" + txtCatName.Text + "',CatDesc ='" + txtCatDesc.Text + "' where CatId = '" + id + "'";
                    int count = Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 0)
                        MessageBox.Show("Edit unsuccessful");
                    else
                    { this.PopulateGridView(); MessageBox.Show("Edit Successful"); }

                }
                else MessageBox.Show("Fill TextBox before Deleting");
            }
            catch (Exception ex)
                {MessageBox.Show(ex.Message);}
            }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grdCatView.CurrentRow.Cells[0].Value.ToString());

            try
            {
                if (IsValidToSave())
                {
                    this.Sql = @"delete from CategoryTbl where Catid = '" + id + "' ;";
                    int count = Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 0)
                        MessageBox.Show("Delete unsuccessful");
                    else
                    {
                        this.PopulateGridView();
                        MessageBox.Show("Successfully Deleted");
                    }
                }
                else MessageBox.Show("Select Row To Delete");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        
       
        private void txtAutoSearch_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (a == 0) { this.txtAutoSearch.Text = ""; a = 1; }         
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            sellerForm sf = new sellerForm();
            sf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoGin lg = new LoGin();
            lg.Show();
        }

        private void btnProRef_Click(object sender, EventArgs e)
        {
            txtCatName.Text = ""; txtCatDesc.Text = "";
            this.txtAutoSearch.Text = "🔍 Search Product Name";
            this.PopulateGridView();
        }

        private void Selling_Click(object sender, EventArgs e)
        {
            BillHistry bh = new BillHistry();
            bh.Show();
            this.Hide();
        }
    }
}

