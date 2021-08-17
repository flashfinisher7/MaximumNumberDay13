using System;

namespace FindMaximumNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \tFinding Maximum Number : ");
            int[] intArray = { 66, 63, 44, 77, 88, 99 };
            Generic<int> generic = new Generic<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 26.4, 6.5, 44.3, 55.6, 77.4, 66.5 };
            Generic<double> generic1 = new Generic<double>(doubleArray);
            generic1.PrintMaxValue();

            string[] stringArray = { "Apple", "Banana", "Peach", "Orange", "Grapes", "Kiwi" };
            Generic<string> generic2 = new Generic<string>(stringArray);
            generic2.PrintMaxValue();
            Console.ReadLine();
        }
    }
}
