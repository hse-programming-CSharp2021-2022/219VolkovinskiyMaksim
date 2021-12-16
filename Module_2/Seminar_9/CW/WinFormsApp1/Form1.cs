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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.myFirstLabel.Text = "Был мой лейбл, а стал первый музыкальный...";
        }

        private void changeTextButton_Click(object sender, EventArgs e)
        {
            this.myFirstLabel.Text = "Ты думаешь, ты способен что то поменять?\nТы живешь в России, чел...";
            this.changeTextButton.Visible = false;
            this.pressMeButton.Visible = true;
        }

        private void pressMeButton_Click(object sender, EventArgs e)
        {
            this.pressMeButton.Visible = false;
            this.changeTextButton.Visible = true;
        }
    }
}
