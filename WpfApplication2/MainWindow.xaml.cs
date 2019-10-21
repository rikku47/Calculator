using Calculator.MathEx;
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
        private readonly ObservableCollection<Term> Terms;
        private Term Term;

        public MainWindow()
        {
            InitializeComponent();

            Term = new Term(0);

            Terms = new ObservableCollection<Term>
            {
                Term
            };
            //Term = new Term();
            //Terms.Add(Term);

            lvOutput.ItemsSource = Terms;
        }

        #region GetDigits
        private void Zero(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(0);
        }

        private void One(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(1);
        }

        private void Two(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(2);
        }

        private void Three(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(3);
        }

        private void Four(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(4);
        }

        private void Five(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(5);
        }

        private void Six(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(6);
        }

        private void Seven(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(7);
            
        }

        private void Eight(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(8);
        }

        private void Nine(object sender, RoutedEventArgs e)
        {
            Term.DigitGroup.Add(9);
        }
        #endregion

        private void GetCalcOperator(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content.ToString())
            {
                case "+":
                    Term.OperatorSign = "+";
                    //Term.Results.Add(MathEx.Addition(1));
                    Term.DigitGroups.Add(new ObservableCollection<sbyte>());
                    break;

                case "-":
                    Terms[0] = null;
                    //operators.Add('-');
                    break;

                case "*":
                    Terms[0] = null;
                    //operators.Add('*');
                    break;

                case "/":
                    Terms[0] = null;
                    //operators.Add('/');
                    break;
            }

            Terms.Add(new Term());
        }

        private void GetSign(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content.ToString())
            {
                case "=":
                    break;
            }
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
                //numbers[(numbers.Count - 1)].Add(Convert.ToSByte(number));
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
                        numbersTemp[(Terms.Count - 1)].Add(0);
                        break;

                    case "1":
                        numbersTemp[(Terms.Count - 1)].Add(1);
                        break;

                    case "2":
                        numbersTemp[(Terms.Count - 1)].Add(2);
                        break;

                    case "3":
                        numbersTemp[(Terms.Count - 1)].Add(3);
                        break;

                    case "4":
                        numbersTemp[(Terms.Count - 1)].Add(4);
                        break;

                    case "5":
                        numbersTemp[(Terms.Count - 1)].Add(5);
                        break;

                    case "6":
                        numbersTemp[(Terms.Count - 1)].Add(6);
                        break;

                    case "7":
                        numbersTemp[(Terms.Count - 1)].Add(7);
                        break;

                    case "8":
                        numbersTemp[(Terms.Count - 1)].Add(8);
                        break;

                    case "9":
                        numbersTemp[(Terms.Count - 1)].Add(9);
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

        private void Calculator_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            switch (e.Key)
            {
                case System.Windows.Input.Key.None:
                    break;
                case System.Windows.Input.Key.Cancel:
                    break;
                case System.Windows.Input.Key.Back:
                    break;
                case System.Windows.Input.Key.Tab:
                    break;
                case System.Windows.Input.Key.LineFeed:
                    break;
                case System.Windows.Input.Key.Clear:
                    break;
                case System.Windows.Input.Key.Return:
                    break;
                //case System.Windows.Input.Key.Enter:
                //    break;
                case System.Windows.Input.Key.Pause:
                    break;
                case System.Windows.Input.Key.Capital:
                    break;
                //case System.Windows.Input.Key.CapsLock:
                //    break;
                case System.Windows.Input.Key.KanaMode:
                    break;
                //case System.Windows.Input.Key.HangulMode:
                //    break;
                case System.Windows.Input.Key.JunjaMode:
                    break;
                case System.Windows.Input.Key.FinalMode:
                    break;
                case System.Windows.Input.Key.HanjaMode:
                    break;
                //case System.Windows.Input.Key.KanjiMode:
                //    break;
                case System.Windows.Input.Key.Escape:
                    break;
                case System.Windows.Input.Key.ImeConvert:
                    break;
                case System.Windows.Input.Key.ImeNonConvert:
                    break;
                case System.Windows.Input.Key.ImeAccept:
                    break;
                case System.Windows.Input.Key.ImeModeChange:
                    break;
                case System.Windows.Input.Key.Space:
                    break;
                case System.Windows.Input.Key.Prior:
                    break;
                //case System.Windows.Input.Key.PageUp:
                //    break;
                case System.Windows.Input.Key.Next:
                    break;
                //case System.Windows.Input.Key.PageDown:
                //    break;
                case System.Windows.Input.Key.End:
                    break;
                case System.Windows.Input.Key.Home:
                    break;
                case System.Windows.Input.Key.Left:
                    break;
                case System.Windows.Input.Key.Up:
                    break;
                case System.Windows.Input.Key.Right:
                    break;
                case System.Windows.Input.Key.Down:
                    break;
                case System.Windows.Input.Key.Select:
                    break;
                case System.Windows.Input.Key.Print:
                    break;
                case System.Windows.Input.Key.Execute:
                    break;
                case System.Windows.Input.Key.Snapshot:
                    break;
                //case System.Windows.Input.Key.PrintScreen:
                //    break;
                case System.Windows.Input.Key.Insert:
                    break;
                case System.Windows.Input.Key.Delete:
                    break;
                case System.Windows.Input.Key.Help:
                    break;
                case System.Windows.Input.Key.D0:
                    Term.DigitGroup.Add(0);
                    break;
                case System.Windows.Input.Key.D1:
                    Term.DigitGroup.Add(1);
                    break;
                case System.Windows.Input.Key.D2:
                    Term.DigitGroup.Add(2);
                    break;
                case System.Windows.Input.Key.D3:
                    Term.DigitGroup.Add(3);
                    break;
                case System.Windows.Input.Key.D4:
                    Term.DigitGroup.Add(4);
                    break;
                case System.Windows.Input.Key.D5:
                    Term.DigitGroup.Add(5);
                    break;
                case System.Windows.Input.Key.D6:
                    Term.DigitGroup.Add(6);
                    break;
                case System.Windows.Input.Key.D7:
                    Term.DigitGroup.Add(7);
                    break;
                case System.Windows.Input.Key.D8:
                    Term.DigitGroup.Add(8);
                    break;
                case System.Windows.Input.Key.D9:
                    Term.DigitGroup.Add(9);
                    break;
                case System.Windows.Input.Key.A:
                    break;
                case System.Windows.Input.Key.B:
                    break;
                case System.Windows.Input.Key.C:
                    break;
                case System.Windows.Input.Key.D:
                    break;
                case System.Windows.Input.Key.E:
                    break;
                case System.Windows.Input.Key.F:
                    break;
                case System.Windows.Input.Key.G:
                    break;
                case System.Windows.Input.Key.H:
                    break;
                case System.Windows.Input.Key.I:
                    break;
                case System.Windows.Input.Key.J:
                    break;
                case System.Windows.Input.Key.K:
                    break;
                case System.Windows.Input.Key.L:
                    break;
                case System.Windows.Input.Key.M:
                    break;
                case System.Windows.Input.Key.N:
                    break;
                case System.Windows.Input.Key.O:
                    break;
                case System.Windows.Input.Key.P:
                    break;
                case System.Windows.Input.Key.Q:
                    break;
                case System.Windows.Input.Key.R:
                    break;
                case System.Windows.Input.Key.S:
                    break;
                case System.Windows.Input.Key.T:
                    break;
                case System.Windows.Input.Key.U:
                    break;
                case System.Windows.Input.Key.V:
                    break;
                case System.Windows.Input.Key.W:
                    break;
                case System.Windows.Input.Key.X:
                    break;
                case System.Windows.Input.Key.Y:
                    break;
                case System.Windows.Input.Key.Z:
                    break;
                case System.Windows.Input.Key.LWin:
                    break;
                case System.Windows.Input.Key.RWin:
                    break;
                case System.Windows.Input.Key.Apps:
                    break;
                case System.Windows.Input.Key.Sleep:
                    break;
                case System.Windows.Input.Key.NumPad0:
                    Term.DigitGroup.Add(0);
                    break;
                case System.Windows.Input.Key.NumPad1:
                    Term.DigitGroup.Add(1);
                    break;
                case System.Windows.Input.Key.NumPad2:
                    Term.DigitGroup.Add(2);
                    break;
                case System.Windows.Input.Key.NumPad3:
                    Term.DigitGroup.Add(3);
                    break;
                case System.Windows.Input.Key.NumPad4:
                    Term.DigitGroup.Add(4);
                    break;
                case System.Windows.Input.Key.NumPad5:
                    Term.DigitGroup.Add(5);
                    break;
                case System.Windows.Input.Key.NumPad6:
                    Term.DigitGroup.Add(6);
                    break;
                case System.Windows.Input.Key.NumPad7:
                    Term.DigitGroup.Add(7);
                    break;
                case System.Windows.Input.Key.NumPad8:
                    Term.DigitGroup.Add(8);
                    break;
                case System.Windows.Input.Key.NumPad9:
                    Term.DigitGroup.Add(9);
                    break;
                case System.Windows.Input.Key.Multiply:
                    Term.OperatorSign = "*";
                    Term.Results.Add(MathEx.MathEx.Multiply(1));
                    Term.DigitGroups.Add(new ObservableCollection<sbyte>());
                    break;
                case System.Windows.Input.Key.Add:
                    Term.OperatorSign = "+";
                    Term.Results.Add(MathEx.MathEx.Addition(1));
                    Term.DigitGroups.Add(new ObservableCollection<sbyte>());
                    break;
                case System.Windows.Input.Key.Separator:
                    break;
                case System.Windows.Input.Key.Subtract:
                    Term.OperatorSign = "-";
                    Term.Results.Add(MathEx.MathEx.Subtract(1));
                    Term.DigitGroups.Add(new ObservableCollection<sbyte>());
                    break;
                case System.Windows.Input.Key.Decimal:
                    break;
                case System.Windows.Input.Key.Divide:
                    Term.OperatorSign = "/";
                    Term.Results.Add(MathEx.MathEx.Divide(1));
                    Term.DigitGroups.Add(new ObservableCollection<sbyte>());
                    break;
                case System.Windows.Input.Key.F1:
                    break;
                case System.Windows.Input.Key.F2:
                    break;
                case System.Windows.Input.Key.F3:
                    break;
                case System.Windows.Input.Key.F4:
                    break;
                case System.Windows.Input.Key.F5:
                    break;
                case System.Windows.Input.Key.F6:
                    break;
                case System.Windows.Input.Key.F7:
                    break;
                case System.Windows.Input.Key.F8:
                    break;
                case System.Windows.Input.Key.F9:
                    break;
                case System.Windows.Input.Key.F10:
                    break;
                case System.Windows.Input.Key.F11:
                    break;
                case System.Windows.Input.Key.F12:
                    break;
                case System.Windows.Input.Key.F13:
                    break;
                case System.Windows.Input.Key.F14:
                    break;
                case System.Windows.Input.Key.F15:
                    break;
                case System.Windows.Input.Key.F16:
                    break;
                case System.Windows.Input.Key.F17:
                    break;
                case System.Windows.Input.Key.F18:
                    break;
                case System.Windows.Input.Key.F19:
                    break;
                case System.Windows.Input.Key.F20:
                    break;
                case System.Windows.Input.Key.F21:
                    break;
                case System.Windows.Input.Key.F22:
                    break;
                case System.Windows.Input.Key.F23:
                    break;
                case System.Windows.Input.Key.F24:
                    break;
                case System.Windows.Input.Key.NumLock:
                    break;
                case System.Windows.Input.Key.Scroll:
                    break;
                case System.Windows.Input.Key.LeftShift:
                    break;
                case System.Windows.Input.Key.RightShift:
                    break;
                case System.Windows.Input.Key.LeftCtrl:
                    break;
                case System.Windows.Input.Key.RightCtrl:
                    break;
                case System.Windows.Input.Key.LeftAlt:
                    break;
                case System.Windows.Input.Key.RightAlt:
                    break;
                case System.Windows.Input.Key.BrowserBack:
                    break;
                case System.Windows.Input.Key.BrowserForward:
                    break;
                case System.Windows.Input.Key.BrowserRefresh:
                    break;
                case System.Windows.Input.Key.BrowserStop:
                    break;
                case System.Windows.Input.Key.BrowserSearch:
                    break;
                case System.Windows.Input.Key.BrowserFavorites:
                    break;
                case System.Windows.Input.Key.BrowserHome:
                    break;
                case System.Windows.Input.Key.VolumeMute:
                    break;
                case System.Windows.Input.Key.VolumeDown:
                    break;
                case System.Windows.Input.Key.VolumeUp:
                    break;
                case System.Windows.Input.Key.MediaNextTrack:
                    break;
                case System.Windows.Input.Key.MediaPreviousTrack:
                    break;
                case System.Windows.Input.Key.MediaStop:
                    break;
                case System.Windows.Input.Key.MediaPlayPause:
                    break;
                case System.Windows.Input.Key.LaunchMail:
                    break;
                case System.Windows.Input.Key.SelectMedia:
                    break;
                case System.Windows.Input.Key.LaunchApplication1:
                    break;
                case System.Windows.Input.Key.LaunchApplication2:
                    break;
                case System.Windows.Input.Key.Oem1:
                    break;
                //case System.Windows.Input.Key.OemSemicolon:
                //    break;
                case System.Windows.Input.Key.OemPlus:
                    break;
                case System.Windows.Input.Key.OemComma:
                    break;
                case System.Windows.Input.Key.OemMinus:
                    break;
                case System.Windows.Input.Key.OemPeriod:
                    break;
                case System.Windows.Input.Key.Oem2:
                    break;
                //case System.Windows.Input.Key.OemQuestion:
                //    break;
                case System.Windows.Input.Key.Oem3:
                    break;
                //case System.Windows.Input.Key.OemTilde:
                //    break;
                case System.Windows.Input.Key.AbntC1:
                    break;
                case System.Windows.Input.Key.AbntC2:
                    break;
                case System.Windows.Input.Key.Oem4:
                    break;
                //case System.Windows.Input.Key.OemOpenBrackets:
                //    break;
                case System.Windows.Input.Key.Oem5:
                    break;
                //case System.Windows.Input.Key.OemPipe:
                //    break;
                case System.Windows.Input.Key.Oem6:
                    break;
                //case System.Windows.Input.Key.OemCloseBrackets:
                //    break;
                case System.Windows.Input.Key.Oem7:
                    break;
                //case System.Windows.Input.Key.OemQuotes:
                //    break;
                case System.Windows.Input.Key.Oem8:
                    break;
                case System.Windows.Input.Key.Oem102:
                    break;
                //case System.Windows.Input.Key.OemBackslash:
                //    break;
                case System.Windows.Input.Key.ImeProcessed:
                    break;
                case System.Windows.Input.Key.System:
                    break;
                case System.Windows.Input.Key.OemAttn:
                    break;
                //case System.Windows.Input.Key.DbeAlphanumeric:
                //    break;
                case System.Windows.Input.Key.OemFinish:
                    break;
                //case System.Windows.Input.Key.DbeKatakana:
                //    break;
                case System.Windows.Input.Key.OemCopy:
                    break;
                //case System.Windows.Input.Key.DbeHiragana:
                //    break;
                case System.Windows.Input.Key.OemAuto:
                    break;
                //case System.Windows.Input.Key.DbeSbcsChar:
                //    break;
                case System.Windows.Input.Key.OemEnlw:
                    break;
                //case System.Windows.Input.Key.DbeDbcsChar:
                //    break;
                case System.Windows.Input.Key.OemBackTab:
                    break;
                //case System.Windows.Input.Key.DbeRoman:
                //    break;
                case System.Windows.Input.Key.Attn:
                    break;
                //case System.Windows.Input.Key.DbeNoRoman:
                //    break;
                case System.Windows.Input.Key.CrSel:
                    break;
                //case System.Windows.Input.Key.DbeEnterWordRegisterMode:
                //    break;
                case System.Windows.Input.Key.ExSel:
                    break;
                //case System.Windows.Input.Key.DbeEnterImeConfigureMode:
                //    break;
                case System.Windows.Input.Key.EraseEof:
                    break;
                //case System.Windows.Input.Key.DbeFlushString:
                //    break;
                case System.Windows.Input.Key.Play:
                    break;
                //case System.Windows.Input.Key.DbeCodeInput:
                //    break;
                case System.Windows.Input.Key.Zoom:
                    break;
                //case System.Windows.Input.Key.DbeNoCodeInput:
                //    break;
                case System.Windows.Input.Key.NoName:
                    break;
                //case System.Windows.Input.Key.DbeDetermineString:
                //    break;
                case System.Windows.Input.Key.Pa1:
                    break;
                //case System.Windows.Input.Key.DbeEnterDialogConversionMode:
                //    break;
                case System.Windows.Input.Key.OemClear:
                    break;
                case System.Windows.Input.Key.DeadCharProcessed:
                    break;
                default:
                    break;
            }
        }
    }
}