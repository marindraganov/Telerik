namespace _03.RangeException
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string msg)
            : base(msg)
        {
        }

        public InvalidRangeException(T startLimit, T endLimit)
            : this(string.Format("The argument value must be in the range [{0}...{1}]!", startLimit, endLimit))
        {
            this.Start = startLimit;
            this.End = endLimit;
        }

        public T Start { get; private set; }

        public T End { get; private set; }
    }
}
