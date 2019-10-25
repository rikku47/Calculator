using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Calculator.MathEx
{
    public class Term : INotifyPropertyChanged
    {
        #region Getter and Setter
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
        public ObservableCollection<int> NumbersOfInteger { get; private set; }
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

        private static int _indexOfIntegerList = 1;
        #endregion

        #region Constructors
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

            NumbersOfInteger = new ObservableCollection<int>
            {
                BuildInteger()
            };

            NumbersOfInteger.CollectionChanged += Numbers_CollectionChanged;

            Results = new ObservableCollection<int>
            {
                0
            };
        }
        public Term(sbyte digit) : this()
        {
            _digitGroup.Add(digit);
        }
        public Term(sbyte digit, char operatorSign) : this(digit)
        {
            OperatorSign = operatorSign;
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        int BuildInteger()
        {
            int tempInteger = 0;

            foreach (var digit in _digitGroup)
            {
                tempInteger += digit;
                tempInteger *= 10;
            }

            return Number /= 10;
        }
        private void DigitGroups_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            int index = e.NewStartingIndex;

            _digitGroup = DigitGroups[index];
            _indexOfIntegerList = index;
        }
        void DigitGroup_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NumbersOfInteger[_indexOfIntegerList] = BuildInteger();
        }
        private void Numbers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Number = 0;
        }
        private void Changed(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
