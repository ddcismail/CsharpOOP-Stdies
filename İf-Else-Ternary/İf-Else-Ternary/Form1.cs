using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İf_Else_Ternary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Aracı Almak İstiyor Musun ?","İf control",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                textBox1.Text="Evet almak istiyorum";
            }
            else if (result==DialogResult.No)
            {
                textBox1.Text = "Hayır almak istemiyorum";
            }
            else 
            {
                textBox1.Text = "Geri çıktınız";
            }
        }

        private void btnTurnary_Click(object sender, EventArgs e)
        {
            int a = 40, b = 30;
            string turnaryresult;
            turnaryresult = a < b ? a.ToString(" doğru a b'den küçük"): b.ToString("yanlış b a dan küçük") ; //soru işareti öncesi sorgu blogudur burası true dönerse birinci koşul, false ise ikinci koşul döner
            textBox3.Text = turnaryresult;        
        }
    }
}
