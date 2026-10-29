using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        
        private void AnyButton_Click(object sender, EventArgs e)
        {
            
            Button clickedButton = (Button)sender;

            
            clickedButton.Text = textBox1.Text;
        }
    }
}