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
    public partial class F4ö : Form
    {
        public F4ö()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                if (!string.IsNullOrEmpty(txtb3.Text) && Convert.ToInt32(txtb3.Text) >= 100)
                {
                    MessageBox.Show("100 veya 100'den büyük bir sayı giremezsiniz. Lütfen tekrar deneyiniz.");
                }
                else if (string.IsNullOrEmpty(txtb3.Text))

                {
                    MessageBox.Show("lütfen bir değer giriniz.");
                }
                else
                {

                    int number = Convert.ToInt32(txtb3.Text);
                    number++;
                    txtb3.Text = number.ToString();

                }


            }
            catch (FormatException)
            {
                MessageBox.Show("lütfen sayısal bir değer giriniz");
                txtb3.Text = "";

            }



        }
    }
}
