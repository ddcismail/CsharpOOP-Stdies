using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pazartesi");
            comboBox1.Items.Add("Salı");
            comboBox1.Items.Add("Çarşamba");
            comboBox1.Items.Add("Perşembe");
            comboBox1.Items.Add("Cuma");
            comboBox1.Items.Add("Cumartesi");
            comboBox1.Items.Add("Pazar");
            comboBox2.Items.Add("Adana");
            comboBox2.Items.Add("Denizli");
            comboBox2.Items.Add("Bursa");
            comboBox2.Items.Add("İstanbul");
            comboBox2.Items.Add("Kocaeli");
            comboBox3.Items.Add("Araba");
            comboBox3.Items.Add("Beyaz Eşya");
            comboBox3.Items.Add("Yapı Malzemeleri");
            comboBox3.Items.Add("Yiyecek");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedıtem = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedıtem,"Seçilen");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedindex = comboBox2.SelectedIndex;        //Kesinlikle Değişmeyecek comboBoxlarda kullanılır .
            MessageBox.Show(selectedindex.ToString());          //Çok tercih edilmez.
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox3.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox3.SelectedItem.ToString();
        }
    }
}
