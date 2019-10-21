using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.MathEx
{
    public class Term
    {
        public ObservableCollection<ObservableCollection<sbyte>> DigitGroups { get; set; }
        public ObservableCollection<sbyte> DigitGroup { get; set; }
        public ObservableCollection<int> Numbers { get; private set; }
        public int Number { get; set; }
        public ObservableCollection<int> Results { get; private set; }
        public string OperatorSign { get; set; }

        public Term()
        {
            DigitGroup = new ObservableCollection<sbyte>();
            DigitGroup.CollectionChanged += DigitGroup_CollectionChanged;

            DigitGroups = new ObservableCollection<ObservableCollection<sbyte>>
            {
                DigitGroup
            };

            DigitGroups.CollectionChanged += DigitGroups_CollectionChanged;
            
            Numbers = new ObservableCollection<int>();
            Numbers.CollectionChanged += Numbers_CollectionChanged;
        }

        public Term(sbyte digit) : this() 
        {
            DigitGroup.Add(digit);
        }

        public Term(sbyte digit, char operatorSign) : this(digit)
        {
            OperatorSign = operatorSign.ToString();
        }

        void BuildInteger()
        {
            Number = 0;

            foreach (var digit in DigitGroup)
            {
                Number += digit;
                Number *= 10;
            }

            Number /= 10;
        }

        private void DigitGroups_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            int index = e.NewStartingIndex;

            DigitGroup = DigitGroups[index];
            //Number = Numbers[index];
        }

        void DigitGroup_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            BuildInteger();

            if(true)
            {
                //DigitGroup = null;
                //Number = Numbers[0];
            }
        }

        private void Numbers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Number = 0;
        }
    }
}
