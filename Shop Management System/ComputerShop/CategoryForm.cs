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
    public partial class CategoryForm : MetroForm
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        internal string Sql { get; set; }

        //internal string SP { get; set; } //CATEGORY COMBOBOX
        public CategoryForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();//initializing the constructor-That will create connection with Database
            this.PopulateGridView();
        }
       
        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
        private void PopulateGridView(string sql = "select * from CategoryTbl")
        {
            this.Ds = this.Da.ExecuteQuery(sql);//Executing the sql query ,and then we will allocate the query in the Ds (DataSet variable)

            this.dgvCF.AutoGenerateColumns = true;
            this.dgvCF.DataSource = Ds.Tables[0];
        }
        


        private void btnCatRef_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            txtCatName.Text = ""; txtCatDesc.Text = "";
            this.txtAutoSearch.Text = " ";
        }


        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCatName.Text == "" || txtCatDesc.Text == "" )
                {
                    MessageBox.Show("You must fill textbox");
                }
                else
                {
                    try
                    {
                        //this.txtId.ReadOnly = true;
                        this.Sql = @"insert into CategoryTbl values('" + txtCatName.Text + "','" + txtCatDesc.Text +"');";
                        int count = Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                            MessageBox.Show("Category successfully added to database");

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
        private void dgvCF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCatId.Text = this.dgvCF.CurrentRow.Cells["id"].Value.ToString();
            // txtProName.Text = this.dgvPF.CurrentRow.Cells["ProName"].Value.ToString();
            txtCatName.Text = this.dgvCF.CurrentRow.Cells["CatName"].Value.ToString();
            txtCatDesc.Text = this.dgvCF.CurrentRow.Cells["CatDesc"].Value.ToString();


        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtCatId.Text) || String.IsNullOrEmpty(this.txtCatName.Text) ||
                String.IsNullOrEmpty(this.txtCatDesc.Text))
            {
                return false;

            }
            else
            {
                return true;

            }
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from CategoryTbl where CatName like '" + txtAutoSearch.Text + "%'";
            this.PopulateGridView(Sql);
        }

        private void txtAutoSearch_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Text = "";
        }

        private void btnCatEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSave())
                {

                    this.Sql = @"select * from CategoryTbl where id = '" + this.txtCatId.Text + "';";
                    DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                    if (dt.Rows.Count == 1)
                    {
                        //update operation 
                        this.Sql = @"update CategoryTbl
                                 set CatName ='" + this.txtCatName.Text + @"',
                                 CatDesc= '" + this.txtCatDesc.Text + @"'
                                 where id ='" + this.txtCatId.Text + "';";
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
                       // this.Sql = "insert into CategoryTbl values('" + this.txtCatName.Text + "', '" + this.txtCatDesc.Text + "');";
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show("Data inserted successfully in database");
                        else
                            MessageBox.Show("Data insertion failed");


                    }
                    this.PopulateGridView();
                   



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

        private void btnCatDel_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvCF.CurrentRow.Cells["id"].Value.ToString();
                string name = this.dgvCF.CurrentRow.Cells["CatName"].Value.ToString();


                this.Sql = @"delete from CategoryTbl where id='" + id + "';";
                //  MessageBox.Show("Delete " + name);
                if (this.dgvCF.SelectedRows.Count > 0)

                {
                    MessageBox.Show("Delete " + name);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //MessageBox.Show("Delete " + name);
                    if (result == DialogResult.Yes)
                    {
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show(name + " has been deleted");
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

        private void lblCategory_Click(object sender, EventArgs e)
        {
            SellingForm sf = new SellingForm();
            sf.Show();
            this.Hide();
        }

        private void lblProductForm_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
