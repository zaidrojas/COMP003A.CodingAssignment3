/*
* [Zaid Rojas]
* COMP-003A
* Faculty: Jonnathan Cruz
* Purpose: Budget management application demonstrating control flow
*/

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialized Variables
            int option;
            double income;
            //

            Console.WriteLine("Welcome to the Budget Management Tool!");
            Console.Write("\nEnter your monthly income: ");
            income = double.Parse(Console.ReadLine());
        }
    }
}
