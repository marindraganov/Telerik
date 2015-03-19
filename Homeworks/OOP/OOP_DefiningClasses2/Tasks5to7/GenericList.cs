namespace Tasks5to7
{
    using System;
    using System.Text;

    public class GenericList<T>
        where T : IComparable<T>
    {
        private const int InitialSize = 8;

        private T[] data;
        private int count;

        public GenericList()
        {
            this.data = new T[InitialSize];
            this.count = 0;
        }

        public GenericList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("List capacity must be positive integer number greater than 0!");
            }

            this.data = new T[capacity];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            private set
            {
                this.count = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public void AddElement(T element)
        {
            if (this.Capacity == this.Count)
            {
                this.ResizeData();
            }

            this.Count++;
            this.data[this.Count - 1] = element;
        }

        public void InsertAt(int index, T element)
        {
            if (this.Capacity == this.Count)
            {
                this.ResizeData();
            }

            for (int i = this.Count; i > index; i--)
            {
                this.data[i] = this.data[i - 1];
            }

            this.data[index] = element;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException("Unexisting index!");
            }

            T removedElement = this.data[index];

            for (int i = index; i < this.Count - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.Count--;

            return removedElement;
        }

        public void Clear()
        {
            this.data = new T[InitialSize];
            this.Count = 0;
        }

        public T Min()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("You can not call Min<T> method on emty list");
            }

            T min = this.data[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (this.data[i].CompareTo(min) < 0)
                {
                    min = this.data[i];
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("You can not call Min<T> method on emty list");
            }

            T max = this.data[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (this.data[i].CompareTo(max) > 0)
                {
                    max = this.data[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return "The list is empty";
            }

            StringBuilder listAsString = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                listAsString.Append(this.data[i]);
                listAsString.Append(", ");
            }

            return listAsString.ToString();
        }

        private void ResizeData()
        {
            int newCapacity = this.Capacity * 2;
            T[] newData = new T[newCapacity];

            for (int i = 0; i < this.Count; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }
    }
}
