using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void AddNumberToX()
        {
            double length = (x.ActualWidth - 20);

            double height = 20;

            for (int i = 40; i < length; i = i + 20)
            {
                Line line = new Line();

                line.X1 = i;
                line.Y1 = -10;

                line.X2 = i;
                line.Y2 = 40;

                line.Stroke = Brushes.Blue;
                line.StrokeThickness = 1;

                grid.Children.Add(line);
            }

            UpdateLayout();
        }

        private void btnX_Click(object sender, RoutedEventArgs e)
        {
            AddNumberToX();
        }
    }

    public class SubtractConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double)value) - 20;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Kann nicht konvertiert werden.");
        }
    }
}
