namespace Tasks5to7
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {
            GenericList<char> list = new GenericList<char>();

            Console.WriteLine("Elements count of the new list: {0}", list.Count);
            Console.WriteLine();

            int firstLetterIndex = 97;

            for (int i = 0; i < 8; i++)
            {
                list.AddElement((char)(i + firstLetterIndex));
            }
            
            Console.WriteLine(list);
            Console.WriteLine("List capacity: {0}", list.Capacity);
            Console.WriteLine("----------------");

            list.RemoveAt(0);
            Console.WriteLine(list);
            Console.WriteLine("----------------");

            list.InsertAt(3, 'z');

            // list.AddElement('z');
            list.InsertAt(3, 'y');
            Console.WriteLine(list);
            Console.WriteLine("List count: {0}", list.Count);
            Console.WriteLine("List capacity(doubled): {0}", list.Capacity);
            Console.WriteLine("----------------");

            Console.WriteLine("The minimal element in the list: {0}", list.Min());
            Console.WriteLine("The maximal element in the list: {0}", list.Max());
            Console.WriteLine("----------------");

            list.Clear();
            Console.WriteLine(list);
        }
    }
}
