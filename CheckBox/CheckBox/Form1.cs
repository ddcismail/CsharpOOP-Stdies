﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            bool kontrol = checkBox1.Checked;
            if (kontrol==true)
            {
                MessageBox.Show("İşlem Tamam");
            }
          
        }
    }
}
