using System;


namespace LatihanOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object dari class numbers
            Numbers number = new Numbers();

            Console.WriteLine("Nilai Minimum #1 : {0}", number.FindMinimum(3, 1));
            Console.WriteLine("Nilai Minimum #2 : {0}", number.FindMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Nilai Maximum #1 : {0}", number.FindMaximum(3, 1));
            Console.WriteLine("Nilai Maximum #2 : {0}", number.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
