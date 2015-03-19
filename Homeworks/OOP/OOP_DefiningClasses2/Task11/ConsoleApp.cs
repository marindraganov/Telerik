namespace Task11
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {   
            PrintVersionInfo(typeof(Sample));
        }

        private static void PrintVersionInfo(System.Type t)
        {
            // Using reflection.
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);

            // Displaying output. 
            foreach (System.Attribute attr in attrs)
            {
                if (attr is Version)
                {
                    Version v = (Version)attr;
                    System.Console.WriteLine("version {0}.{1}", v.Major, v.Minor);
                }
            }
        }
    }
}
