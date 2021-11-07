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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Sellername = "";
        SqlConnection Con = new SqlConnection(@"Data Source=ARABI;Initial Catalog=pcdb;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtUSERNAME.Text = "";
            txtPASSWORD.Text = "";
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if (txtUSERNAME.Text == "" || txtPASSWORD.Text == "")
            {
               

                    MessageBox.Show("Enter the UserName and Password");

             
            }
                else
                {
                if (cmbRoleLOGIN.SelectedIndex > -1)
                {

                    if (cmbRoleLOGIN.SelectedItem.ToString() == "ADMIN")
                    {
                        if (txtUSERNAME.Text == "admin" && txtPASSWORD.Text == "admin")

                        {
                            ProductForm2 pf = new ProductForm2();
                            pf.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are admin enter correct id and password ");
                        }
                    }
                    else
                    {
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from st where sellername='" + txtUSERNAME.Text + "' and sellerpass='" + txtPASSWORD.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Sellername = txtUSERNAME.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            Con.Close();

                        }
                        else
                        {
                            MessageBox.Show("Wrong UserName or Password");
                        }
                        Con.Close();
                    }
                   




                }
                else
                {
                    MessageBox.Show("Select a Role");
                }

                }
            }

        private void cmbRoleLOGIN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
           
        
    }

