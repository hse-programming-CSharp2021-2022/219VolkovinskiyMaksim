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
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text.Length >= 1 && flag)
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            else
            {
                if (flag)
                {
                    this.Opacity -= 0.1;
                    if (this.Opacity == 0)
                    {
                        flag = false;
                        label1.Text = "Кот уже ушел :c";
                    } 
                }
                else
                {
                    this.Opacity += 0.1;
                    if (this.Opacity == 1)
                        flag = true;
                }

            }
            
        }
    }
}
