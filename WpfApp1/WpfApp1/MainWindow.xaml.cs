using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            Button button = sender as Button;
            if (menuItem != null)
            {
                if (menuItem.Header.ToString() == "_Close")
                {
                    this.Close();
                }
                else if (menuItem.Header.ToString() == "_Change Background Color")
                {
                    this.Background = System.Windows.Media.Brushes.Black; // изменение фона на черный
                }
                else if (menuItem.Header.ToString() == "_About")
                {
                    MessageBox.Show("Developed by OverflowYa(Есипов Влад)");
                }
                statusText.Text = "Clicked " + menuItem.Header.ToString();
            }
            else if (button != null)
            {
                if (button.Content.ToString() == "_Close")
                {
                    this.Close();
                }
                else if (button.Content.ToString() == "_Change Background Color")
                {
                    this.Background = System.Windows.Media.Brushes.Black; // изменение фона на черный
                }
                else if (button.Content.ToString() == "_About")
                {
                    MessageBox.Show("Developed by OverflowYa(Есипов Влад)");
                }
                statusText.Text = "Clicked " + button.Content.ToString();
            }
        }
    }
}