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
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You found me !!! ");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Failed");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("try again");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So Close");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find The True One ");
        }

        private void F1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz");
        }

        private void b1_MouseHover(object sender, EventArgs e)
        {
            b1.BackColor = Color.DarkOliveGreen;
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = Color.LightGreen;
        }

        private void b2_MouseHover(object sender, EventArgs e)
        {
            b2.BackColor = Color.Red;
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b2.BackColor = Color.IndianRed;
        }

        private void b3_MouseHover(object sender, EventArgs e)
        {
            b3.BackColor = Color.DeepSkyBlue;
        }

        private void b3_MouseLeave(object sender, EventArgs e)
        {
            b3.BackColor = Color.LightSkyBlue;
        }

        private void b4_MouseHover(object sender, EventArgs e)
        {
            b4.BackColor = Color.Yellow;
        }

        private void b4_MouseLeave(object sender, EventArgs e)
        {
            b4.BackColor = Color.GreenYellow;
        }

        private void b5_MouseHover(object sender, EventArgs e)
        {
            b5.BackColor = Color.DarkGray;
        }

        private void b5_MouseLeave(object sender, EventArgs e)
        {
            b5.BackColor = Color.DimGray;
        }

      
    }
}
