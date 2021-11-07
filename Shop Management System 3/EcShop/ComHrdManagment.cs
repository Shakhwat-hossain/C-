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
    public partial class ComHrdManagment : Form
    {
        public ComHrdManagment()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            startProgess.Value = startpoint;
            if(startProgess.Value == 100)
            {
                startProgess.Value = 0;
                timer1.Stop();
                loginForm log = new loginForm();
                this.Hide();
                log.Show();
            }
        }

        private void ComHrdManagment_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
