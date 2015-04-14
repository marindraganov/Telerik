namespace _05._64BitArray
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {
            BitArray bitArray1 = new BitArray(200);
            BitArray bitArray2 = new BitArray(550);

            Console.WriteLine(bitArray1);
            bitArray1[0] = 1;
            Console.WriteLine(bitArray1);
            Console.WriteLine("bitArray1 equals bitArray2 {0}", bitArray1.Equals(bitArray2));
            Console.WriteLine("bitArray1 == bitArray2 {0}", bitArray1 == bitArray2);

            // test IEnumerable
            foreach (var item in bitArray1)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}