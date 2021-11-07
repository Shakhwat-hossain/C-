using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace EcShop
{

    public partial class loginForm : Form
    {
        private string Sql { get; set; }
        internal DataAccess DA { get; set; }
        internal DataSet Ds { get; set; }

        public static string Sellername = "";

        public loginForm()
        {
            this.DA = new DataAccess();
            InitializeComponent();
            this.DA = new DataAccess();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LOCAL);Initial Catalog=eShop;Persist Security Info=True;User ID=sa;Password=12345678");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrWhiteSpace(this.txtUserName.Text) || String.IsNullOrWhiteSpace(this.txtUserPass.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lblClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtUserPass.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidToSave())
                {
                    if (txtUserName.Text == "Admin" && txtUserPass.Text == "5630")
                    {
                        ProductForm pf = new ProductForm(); pf.Show(); this.Hide();

                    }
                    else
                    {
                        string sql = "select count(1) from SellerTbl where sellerName ='" + txtUserName.Text + "' and sellerPass =" + txtUserPass.Text + "";
                        DataTable dt = DA.ExecuteQueryTable(sql);

                        if (dt.Rows[0][0].ToString() == "1")
                        {   //label name
                            Sellername = txtUserName.Text;
                            SellingForm sf = new SellingForm(); sf.Show(); this.Hide();
                        }
                       
                    }

                }
                else MessageBox.Show("Please Fill text Box");
            }
            catch { MessageBox.Show("Wrong Usename or Password"); }
        }
    }
}