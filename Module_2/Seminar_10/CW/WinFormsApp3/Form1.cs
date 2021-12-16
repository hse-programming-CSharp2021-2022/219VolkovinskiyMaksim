using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool increase = false;

        private void oneAndOnlyButton_Click(object sender, EventArgs e)
        {
            if (!increase)
            {
                if (this.Size.Width - 100 >= this.MinimumSize.Width)
                    this.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
                else
                {
                    oneAndOnlyButton.Text = "увеличить";
                    increase = true;
                }
            }
            else
            {
                if (this.Size.Width + 100 <= this.MaximumSize.Width)
                    this.Size = new Size(this.Size.Width + 100, this.Size.Height + 100);
                else
                {
                    oneAndOnlyButton.Text = "уменьшить";
                    increase = false;
                }
            }
        }
    }
}
