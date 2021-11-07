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
   
    public partial class SellerForm : MetroForm
    {
        //Auto Implemented Property:
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        internal string Sql { get; set; }
        public SellerForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();//initializing the constructor-That will create connection with Database
            this.Populate();


        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }
        private void Populate(string sql = "select * from SellerTbl")
        {
            this.Ds = this.Da.ExecuteQuery(sql);//Executing the sql query ,and then we will allocate the query in the Ds (DataSet variable)

            this.dgvSlrF.AutoGenerateColumns = true;
            this.dgvSlrF.DataSource = Ds.Tables[0];
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from SellerTbl where SellerName like '" + txtAutoSearch.Text + "%'";
            this.Populate(Sql);
        }

        private void txtAutoSearch_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Text = "";
        }

        private void btnSlrRef_Click(object sender, EventArgs e)
        {
            this.Populate();
            txtSellerName.Text = ""; txtSellerAge.Text = ""; txtSellerPhone.Text = ""; txtSellerPass.Text = "";
            this.txtAutoSearch.Text = " ";
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtSellerId.Text) || String.IsNullOrEmpty(this.txtSellerName.Text) ||
                String.IsNullOrEmpty(this.txtSellerPhone.Text) || String.IsNullOrEmpty(this.txtSellerAge.Text) || String.IsNullOrEmpty(this.txtSellerPass.Text))
            {
                return false;

            }
            else
            {
                return true;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSave())
                {

                    this.Sql = "select * from SellerTbl where SellerName  = '" + this.txtSellerName.Text + "';";
                    DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                    if (dt.Rows.Count == 1)
                    {
                        //update operation 
                        this.Sql = @"insert into SellerTbl (SellerId,Sellername,SellerAge,SellerPhone,SellerPass) values( " + this.txtSellerId.Text + ",'" + this.txtSellerName.Text + "', " + this.txtSellerAge.Text + "," + this.txtSellerPhone.Text + "," +
                 this.txtSellerPass.Text + ");";
                       
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show("Data updated successfully in database");
                        else
                            MessageBox.Show("Error! data updated failed");


                    }
                    else if (dt.Rows.Count == 0)
                    {
                        //insert operation 
                        this.Sql = @"insert into SellerTbl (SellerId,SellerName,SellerAge,SellerPhone,SellerPass) values( " + this.txtSellerId.Text + ",'" + this.txtSellerName.Text + "', " + this.txtSellerAge.Text + "," + this.txtSellerPhone.Text + "," +
                 this.txtSellerPass.Text + ");";
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show("Data inserted successfully in database");
                        else
                            MessageBox.Show("Data insertion failed");


                    }
                    this.Populate();
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

        private void dgvSlrF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSellerId.Text = this.dgvSlrF.CurrentRow.Cells["SellerId"].Value.ToString();
            txtSellerName.Text = this.dgvSlrF.CurrentRow.Cells["SellerName"].Value.ToString();
            txtSellerAge.Text = this.dgvSlrF.CurrentRow.Cells["SellerAge"].Value.ToString();
            txtSellerPhone.Text = this.dgvSlrF.CurrentRow.Cells["SellerPhone"].Value.ToString();
            txtSellerPass.Text = this.dgvSlrF.CurrentRow.Cells["SellerPass"].Value.ToString();
        }

        private void dgvSlrF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSellerId.Text = this.dgvSlrF.CurrentRow.Cells["SellerId"].Value.ToString();
            txtSellerName.Text = this.dgvSlrF.CurrentRow.Cells["SellerName"].Value.ToString();
            txtSellerAge.Text = this.dgvSlrF.CurrentRow.Cells["SellerAge"].Value.ToString();
            txtSellerPhone.Text = this.dgvSlrF.CurrentRow.Cells["SellerPhone"].Value.ToString();
            txtSellerPass.Text = this.dgvSlrF.CurrentRow.Cells["SellerPass"].Value.ToString();
            
        }

        private void btnSlrEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSave())
                {

                    this.Sql = "select * from SellerTbl where SellerId  = '" + this.txtSellerId.Text + "';";
                    DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                    if (dt.Rows.Count == 1)
                    {
                        //update operation 
                        this.Sql = @"update SellerTbl
                                 set SellerName ='" + this.txtSellerName.Text + @"',
                                 SellerAge= " + this.txtSellerAge.Text + @",
                                 SellerPhone =' " + this.txtSellerPhone.Text + @"',
                                 SellerPass = '" + this.txtSellerPass.Text + @"'
                                 where SellerId ='" + this.txtSellerId.Text + "';";
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show("Data updated successfully in database");
                        else
                            MessageBox.Show("Error! data updated failed");


                    }
                    else if (dt.Rows.Count == 0)
                    {
                        //insert operation 
                        this.Sql = "insert into SellerTbl values('" + this.txtSellerId.Text + "','" + this.txtSellerName.Text + "', '" + this.txtSellerAge.Text + "'," + this.txtSellerPhone.Text + "'," +
                 this.txtSellerPass.Text + "');";
                        int row = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (row == 1)
                            MessageBox.Show("Data inserted successfully in database");
                        else
                            MessageBox.Show("Data insertion failed");


                    }
                    this.Populate();
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

        private void btnSlrDel_Click(object sender, EventArgs e)
        {
            try
            {
                //string id = this.dgvSlrF.CurrentRow.Cells["SellerId"].Value.ToString();
                string name = this.dgvSlrF.CurrentRow.Cells["SellerName"].Value.ToString();


                this.Sql = @"delete from SellerTbl where SellerName='" + name + "';";
                //  MessageBox.Show("Delete " + name);
                if (this.dgvSlrF.SelectedRows.Count > 0)

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
                        this.Populate();

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

        private void lblProductForm_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
            this.Hide();

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();
            cf.Show();
            this.Hide();

        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            
                try
                {
                    int rowIndex = dgvSlrF.CurrentCell.RowIndex;
                    dgvSlrF.Rows.RemoveAt(rowIndex);


                    dgvSlrF.Refresh();
                }
                catch (Exception exc)
                {
                    exc = null;
                }


            
        }
    }
}
