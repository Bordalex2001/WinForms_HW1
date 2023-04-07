using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += StartGame;
        }
        private void StartGame(object sender, EventArgs e) //Почати гру
        {
            DialogResult result;
            int attempt_num = 1;
            while (true)
            {
                result = MessageBox.Show($"Ваше число: {new Random().Next(1, 2000)}?", "Вгадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) //Якщо ви вгадали число
                {
                    MessageBox.Show($"Кількість спроб: {attempt_num}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    attempt_num = 0;
                    result = MessageBox.Show($"Продовжити гру?", "Наступна гра", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        this.Close(); //Вихід
                    }
                }
                attempt_num++;
            }
        }
    }
}