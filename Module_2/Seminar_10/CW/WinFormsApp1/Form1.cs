using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int n = 0;

        public static int Pell(int n)
        {
            if (n == 1)
                return 1;
            else if (n == 2)
                return 2;
            else return Pell(n - 2) + 2 * Pell(n - 1);
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            if (Pell(n + 1) <= 0)
            {
                MessageBox.Show("Переполнение емае блин...");
                n = 0;
            }
            else
                myLabel.Text = "Член Ряда Пелла: " + Pell(++n);
        }
    }
}
