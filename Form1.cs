using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _10_textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            textBox2.Text = File.ReadAllText(@"text.txt");

            StreamReader file = new StreamReader("text.txt");
            string line;
            int i = 0;
            int c = 0;
            while (!file.EndOfStream)
            {
                i += 1;
                line = file.ReadLine();
                if (textBox1.Text == line)
                {
                    MessageBox.Show(i.ToString());
                    c = 1;
                }
                

            }
            if (c==0)
            {
                MessageBox.Show("не нашлось");
            }




        }
    }
}
