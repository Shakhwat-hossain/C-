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

namespace ComputerShop
{
    public partial class ProductForm : MetroForm
    {
        //Auto Implemented Property:
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        internal string Sql { get; set; }
        /// <summary>
        /// So that we do not need to create connection frequently by creating object
        /// instead of declaring field 
        /// </summary>
        /// 
        internal string SP { get; set; } //CATEGORY COMBOBOX
        public ProductForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();//initializing the constructor-That will create connection with Database
            this.PopulateGridView();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
        private void PopulateGridView(string sql= "select * from ProductTbl")
        {
            this.Ds = this.Da.ExecuteQuery(sql);//Executing the sql query ,and then we will allocate the query in the Ds (DataSet variable)

            this.dgvPF.AutoGenerateColumns = true; 
            this.dgvPF.DataSource = Ds.Tables[0];
        }
        private void txtAutoSearch_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Text = "";
        }
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from ProductTbl where ProName like '" + txtAutoSearch.Text + "%'";
            this.PopulateGridView(Sql);
        }

        private void btnProRef_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            txtProName.Text = ""; txtProPrice.Text = ""; txtProQty.Text = ""; txtId.Text = "";
            this.txtAutoSearch.Text = " ";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtProName.Text ==  "")
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

        private void dgvPF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = this.dgvPF.CurrentRow.Cells["id"].Value.ToString();
           // txtProName.Text = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProName.Text = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
            txtProQty.Text = this.dgvPF.CurrentRow.Cells["ProQty"].Value.ToString();
            txtProPrice.Text = this.dgvPF.CurrentRow.Cells["ProPrice"].Value.ToString();
            cmbPF.Text = this.dgvPF.CurrentRow.Cells["ProCat"].Value.ToString();
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtProName.Text) ||
                String.IsNullOrEmpty(this.txtProPrice.Text) || String.IsNullOrEmpty(this.txtProQty.Text))
            {
                return false;

            }
            else
            {
                return true;

            }
        }
        private void btnProEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSave())
                {

                    this.Sql = "select * from ProductTbl where id = '" + this.txtId.Text + "';";
                    DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                    if (dt.Rows.Count == 1)
                    {
                        //update operation 
                        this.Sql = @"update ProductTbl
                                 set ProName ='" + this.txtProName.Text + @"',
                                 ProQty= " + this.txtProQty.Text + @",
                                 ProPrice =' " + this.txtProPrice.Text + @"',
                                 ProCat = '" + this.cmbPF.Text + @"'
                                 where id ='" + this.txtId.Text + "';";
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show("Data updated successfully in database");
                        else
                            MessageBox.Show("Error! data updated failed");
                        // this.PopulateGridView();

                    }
                    else if (dt.Rows.Count == 0)
                    {
                        //insert operation 
                        this.Sql = "insert into ProductTbl values('" + this.txtProName.Text + "', '" + this.txtProQty.Text + "'," +
                 this.txtProPrice.Text +  "');";
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show("Data inserted successfully in database");
                        else
                            MessageBox.Show("Data insertion failed");


                    }
                    this.PopulateGridView();
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

        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProDel_Click(object sender, EventArgs e)
        {
            try
            {
                string pid = this.dgvPF.CurrentRow.Cells["id"].Value.ToString();
                string pname = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
                

                this.Sql = @"delete from ProductTbl where id='" + pid + "';";
                //  MessageBox.Show("Delete " + name);
                if (this.dgvPF.SelectedRows.Count > 0)

                {
                    MessageBox.Show("Delete " + pname);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //MessageBox.Show("Delete " + name);
                    if (result == DialogResult.Yes)
                    {
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show(pname + " has been deleted");
                        else
                            MessageBox.Show("Error Data deletion failed");
                        this.PopulateGridView();

                    }
                    else if (result == DialogResult.No)
                    {

                    }
                }

                else
                {

                    MessageBox.Show("Please select a row first to delete");
                }
                // int row = this.Da.ExecuteUpdateQuery(this.Sql);

                /*   if (row == 1)
                       MessageBox.Show(name + " has been deleted");
                   else
                       MessageBox.Show("Error Data deletion failed");
                   this.PopulateGridView();

               }*/
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }


        private void cmbPF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void metroLabel6_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();
            cf.Show();
            this.Hide();

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSeller_Click(object sender, EventArgs e)
        {
            SellerForm sf = new SellerForm();
            sf.Show();
            this.Hide();
        }

        private void lblSelling_Click(object sender, EventArgs e)
        {
            SellingForm sf = new SellingForm();
            sf.Show();
            this.Hide();
        }
    }
}
// this.Sql = @"insert into ProductTbl values("+txtId.Text+",'"  + txtProName.Text + "'," + txtProQty.Text + "," + txtProPrice.Text + ",'" + cmbPF.Text + "');";