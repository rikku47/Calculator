using Calculator.Math;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<ObservableCollection<byte>> numbers;
        private readonly ObservableCollection<char> operators;
        private readonly ObservableCollection<int> results;



        public MainWindow()
        {
            InitializeComponent();

            numbers = new ObservableCollection<ObservableCollection<byte>>()
            {
                new ObservableCollection<byte>()
            };
            operators = new ObservableCollection<char>();
            results = new ObservableCollection<int>();
            numbers[0].Add(0);
            gCalculator.DataContext = numbers;
        }

        #region GetDigits
        private void Zero(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(0);
        }

        private void One(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(1);
        }

        private void Two(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(2);
        }

        private void Three(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(3);
        }

        private void Four(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(4);
        }

        private void Five(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(5);
        }

        private void Six(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(6);
        }

        private void Seven(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(7);
        }

        private void Eight(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(8);
        }

        private void Nine(object sender, RoutedEventArgs e)
        {
            numbers[(numbers.Count - 1)].Add(9);
        }
        #endregion

        private void GetCalcOperator(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content.ToString())
            {
                case "+":
                    operators.Add('+');

                    results.Add(MathEx.Addition());
                    break;

                case "-":
                    operators.Add('-');
                    break;

                case "*":
                    operators.Add('*');
                    break;

                case "/":
                    operators.Add('/');
                    break;
            }

            numbers.Add(new ObservableCollection<byte>());
        }

        private void GetSign(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content.ToString())
            {
                case "=":
                    Calc();
                    break;
            }
        }

        private void Calc()
        {
            int result = 0;

            foreach (var numberList in numbers)
            {
                foreach (var number in numberList)
                {
                    result += number;
                }
            }

            tbResult.Text = result.ToString();
        }

        private void CSharpDataTypes_Loaded(object sender, RoutedEventArgs e)
        {
            if (tbMinByte != null)
                tbMinByte.Text = byte.MinValue.ToString();
            if (tbMaxByte != null)
                tbMaxByte.Text = byte.MaxValue.ToString();
        }

        private void Calculator_Loaded(object sender, RoutedEventArgs e)
        {
            //FightForFreedom();
        }

        #region Nonsense



        private void FightForFreedom()
        {
            List<string> numbersTempBase = new List<string>();

            for (int i = 0; i < 100000000; i++)
            {
                numbersTempBase.Add(1.ToString());
            }

            Stopwatch stopWatch0 = new Stopwatch();
            stopWatch0.Start();

            foreach (var number in numbersTempBase)
            {
                numbers[(numbers.Count - 1)].Add(Convert.ToByte(number));
            }

            stopWatch0.Stop();

            ObservableCollection<ObservableCollection<byte>> numbersTemp = new ObservableCollection<ObservableCollection<byte>>()
            {
                new ObservableCollection<byte>()
            };

            Stopwatch stopWatch2 = new Stopwatch();

            stopWatch2.Start();

            foreach (var number in numbersTempBase)
            {
                switch (number)
                {
                    case "0":
                        numbersTemp[(numbers.Count - 1)].Add(0);
                        break;

                    case "1":
                        numbersTemp[(numbers.Count - 1)].Add(1);
                        break;

                    case "2":
                        numbersTemp[(numbers.Count - 1)].Add(2);
                        break;

                    case "3":
                        numbersTemp[(numbers.Count - 1)].Add(3);
                        break;

                    case "4":
                        numbersTemp[(numbers.Count - 1)].Add(4);
                        break;

                    case "5":
                        numbersTemp[(numbers.Count - 1)].Add(5);
                        break;

                    case "6":
                        numbersTemp[(numbers.Count - 1)].Add(6);
                        break;

                    case "7":
                        numbersTemp[(numbers.Count - 1)].Add(7);
                        break;

                    case "8":
                        numbersTemp[(numbers.Count - 1)].Add(8);
                        break;

                    case "9":
                        numbersTemp[(numbers.Count - 1)].Add(9);
                        break;
                }
            }

            stopWatch2.Stop();
            var test = 0;
        }

        #endregion

        #region Cemetery
        private void GetNumber(object sender, RoutedEventArgs e)
        {
            //int test = '1'; for ascii

            //if (numbers.Count == 0)
            //    numbers.Add(new ObservableCollection<byte>());

            //numbers[(numbers.Count - 1)].Add(Convert.ToByte(((Button)sender).Content));
        }
        #endregion
    }
}