namespace _01_03.Student
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {
            Student pesho = new Student(
                "Pesho",
                "Petrov",
                "Petrov",
                13118090,
                "Sofia",
                "0882 122 122",
                "peso@abv.bg",
                EnumUniversity.UNWE,
                2,
                EnumFaculty.IT,
                EnumSpeciality.SoftwareEngineer);

            Student gosho = new Student(
                "Joro",
                "Georgiev",
                "Georgiev",
                13112066,
                "Sofia",
                "0882 211 211",
                "jorkata@abv.bg",
                EnumUniversity.SofiaUniversity,
                3,
                EnumFaculty.IT,
                EnumSpeciality.SoftwareEngineer);

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);        
            Console.WriteLine("pesho equals pesho: {0}", pesho.Equals(pesho));
            Console.WriteLine("pesho equals gosho: {0}", pesho.Equals(gosho));
            Console.WriteLine("pesho == gosho: {0}", pesho == gosho);
            Console.WriteLine("pesho != gosho: {0}", pesho != gosho);

            Student peshoCloning = pesho.Clone() as Student;
            pesho.FirstName = pesho.FirstName + "Renamed";

            Console.WriteLine();
            Console.WriteLine("Renamed Pesho: {0} ", pesho);
            Console.WriteLine("Cloned Pesho: {0} ", peshoCloning);
            Console.WriteLine("Pesho HashCode: {0}", pesho.GetHashCode());
            Console.WriteLine("Gosho HashCode: {0}", gosho.GetHashCode());
        }
    }
}
