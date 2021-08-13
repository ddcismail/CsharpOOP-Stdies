using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0, loopControlValue = 10;
            while (loopControlValue<20)
            {
                textBox1.Text += loopControlValue.ToString() + Environment.NewLine;
                sayac++;
                loopControlValue++;
            }
            MessageBox.Show(sayac.ToString(),"SAYAÇ");

        }
    }
}
