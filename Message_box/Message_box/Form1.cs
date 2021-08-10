using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_click(object sender, EventArgs e)
        {
            //1.parametrede içerik yazısını belirtir
            //2.parametrede başlığı belirtir
            //3.parametrede button çeşitliliğini belirtik ancak DialogResult yapmanız gerekir
            //4.parametrede ikon eklemesi yaptık

            DialogResult result = MessageBox.Show("ERROR", "Form Title", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                //evete basıldığında yapılacak işlemler yazılır
            }
            else
            {
                //hayıra  basıldığında yapılacak işlemlr yazılır
            }
        }
    }
}
