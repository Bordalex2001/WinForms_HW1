using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += ShowMesBox;
        }
        private void ShowMesBox(object sender, EventArgs e) //Показати вікна довідки
        {
            string[] info = { "Студент: Бордюжевич Олексій", "Група: КН-П-213", "Предмет: Розробка додатків мовою C#", "Викладач: Черкезян Христина" }; //Довідка
            int symbol_count = 0;
            string caption = string.Empty; //Заголовок вікна
            for (int i = 0; i < info.Length; i++)
            {
                symbol_count += info[i].Length;
                caption = (info.Length - 1 == i) ? $"Вікно {i + 1}. Середня кількість символів: {symbol_count / info.Length}" : $"Bікно {i + 1}"; //Останнє вікно
                MessageBox.Show(info[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}