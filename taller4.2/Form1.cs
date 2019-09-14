using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            int num = 0;          
            int lim = 19;
            for (int i = 0; i <= lim; i++)
            {
                num -= 2;
                lbxnumeros.Items.Add(num.ToString());
            }
        }
    }
}
