using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form
{
    public partial class Calculator : Form
    {
        string op;
        double number1;
        double number2;
        

        public Calculator()
        {
            InitializeComponent();
        }

        private void bT_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
       
            op = "+";
        }

       

        private void bC_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "-";
         
        }

        private void bCa_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "*";

        }

        private void bB_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "%";
           
        }

        private void bM_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "½";
    
        }

        private void bE_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox2.Text);

            double result;

            if (op == "+")
            {
                result = number1 + number2;
                MessageBox.Show(result.ToString());

            }

            else if(op =="-")
            {

                result = number1 - number2;
                MessageBox.Show(result.ToString());

            }

            else if (op == "*")
            {
                result = number1 * number2;
                MessageBox.Show(result.ToString());

            }

            else if (op == "%")
            {

                result = number1 / number2;
                MessageBox.Show(result.ToString());

            }
            else if (op == "½")
            {
                result = number1 % number2;
                MessageBox.Show(result.ToString());

            }

        }
    }
}
