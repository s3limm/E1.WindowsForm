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
    public partial class F5 : Form
    {
        //int number = 10; eger ben numberı ı local bı yerde deılde global bır yerde atarsam koddan cıktıktan sonra bıle arttırdıgı sayıdan devam eder cunku ramde tutuyor.
        public F5()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {

            int number = 10; // eger ben number ı b1_Click içinde tutarsam sayıyı 1 arttırdıktan sonra tekrar eskı halıne doner 
            try
            {
                
                
                MessageBox.Show((++number).ToString());

            }
            catch (Exception)
            {

                
            }
        }
    }
}
