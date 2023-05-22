namespace Exercise003
{
    using System;
    using System.Collections.Generic;

    public class ChangeHistory
    {
        private List<int> history;
        public ChangeHistory()
        {
            this.history = new List<int>();
        }
        public void Add(int status)
        {
            history.Add(status);
        }
        public void Clear()
        {
            history.Clear();
        }
        public int MaxValue()
        {
            if (history.Count == 0)
            {
                return 0;
            }
            else
            {
                int max = 0;

                foreach (int value in history)
                {
                    if (value > max)
                    {
                        max = value;
                    }
                }
                return max;
            }

        }

        public int MinValue()
        {
            if (history.Count == 0)
            {
                return 0;
            }
            else
            {
                int min = history[0];
                foreach (int value in history)
                {
                    if (value < min)
                    {
                        min = value;
                    }
                }
                return min;
            }

        }
        public override string ToString()
        {
            return "Current: " + history[history.Count - 1] + " Min: " + MinValue() + " Max: " + MaxValue();
        }
    }
}