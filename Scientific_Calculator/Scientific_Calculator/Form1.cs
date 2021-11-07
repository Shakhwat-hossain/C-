using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation=" ";
        bool enter_value = false;
        float iCelcius, iFahrenheit, ikelvin;
        char iOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 378;
            txtDisplay.Width = 333;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 378;
            txtDisplay.Width = 333;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 730;
            txtDisplay.Width = 688;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1070;
            txtDisplay.Width = 688;
            txtConvert.Focus();
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox3.Location = new Point(719, 44);
        }

        private void scientificToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Width = 732;
            txtDisplay.Width = 688;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void unitControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1070;
            txtDisplay.Width = 688;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1070;
            txtDisplay.Width = 688;
            txtMultiply.Focus();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox3.Location = new Point(719,44);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                      txtDisplay.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;

            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length>0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";

            }
        }

        private void Operators(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOp.Text = System.Convert.ToString(result) + "" + operation;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "×":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (result % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (result);
                    txtDisplay.Text = Math.Exp( i * Math.Log (q * 4)).ToString();
                    break;




            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.1416";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                double ilog = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
                ilog = Math.Log10(ilog);
                txtDisplay.Text = System.Convert.ToString(ilog);
            }
           
             catch
            {

            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try {
                double sq = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")");
                sq = Math.Sqrt(sq);
                txtDisplay.Text = System.Convert.ToString(sq);
            }
            catch
            {

            }
            
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            try
            {
                double sinh = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")");
                sinh = Math.Sinh(sinh);
                txtDisplay.Text = System.Convert.ToString(sinh);
            }
            catch { }


        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try {
                double sin = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
                sin = Math.Sin(sin);
                txtDisplay.Text = System.Convert.ToString(sin);
            }
            catch (Exception exc)
            {

            }

        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try {
                double cos = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")");
                cos = Math.Cos(cos);
                txtDisplay.Text = System.Convert.ToString(cos);
            }
            catch (Exception exc)
            {

            }

        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            try
            {
                double cosh = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")");
                cosh = Math.Sin(cosh);
                txtDisplay.Text = System.Convert.ToString(cosh);
            }
            catch (Exception exc)
            {

            }

        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            try
            {
                double tanh = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")");
                tanh = Math.Tanh(tanh);
                txtDisplay.Text = System.Convert.ToString(tanh);
            }
            catch (Exception exc)
            {

            }


        }

    private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                double tan = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")");
                tan = Math.Tan(tan);
                txtDisplay.Text = System.Convert.ToString(tan);
            }
            catch (Exception exc)
            {

            }

        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtDisplay.Text);
                txtDisplay.Text =
                    System.Convert.ToString(a, 2);
            }
            catch (Exception exc)
            {

            }
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtDisplay.Text);
                txtDisplay.Text =
                    System.Convert.ToString(a, 16);
            }
            catch (Exception exc)
            {

            }
            
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtDisplay.Text);
                txtDisplay.Text =
                    System.Convert.ToString(a, 8);
            }
            catch(Exception exc)
            {
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtDisplay.Text);
                int binVal = 0, decval = 0, baseVal = 1, rem;
                a = int.Parse(txtDisplay.Text);
                binVal = a;
                while (a > 0)
                {
                    rem = a % 10;
                    decval = decval + rem * baseVal;
                    a = a / 10;
                    baseVal = baseVal * 2;

                }

                // Console.Write("\nDecimal: " + a);

                // decval = int.Parse(txtDisplay.Text);
                txtDisplay.Text =
                    System.Convert.ToString(decval);
            }
            catch { }
           
        }

        private void btnSq_Click(object sender, EventArgs e)
        {
            try
            {
                Double a;
                a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = System.Convert.ToString(a);
            }
            catch(Exception exc)
            {

            }
            
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            try
            {
                Double a;
                a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = System.Convert.ToString(a);
            }
            catch (Exception exc)
            {

            }

        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            try
            {
                Double a;
                a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
                txtDisplay.Text = System.Convert.ToString(a);
            }
            catch (Exception exc)
            {

            }
        }

        private void rbCelToFahr_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                switch (iOperation)
                {

                    case 'C':
                        //Celcius to Fahrenheit 
                        iCelcius = float.Parse(txtConvert.Text);
                        lblConvert.Text = ((((iCelcius - 32) * 5) + 32) / 9).ToString();
                        break;
                    case 'F':
                        //Fahrenheit to Celcius 
                        iFahrenheit = float.Parse(txtConvert.Text);
                        lblConvert.Text = ((((iFahrenheit - 32) * 5) + 32) / 9).ToString();
                        break;
                    case 'K':
                        //Convert t\o Kelvin 
                        ikelvin = float.Parse(txtConvert.Text);
                        lblConvert.Text = ((((9 * ikelvin) / 5) + 32) + 273.5).ToString();
                        break;




                }
            }
            catch (Exception exc)
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblConvert_Click(object sender, EventArgs e)
        {
            this.Width = 100;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "";
            rbCelToFahr.Checked = false;
            rbFahrToCel.Checked = false;
            rbKelvin.Checked = false;
        }

       

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                a = Convert.ToInt32(txtMultiply.Text);

                for (int i = 1; i < 13; i++)
                {
                    lstMultiply.Items.Add(i + "x" + a + "=" + a * i);

                }
            }
            catch(Exception exc)
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResetMultiply_Click(object sender, EventArgs e)
        {
            lstMultiply.Items.Clear();
            txtMultiply.Clear();
        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            try
            {
                double ilog = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
                ilog = Math.Log(ilog);
                txtDisplay.Text = System.Convert.ToString(ilog);
            }
            catch (Exception exc)
            {

            }

        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            try
            {
                Double a;
                a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
                txtDisplay.Text = System.Convert.ToString(a);
            }
            catch (Exception exc)
            {
                
            }
        }
    }
}
