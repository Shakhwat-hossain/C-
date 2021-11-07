using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcShop
{
    public partial class BillHistry : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        public BillHistry()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            populatedGridView();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }
        private void populatedGridView(string sql = "select SellerName,BillDate,TotAmt from BillTbl")
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.dgvBillView.DataSource = Ds.Tables[0];
        }
        private void BillHistry_Load(object sender, EventArgs e)
        {
            
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoGin lf = new LoGin();
            lf.Show();
            this.Hide();
        }
    }
}
