using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcallicoLab0005
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Math myMathClass = new Math();  
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=(int)Convert.ToDouble(textBox1.Text);
            int b=(int)Convert.ToDouble(textBox2.Text);
            label4.Text = (a + b).ToString();
            MessageBox.Show(Math.Squared(a, b).ToString());





        }
    }
}
