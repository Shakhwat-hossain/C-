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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ARABI;Initial Catalog=pcdb;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgvSF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdSF.Text = dgvSF.SelectedRows[0].Cells[0].Value.ToString();
            txtNameSF.Text = dgvSF.SelectedRows[0].Cells[1].Value.ToString();
            txtAgeSF.Text = dgvSF.SelectedRows[0].Cells[2].Value.ToString();
            txtPhoneSF.Text = dgvSF.SelectedRows[0].Cells[3].Value.ToString();
            txtPasswordSF.Text = dgvSF.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from st";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvSF.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ADDSF_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into st values(" + txtIdSF.Text + ",'" + txtNameSF.Text + "','" + txtAgeSF.Text + "','"+txtPhoneSF.Text+"','"+txtPasswordSF.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                Con.Close();

                Con.Close();

                populate();
                txtIdSF.Text = "";
                txtNameSF.Text = "";
                txtAgeSF.Text = "";
                txtPhoneSF.Text = "";
                txtPasswordSF.Text = "";




            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnCatSF_Click(object sender, EventArgs e)
        {

            CATEGORYFORM cf = new CATEGORYFORM();
            cf.Show();
            this.Hide();
        }

        private void btnEDITSF_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdSF.Text == "" || txtNameSF.Text == "" || txtAgeSF.Text == "" || txtPhoneSF.Text == "" || txtPasswordSF.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    //"update ct set catname='" + gunatxtCatName.Text + "',catdesc='" + gunatxtCatDesc.Text + "'where catid=" + gunatxtCatId.Text + "";
                    Con.Open();
                    string query = "update st set sellerid='" + txtIdSF.Text + "',sellername='" + txtNameSF.Text + "',sellerage='" + txtAgeSF.Text + "',sellerphone='"+txtPhoneSF.Text+"',sellerpass='"+txtPasswordSF.Text+"'where sellerid="+txtIdSF.Text +"";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Seller successfully updated");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select from pt where prodcat='" + comboBox2.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvSF.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm2 product = new ProductForm2();
            product.Show();
            this.Hide();

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();

        }
    }
}
