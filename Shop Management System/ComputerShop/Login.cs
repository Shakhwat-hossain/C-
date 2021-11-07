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
    public partial class Login : MetroForm
    {
        //Auto Implemented Property:
        //private DataAccess Da { get; set; }
       // private DataSet Ds { get; set; }

        //internal string Sql { get; set; }
        public Login()
        {
            InitializeComponent();
            //this.Da = new DataAccess();//initializing the constructor-That will create connection with Database
            //this.PopulateGridView();
           // this.Da = new DataAccess();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ARABI;Initial Catalog=pcdb;Integrated Security=True");
        public static string Sellername = ""; 
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "" || txtPass.Text == "")
            {


                MessageBox.Show("Enter the UserName and Password");


            }
            else
            {
                if (cmbRoleLOGIN.SelectedIndex > -1)
                {

                    if (cmbRoleLOGIN.SelectedItem.ToString() == "ADMIN")
                    {
                        if (txtUser.Text == "admin" && txtPass.Text == "admin")

                        {
                            ProductForm pf = new ProductForm();
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
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTbl where SellerName='" + txtUser.Text + "' and SellerPass='" + txtPass.Text + "'", Con);
                        DataTable dt = new DataTable();
                        // DataTable dt = Da.ExecuteQueryTable(sql);
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Sellername = txtUser.Text;
                            SellingForm sf = new SellingForm();
                            sf.Show();
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

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
           
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

       
    }

