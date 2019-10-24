using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.MathEx
{
    public class Term : INotifyPropertyChanged
    {

        private char _operator;
        private char _valueOperator;
        private ObservableCollection<sbyte> _digitGroup;

        public ObservableCollection<ObservableCollection<sbyte>> DigitGroups { get; set; }

        public ObservableCollection<sbyte> DigitGroup
        {
            get
            {
                return _digitGroup;

            }
            set
            {
                _digitGroup = value;
            }
        }

        public ObservableCollection<int> Numbers { get; private set; }
        public int Number { get; set; }
        public ObservableCollection<int> Results { get; private set; }

        public char OperatorSign
        {
            get
            {
                return _operator;
            }
            set
            {
                _operator = value;
                Changed(nameof(OperatorSign));
            }
        }

        public char ValueOperator { get => _valueOperator; set => _valueOperator = value; }

        public Term()
        {
            _digitGroup = new ObservableCollection<sbyte>
            {
                0
            };

            _digitGroup.CollectionChanged += DigitGroup_CollectionChanged;

            DigitGroups = new ObservableCollection<ObservableCollection<sbyte>>
            {
                _digitGroup
            };

            DigitGroups.CollectionChanged += DigitGroups_CollectionChanged;

            Numbers = new ObservableCollection<int>();
            Numbers.CollectionChanged += Numbers_CollectionChanged;
        }

        public Term(sbyte digit) : this()
        {
            _digitGroup.Add(digit);
        }

        public Term(sbyte digit, char operatorSign) : this(digit)
        {
            OperatorSign = operatorSign;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void BuildInteger()
        {
            Number = 0;

            foreach (var digit in _digitGroup)
            {
                Number += digit;
                Number *= 10;
            }

            Number /= 10;
        }

        private void DigitGroups_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            int index = e.NewStartingIndex;

            _digitGroup = DigitGroups[index];
            //Number = Numbers[index];
        }

        void DigitGroup_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            BuildInteger();

            if (true)
            {
                //DigitGroup = null;
                //Number = Numbers[0];
            }
        }

        private void Numbers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Number = 0;
        }

        private void Changed(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
