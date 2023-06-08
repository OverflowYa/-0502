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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            int n = int.Parse(textBox.Text);
            int k = int.Parse(textBox1.Text);
            int x= int.Parse(textBox2.Text);
            int y= int.Parse(textBox3.Text);
            double o= 0;
            for (int i = 1; i < n;i++)
            {
                for(int j = 1; j <k ;j++)
                {
                    double a = (Math.Abs(Math.Pow(x, i)) + Math.Cos(y) * Math.Pow(y, j)) / (i * j);
                    o =+  a;
                }
            }
            textBox4.Text =Convert.ToString(o);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
