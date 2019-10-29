using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double textbox1, textbox2, res;
        String symbol;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textbox1 = Convert.ToDouble(textBox1.Text);
            textbox2 = Convert.ToDouble(textBox2.Text);

            if (symbol == "+")
            {
                res = textbox1 + textbox2;
                Result.Text = res.ToString();     
            }

            if (symbol == "-")
            {
                res = textbox1 - textbox2;
                Result.Text = res.ToString();
            }

            if (symbol == "*")
            {
                res = textbox1 * textbox2;
                Result.Text = res.ToString();
            }

            if (symbol == "/")
            {
                if (textbox2 == 0)
                {
                    textbox2 = 1;
                    textBox2.Text = textbox2.ToString();
                    String messg = "You cannot divide by zero !";
                    MessageBox.Show(messg);

                }
                    res = textbox1 / textbox2;
                    Result.Text = res.ToString();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = comboBox1.Text;
            symbol = s;

        }
    }
}
