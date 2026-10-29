using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        
        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
        }
    }
}