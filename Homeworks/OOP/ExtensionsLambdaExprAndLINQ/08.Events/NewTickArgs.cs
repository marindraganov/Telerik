namespace _08.Events
{
    using System;

    public class NewTickArgs : EventArgs
    {
        public NewTickArgs(int count, int intervalSec)
        {
            this.Count = count;
            this.IntervalSec = intervalSec;
        }

        public int Count { get; private set; }

        public int IntervalSec { get; private set; }
    }
}
