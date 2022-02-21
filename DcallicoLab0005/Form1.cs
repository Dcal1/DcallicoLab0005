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
    public partial class Form1 : Form

        
    {
        public Form1()
        {
            InitializeComponent();
        }
        part1Class myClassCS = new part1Class();
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox1.Text);
            int b=Convert.ToInt32(textBox2.Text);
            if (textBox3.Text != "")
            {
                int c = Convert.ToInt32(textBox3.Text);
                MessageBox.Show(part1Class.Add(a, b, c).ToString());
            }
           else
            {
                MessageBox.Show(part1Class.Add(a, b).ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a= textBox1.Text;
            string b=textBox2.Text;
            if (textBox3.Text != "")
            {
                string c = textBox3.Text;
                MessageBox.Show(part1Class.Add(a, b, c).ToString());
            }
            else
            {
                MessageBox.Show(part1Class.Add(a, b).ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.Show();
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
