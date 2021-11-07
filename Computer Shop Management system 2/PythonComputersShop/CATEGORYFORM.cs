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

namespace PythonComputersShop
{
    public partial class CATEGORYFORM : Form
    {
        public CATEGORYFORM()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ARABI;Initial Catalog=pcdb;Integrated Security=True");
        private void ADDCF_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ct values(" + gunatxtCatId.Text + ",'" + gunatxtCatName.Text + "','" + gunatxtCatDesc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();

                Con.Close();

                populate();

            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ct";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvCat.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void CATEGORYFORM_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDELETECAT_Click(object sender, EventArgs e)
        {
            try
            {if(gunatxtCatId.Text=="")
                {
                    MessageBox.Show("Select Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ct where catid=" + gunatxtCatId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted successfully");
                    Con.Close();
                    populate();

                }
               
                
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dgvCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gunatxtCatId.Text = dgvCat.SelectedRows[0].Cells[0].Value.ToString();
            gunatxtCatName.Text = dgvCat.SelectedRows[0].Cells[1].Value.ToString();
            gunatxtCatDesc.Text = dgvCat.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnEDITCAT_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunatxtCatId.Text == "" || gunatxtCatName.Text == "" || gunatxtCatDesc.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update ct set catname='" + gunatxtCatName.Text + "',catdesc='" + gunatxtCatDesc.Text + "'where catid=" + gunatxtCatId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Category successfully updated");
                    Con.Close();
                    populate();
                }

            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnPRODCF_Click(object sender, EventArgs e)
        {
            ProductForm2 pf = new ProductForm2();
            pf.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }
    }
}
