using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int tyk1 = 0, tyk2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        void btn1Click(object sender, RoutedEventArgs e)
        {
            this.lbl1.Content = $"Тыков1: {++tyk1}";
        }

        void btn2Click(object sender, RoutedEventArgs e)
        {
            this.lbl2.Content = $"Тыков2: {++tyk2}";
        }
    }
}
