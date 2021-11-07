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
    public partial class ProductForm2 : Form
    {
        public ProductForm2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=ARABI;Initial Catalog=pcdb;Integrated Security=True");
        private void fillcombo()
        {
            //this method will bind the combobox with the database 
            Con.Open();
            SqlCommand cmd = new SqlCommand("select catname from ct  ", Con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catname", typeof(string));

            dt.Load(sdr);
            cmbCATPROD.ValueMember = "catname";
            cmbCATPROD.DataSource = dt;
            Con.Close();


           

        }
        private void ProductForm2_Load(object sender, EventArgs e)
        {
            fillcombo();

        }

        private void btnCATPF_Click(object sender, EventArgs e)
        {
            CATEGORYFORM cf = new CATEGORYFORM();
            cf.Show();
            this.Hide();


        }

        private void btnADDPF_Click(object sender, EventArgs e)
        {
            try
            {
              //  (" + gunatxtCatId.Text + ", '" + gunatxtCatName.Text + "', '" + gunatxtCatDesc.Text + "')";
                Con.Open();
                string query = "insert into pt values(" + txtIdPF.Text + ",'" + txtNamePF.Text + "','" + txtQtyPF.Text + "','"+txtPricePF.Text+"','"+cmbCATPROD.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();

                Con.Close();

               // populate();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void cmbCATPROD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvPF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPF.Text = dgvPF.SelectedRows[0].Cells[0].Value.ToString();
          txtNamePF.Text = dgvPF.SelectedRows[0].Cells[1].Value.ToString();
            txtQtyPF.Text = dgvPF.SelectedRows[0].Cells[2].Value.ToString();
              txtPricePF.Text = dgvPF.SelectedRows[0].Cells[3].Value.ToString();
              cmbCATPROD.SelectedValue = dgvPF.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void cmbMP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select from pt where prodcat='" + cmbMP2.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvPF.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void cmbCATPROD_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }
    }
}
