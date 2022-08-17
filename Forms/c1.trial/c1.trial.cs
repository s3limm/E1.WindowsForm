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
    public partial class CalculatorTrial : Form
    {
        public CalculatorTrial()
        {
            InitializeComponent();
        }
        double number1;
        double number2;
        string op;


        #region Toplama
        private void bT_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(tx1.Text);
                op = "+";
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz .");
                tx1.Text = "";

            }
        }

        #endregion

        #region Cıkarma
        private void bC_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(tx1.Text);
                op = "-";

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz .");
                tx1.Text = "";
            }

        }

        #endregion

        #region Carpma
        private void bCa_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(tx1.Text);
                op = "*";
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz .");
                tx1.Text = "";
            }

        }

        #endregion

        #region Bölme
        private void bBö_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(tx1.Text);
                op = "/";

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz .");
                tx1.Text = "";
            }

        }
        #endregion

        #region Mod Alma
        private void bM_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(tx1.Text);
                op = "%";

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz .");
                tx1.Text = "";
            }

        }

        #endregion

        #region Esittir
        private void bE_Click(object sender, EventArgs e)
        {
            double result;
            try
            {
                number2 = Convert.ToDouble(tx2.Text);

                if (op == "+")
                {
                    result = number1 + number2;
                    MessageBox.Show($"Sonucunuz : {result}");
                }

                else if (op == "-")
                {
                    result = number1 - number2;
                    MessageBox.Show($"Sonucunuz : {result}");
                }

                else if (op == "*")
                {
                    result = number1 * number2;
                    MessageBox.Show($"Sonucunuz : {result}");
                }

                else if (op == "/")
                {
                    result = number1 / number2;
                    MessageBox.Show($"Sonucunuz : {result}");
                }

                else if (op == "%")
                {
                    result = number1 % number2;
                    MessageBox.Show($"Sonucunuz : {result}");
                }

                else
                {
                    MessageBox.Show("Lütfen bir operatör seçiniz");
                }

            }
            catch (FormatException)
            {

                if (!string.IsNullOrEmpty(tx1.Text) && string.IsNullOrEmpty(tx2.Text) || string.IsNullOrEmpty(tx1.Text) && !string.IsNullOrEmpty(tx2.Text))
                {

                    {
                        MessageBox.Show("Lütfen kutucukları boş bırkmayın veya girdiğiniz değere dikkat edin.");
                        tx1.Text = "";
                        tx2.Text = "";

                    }
                }


                else if (!string.IsNullOrEmpty(tx1.Text) && !string.IsNullOrEmpty(tx2.Text))
                {
                    MessageBox.Show("Lütfen kutucuklara yazdığınız değerlere dikkat edin ve terar giriniz.");
                    tx1.Text = "";
                    tx2.Text = "";
                }


                else if (string.IsNullOrEmpty(tx1.Text) && string.IsNullOrEmpty(tx2.Text))
                {
                    MessageBox.Show("Lütfen kutucukları boş bırakmayınız.");
                    tx1.Text = "";
                    tx2.Text = "";
                }
            }

        }


    }

}



#endregion










