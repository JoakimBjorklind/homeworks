namespace Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ChangeHistory
    {
        private List<int> history;

        public ChangeHistory()
        {
            this.history = new List<int>();
        }

        public void Add(int status)
        {
            this.history.Add(status);
        }

        public void Clear()
        {
            this.history.Clear();
        }

        public int MaxValue()
        {
          // found this way to get Max value from stackoverflow, added the using System.Linq;
            int Max = this.history.Max();
            if (this.history.Count > 0)
            {
                Max = this.history.Max();
            }
            return Max;





        }

        public int MinValue()
        {
            int Min = this.history.Min();
            if (this.history.Count > 0)
            {
                Min = this.history.Min();
            }
            return Min;

        }
        public override string ToString()
        {
          // found from stackoverflow how to get the last index of a list. .LastOrDefault() works also
            return "Current: " + this.history.Last() + " Min: " + MinValue() + " Max: " + MaxValue();
        }
    }
}
