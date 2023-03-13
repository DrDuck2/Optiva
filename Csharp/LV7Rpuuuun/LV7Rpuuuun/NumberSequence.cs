using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public class NumberSequence
    {
        private double[] sequence;
        private int sequenceSize;
        private SortStrategy sortStrategy;
        private SearchStrategy searchStrategy;
        public NumberSequence(int sequenceSize)
        {
            this.sequenceSize = sequenceSize;
            this.sequence = new double[sequenceSize];
        }
        public NumberSequence(double[] array) : this(array.Length)
        {
            array.CopyTo(this.sequence, 0);
        }
        public void InsertAt(int index, double value)
        {
            this.sequence[index] = value;
        }
        public void SetSortStrategy(SortStrategy strategy)
        {
            this.sortStrategy = strategy;
        }

        public void SetSearchStrategy(SearchStrategy strategy)
        {
            this.searchStrategy = strategy;
        }
        public void Sort() { this.sortStrategy.Sort(this.sequence); }
        public bool Search(double searchItem) { return this.searchStrategy.Search(this.sequence, searchItem); }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (double element in this.sequence)
            {
                builder.Append(element).Append(Environment.NewLine);
            }
            return builder.ToString();
        }
    }
}
