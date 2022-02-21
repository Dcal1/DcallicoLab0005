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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        part2Class myClass2 = new part2Class();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(part2Class.Calculate(a, b).ToString());
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 myForm3 = new Form3();
            myForm3.Show();
            this.Hide();
        }
    }
}
