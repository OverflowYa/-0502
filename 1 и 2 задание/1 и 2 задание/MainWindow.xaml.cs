using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _1_и_2_задание
{
    public partial class MainWindow : Window
    {
        private bool isDrawing = false;
        private Point startPoint;
        private Brush brush;

        public MainWindow()
        {
            InitializeComponent();
            brush = Brushes.Black;
            DrawingCanvas.Children.Add(new TextBlock() { Text = "=)" });

        }

        private void DrawingCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (DrawRadioButton.IsChecked == true)
            {
                startPoint = e.GetPosition(DrawingCanvas);
                isDrawing = true;
            }
            else if (EditRadioButton.IsChecked == true)
            {
                // TODO: Implement editing functionality
            }
            else if (DeleteRadioButton.IsChecked == true)
            {
                // TODO: Implement deleting functionality
            }
        }

        private void DrawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point endPoint = e.GetPosition(DrawingCanvas);
                Line line = new Line();
                line.Stroke = brush;
                line.StrokeThickness = SizeSlider.Value;
                line.X1 = startPoint.X;
                line.Y1 = startPoint.Y;
                line.X2 = endPoint.X;
                line.Y2 = endPoint.Y;
                DrawingCanvas.Children.Add(line);
                startPoint = endPoint;
            }
        }

        private void DrawingCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
        }


        private void ColorComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)ColorComboBox.SelectedItem;
            switch (selectedItem.Tag.ToString())
            {
                case "Black":
                    brush = Brushes.Black;
                    break;
                case "Red":
                    brush = Brushes.Red;
                    break;
                case "Blue":
                    brush = Brushes.Blue;
                    break;
                case "Green":
                    brush = Brushes.Green;
                    break;
            }
        }

        private void EditRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Background = SystemColors.ControlBrush;
        }

        private void DeleteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DrawingCanvas.Children.Clear();
        }

    }
}
