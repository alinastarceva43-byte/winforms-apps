using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Random rnd = new Random();
        private int secretNumber;
        private int attempts;

        public Form2()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            secretNumber = rnd.Next(1, 101); 
            attempts = 0;

            label1.Text = "Подсказка:";
            label2.Text = "Попытки: 0";
            label3.Text = ""; 
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!int.TryParse(textBox1.Text, out int guess))
            {
                MessageBox.Show("Введите целое число!", "Ошибка");
                return;
            }

            attempts++;
            label2.Text = "Попытки: " + attempts;

           
            if (guess == secretNumber)
            {
                label1.Text = "Подсказка:";
                label3.Text = "Вы угадали!"; 
            }
            else if (guess < secretNumber)
            {
                label1.Text = "Подсказка: число больше!";
            }
            else
            {
                label1.Text = "Подсказка: число меньше!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartNewGame(); 
        }
    }
}