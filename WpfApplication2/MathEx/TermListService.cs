using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.MathEx
{
    public class TermListService
    {
        public Term Term { get; set; }

        public ObservableCollection<Term> Terms { get; }

        public TermListService()
        {
            Terms = new ObservableCollection<Term>
            {
                new Term()
            };

            Terms.CollectionChanged += Terms_CollectionChanged;

            Term = new Term();
            Terms.Add(Term);
        }

        private void Terms_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Term = Terms[e.NewStartingIndex];
        }
    }
}
