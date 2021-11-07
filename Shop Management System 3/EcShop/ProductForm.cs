using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EcShop
{

    public partial class ProductForm : Form
    {   
        //connection!!
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

//THIS ID STATIC NEED TO SOLVE 
      //  internal int ID = int.Parse(grdProductView.CurrentRow.Cells[0].Value.ToString());

        internal string SP { get; set; } //COMBOX CATEGORY

        public ProductForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(LOCAL);Initial Catalog=eShop;Persist Security Info=True;User ID=sa;Password=12345678");
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProName.Text = this.grdProductView.CurrentRow.Cells["ProName"].Value.ToString();
            txtProQn.Text = this.grdProductView.CurrentRow.Cells["ProQty"].Value.ToString();
            txtProPrice.Text = this.grdProductView.CurrentRow.Cells["ProPrice"].Value.ToString();
            cmbProdCat.Text = grdProductView.CurrentRow.Cells["ProCat"].Value.ToString();
        }

        private void fill_combo() //need to update connection
        {
            //sc.Open();
            //SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl",sc);
            //SqlDataReader dr = cmd.ExecuteReader();

            this.Sql = "select CatName from CategoryTbl";
            DataTable dt = Da.ExecuteQueryTable(Sql);
            dt.Columns.Add("Category", typeof(string));
            //dt.Load(dr);

            cmbProdCat.ValueMember = "CatName";
            cmbProdCat.DataSource = dt;
            this.SP = cmbProdCat.Text;   // cut it off
            sc.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            fill_combo();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();
            cf.Show();
            this.Hide();
        }
        private void PopulateGridView(string sql = "select * from ProductTbl") {
            this.grdProductView.AutoGenerateColumns = false;
            this.Ds = Da.ExecuteQuery(sql);   
            this.grdProductView.DataSource = Ds.Tables[0];
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
        try
        {
                if (IsValidToSave())
                {

                    this.Sql = @"insert into ProductTbl values('" + txtProName.Text + "','" + txtProQn.Text + "','" + txtProPrice.Text + "','" + cmbProdCat.Text + "');";
                    int count = Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                        MessageBox.Show("Successfully Product addted to database");

                    else
                        MessageBox.Show("Insert unsuccessful");
                    this.PopulateGridView();
                }
                else
                    MessageBox.Show("Fill blanks");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }


        private void btnProDel_Click(object sender, EventArgs e) //!!! Exception Missing
        {
            try
            {
                int id = int.Parse(grdProductView.CurrentRow.Cells[0].Value.ToString());
                if (IsValidToSave())
                {
                    this.Sql = @"delete from ProductTbl where id = '" + id + "' ";
                    this.Ds = Da.ExecuteQuery(Sql);
                    this.PopulateGridView();
                }
                else MessageBox.Show("Fill the blanks");
            }catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnProEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grdProductView.CurrentRow.Cells[0].Value.ToString());
               try
               {
                if (IsValidToSave())
                {
                    //  MessageBox.Show(SP.ToString());
                    this.Sql = @"Update ProductTbl set ProName ='" + txtProName.Text + "',ProQty ='" + txtProQn.Text + "',ProPrice ='" + txtProPrice.Text + "',ProCat ='" + cmbProdCat.Text + "' where id = '" + id + "'";
                    int count = Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 0)
                        MessageBox.Show("Edit unsuccessful");
                    else
                    {
                        this.PopulateGridView(); MessageBox.Show("Edit Successful");
                        //   txtProName.Text = "";txtProPrice.Text = "";txtProQn.Text="" ;
                    }
                }
                else MessageBox.Show("Fill TextBox to edit");
            }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        

        private void btnProRef_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            txtProName.Text = ""; txtProPrice.Text = ""; txtProQn.Text = "";
            this.txtAutoSearch.Text = "🔍 Search Product Name";
        }

        private void txtAutoSearch_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Text = "";
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from ProductTbl where ProName like '"+txtAutoSearch.Text+"%'";
            this.PopulateGridView(Sql);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void cmbProdCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BillHistry bh = new BillHistry();
            bh.Show();
            this.Hide();
        }
    }
}
