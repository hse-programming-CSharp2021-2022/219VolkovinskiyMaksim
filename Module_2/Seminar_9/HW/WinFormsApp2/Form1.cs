using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string[] initialArr = new string[] {"Кидаю step",
        "Лечу прям вверх",
        "Мой красный сет",
        "Убил их всех",
        "У них в башке",
        "Один пресет",
        "Я покажу",
        "Тоннельный свет"};
        string[] arr;

        public Form1()
        {
            InitializeComponent();
            arr = new string[initialArr.Length];
            Array.Copy(initialArr, arr, initialArr.Length);
            listBox1.Items.AddRange(arr);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                arr = listBox1.Items.Cast<string>().ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showInitialArrButton_Click(object sender, EventArgs e)
        {
            arr = new string[initialArr.Length];
            Array.Copy(initialArr, arr, initialArr.Length);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(arr);
        }
    }
}
