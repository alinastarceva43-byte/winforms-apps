using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        
        private Random rnd = new Random();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);

           
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}