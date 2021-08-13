using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messageText = "";
            for (int i = 0; i < 10; i++)
            {
                messageText += "i=" + i.ToString() + " ";
            }
            MessageBox.Show(messageText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string messageText = "";
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    messageText += "i=" + i.ToString() + " " +  "k=" + k.ToString() + Environment.NewLine;
                }

            }
            textBox1.Text=messageText;
        }
    }
}

