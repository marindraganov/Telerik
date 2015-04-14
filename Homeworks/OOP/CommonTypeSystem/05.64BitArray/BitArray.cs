namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray : IEnumerable<int>, IComparable
    {
        public BitArray(ulong number)
        {
            this.Number = number;
        }

        public ulong Number { get; private set; }

        public int Length
        {
            get
            {
                return 64;
            }
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= this.Length)
                {
                    throw new IndexOutOfRangeException(string.Format("Use index in range [0, {0}]", this.Length - 1));
                }

                return (int)(this.Number >> pos) & 1;
            }

            set
            {
                if (pos < 0 || pos >= this.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("You can set only '0' and '1' values for the array elements!");
                }

                if (((int)(this.Number >> pos) & 1) != value)
                {
                    this.Number ^= 1ul << pos;
                }
            }
        }

        public static bool operator ==(BitArray bitArray1, BitArray bitArray2)
        {
            return bitArray1.Equals(bitArray2);
        }

        public static bool operator !=(BitArray bitArray1, BitArray bitArray2)
        {
            return !bitArray1.Equals(bitArray2);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int pos = 0; pos < 64; pos++)
            {
                result.Insert(0, (this.Number >> pos) & 1);
            }

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray).Number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return this.Number.CompareTo((obj as BitArray).Number);
        }
    }
}
