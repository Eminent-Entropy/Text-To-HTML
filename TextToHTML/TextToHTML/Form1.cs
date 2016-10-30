using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextToHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetTitle()//gets what the user put as the title
        {
            string a = textBox2.Text;
            return(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text; //save what the user typed
            textBox1.Text = "<html>";//html formating
            textBox1.Text += System.Environment.NewLine + "<head>";
            textBox1.Text += System.Environment.NewLine + "<title>";
            textBox1.Text += GetTitle();
            textBox1.Text += "</title>";
            textBox1.Text += System.Environment.NewLine + "</head>";
            textBox1.Text += System.Environment.NewLine + "<body>";
            textBox1.Text += System.Environment.NewLine + "<pre>";
            textBox1.Text += System.Environment.NewLine + textBox1.Tag;
            textBox1.Text += System.Environment.NewLine + "</pre>";
            textBox1.Text += System.Environment.NewLine + "</body>";
            textBox1.Text += System.Environment.NewLine + "</html>";
        }
    }
}