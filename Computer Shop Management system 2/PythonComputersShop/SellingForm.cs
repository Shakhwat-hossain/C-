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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ARABI;Initial Catalog=pcdb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select prodname,prodqty from pt";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvSellingForm.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void populatebills()
        {
            Con.Open();
            string query = "select * from billt";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvPF.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            fillcombo();
            lblSeller.Text = Form1.Sellername;

        }
        //int flag = 0;
        private void dgvSellingForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = dgvSellingForm.SelectedRows[0].Cells[0].Value.ToString();
            
            ProdPrice
                .Text = dgvSellingForm.SelectedRows[0].Cells[1].Value.ToString();
          //  flag = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int n = 0, Grdtotal = 0;
        private void btnADDPF_Click(object sender, EventArgs e)
        {
            
            if(ProdName.Text== ""|| ProdQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgvORDER);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = ProdName.Text;
            newRow.Cells[2].Value = ProdPrice.Text;
            newRow.Cells[3].Value = ProdQty.Text;
            newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
            dgvORDER.Rows.Add(newRow);
                Grdtotal = Grdtotal + total;
            lblAMOUNT.Text = "" + Grdtotal;

            }
            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddSF_Click(object sender, EventArgs e)
        {
            if (ProdId.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {


                try
                {
                    //  (" + gunatxtCatId.Text + ", '" + gunatxtCatName.Text + "', '" + gunatxtCatDesc.Text + "')";
                    Con.Open();
                    string query = "insert into billt values(" + ProdId.Text + ",'" + ProdName.Text + "','" + lblDate.Text + "','" + lblAMOUNT.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    Con.Close();



                    populatebills();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void dgvPF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PYTHON COMPUTERS & ENGINEERS",new Font ("Elephant",20,FontStyle.Bold),Brushes.Red,new Point(230));
            e.Graphics.DrawString("Bill ID:"+dgvPF.SelectedRows[0].Cells[0].Value.ToString(), new Font ("Century Gothic",12,FontStyle.Bold),Brushes.Red,new Point(100,70));
            e.Graphics.DrawString("Seller Name:" + dgvPF.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 100)); 
            e.Graphics.DrawString("Date:" + dgvPF.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 130));
            e.Graphics.DrawString("Total Amount:" + dgvPF.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(100, 160));
            e.Graphics.DrawString("Thanks for purchasing", new Font("Elephant", 16, FontStyle.Italic), Brushes.Red, new Point(230,230));
                                                 
        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {

        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void cmbCATPROD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select prodname,prodqty from pt where prodcat='" + cmbCATPROD.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvSellingForm.DataSource = ds.Tables[0];
            Con.Close();
        }
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
            cmbCATPROD.ValueMember = "Catname";
            cmbCATPROD.DataSource = dt;
            Con.Close();




        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void lblSeller_Click(object sender, EventArgs e)
        {

        }

        private void dgvORDER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
