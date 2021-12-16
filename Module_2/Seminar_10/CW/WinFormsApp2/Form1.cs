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
        public Form1()
        {
            InitializeComponent();
        }

        public string[] myCollection = "я ушел от марок не вернусь обратно".Split(' ');
        private void readCollectionButton_Click(object sender, EventArgs e)
        {
            myTextBox.Lines = myCollection;
        }

        private void showResultButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(' ', myTextBox.Lines));
        }
    }
}
