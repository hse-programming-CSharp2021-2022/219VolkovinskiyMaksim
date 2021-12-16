using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int x = 10, y = 100, a = 100, b = 100;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scrollBar.Maximum = Width - b;
            e.Graphics.FillRectangle(
                new SolidBrush(SystemColors.ControlDark), x, y, a, b);
            TransparencyKey = SystemColors.ControlDark;
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            x = scrollBar.Value;
            Invalidate();
        }
    }
}
