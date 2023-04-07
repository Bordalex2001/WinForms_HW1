using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += MyClick;
            this.MouseMove += MyMovement;
        }
        private void MyClick(object sender, MouseEventArgs e) //Обробка кліків миші
        {
            string message = "";
            if (e.Button == MouseButtons.Left) //Ліва кнопка миші (ЛКМ)
            {
                if (ModifierKeys == Keys.Control) //ЛКМ + Ctrl
                {
                    this.Close(); //Закриття додатку
                }
                else if ((e.X < 50 || e.X > ClientSize.Width - 50) || (e.Y < 50 || e.Y > ClientSize.Height - 50))
                {
                    message = "Клік зовні прямокутника";
                }
                else if ((e.X == 50 || e.X == ClientSize.Width - 50) || (e.Y == 50 || e.Y == ClientSize.Height - 50))
                {
                    message = "Клік на межі прямокутника";
                }
                else
                {
                    message = "Клік усередині прямокутника";
                }
                MessageBox.Show(message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Button == MouseButtons.Right) //Права кнопка миші (ПКМ)
            {
                Text = $"Робоча область вікна (ширина: {ClientSize.Width}, висота: {ClientSize.Height})";
                Thread.Sleep(1000);
            }
        }
        private void MyMovement(object sender, MouseEventArgs e) //Обробка переміщення покажчика миші
        {
            Text = $"X: {e.X}, Y: {e.Y}";
        }
    }
}