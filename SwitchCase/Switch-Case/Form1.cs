using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messagtex = "";
            switch (Convert.ToInt32(textBox1.Text))
            {
                case 2:
                    messagtex = "x=2";
                    break;
                case 3:
                    messagtex = "x=3";
                    break;
                case 4:
                    messagtex = "x=4";
                    switch (Convert.ToInt32(textBox2.Text))
                    {
                        case 2:
                            messagtex += "y=2";
                            break;
                        case 3:
                            messagtex += "y=3";
                            break;
                        case 4:
                            messagtex += "y=4";
                            break;
                        case 5:
                            messagtex += "y=5";
                            break;
                        default:
                            messagtex += "yanlış sayı yazdınız";
                            break;
                    }
                    break;
                case 5:
                    messagtex = "x=5";
                    break;
                default:
                    messagtex = "yanlış sayı yazdınız";
                    break;
            }
            MessageBox.Show(messagtex);
        }
    }
}
