namespace _02.IEnumExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            { 
                throw new InvalidOperationException("Collection is empty"); 
            }

            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0) 
            { 
                throw new InvalidOperationException("Collection is empty"); 
            }

            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic min = collection.First();

            foreach (var item in collection)
            {
                if (min > item) 
                { 
                    min = item; 
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0) 
            { 
                throw new InvalidOperationException("Collection is empty"); 
            }

            dynamic max = collection.First();

            foreach (var item in collection)
            {
                if (max < item) 
                { 
                    max = item; 
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0) 
            { 
                throw new InvalidOperationException("Collection is empty"); 
            }

            dynamic sum = collection.Sum();

            return sum / collection.Count();
        }

        public static string ExtendedToString<T>(this IEnumerable<T> collection)
        {
            StringBuilder elementsAsString = new StringBuilder();

            foreach (var item in collection)
            {
                elementsAsString.AppendFormat("{0}, ", item);
            }

            return elementsAsString.ToString();
        }
    }
}
