using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Luas_Lingkaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(jari_jari.Text))
            {
                MessageBox.Show("Please Enter The Value of The Radius!");   
            }
            else if(pilihan.SelectedIndex == 0)
            {
                double a = 3.14, b, c;
                b = double.Parse(this.jari_jari.Text);
                c = a * b * b;
                this.hasil.Text = c.ToString();
            }
            else if(pilihan.SelectedIndex == 1)
            {
                double a = 3.14, b, c;
                b = double.Parse(this.jari_jari.Text);
                c = 2 * a * b;
                this.hasil.Text = c.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jari_jari.Clear();
            hasil.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            jari_jari.Clear();
            hasil.Clear();
        }

        private void finish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
