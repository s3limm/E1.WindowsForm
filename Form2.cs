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
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string name = txb1.Text;
            this.Text = name;
        }
    }
}
