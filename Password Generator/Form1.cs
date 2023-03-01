using System;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            bool s = checkBox1.Checked;
            Random r = new Random();
            if (s)
            {
                for (int l = 0; l < b; l++)
                {
                    for (int i = 0; i < a; i++)
                    {
                        char value2 = (char)r.Next(33, 125);
                        if (value2 == '\\' || value2 == '/')
                        {
                            value2 = (char)r.Next(33, 91);
                            richTextBox1.Text += value2.ToString();
                        }
                        else
                        {
                            richTextBox1.Text += value2.ToString();
                        }
                    }
                    richTextBox1.Text += "\n";
                }
            }
            else
            {
                for (int l = 0; l < b; l++)
                {
                    for (int i = 0; i < a; i++)
                    {
                        int value1 = r.Next(0, 9);
                        richTextBox1.Text += value1.ToString();
                    }
                    richTextBox1.Text += "\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}