/*
* [Zaid Rojas]
* COMP-003A
* Faculty: Jonnathan Cruz
* Purpose: Budget management application demonstrating control flow
*/

using System.ComponentModel;

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {

                try
                {
                    int option;
                    double income;
                    string[] expense_name;
                    double[] expense_cost;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Welcome to the Budget Management Tool!");
                    Console.Write("\nEnter your monthly income: ");
                    income = double.Parse(Console.ReadLine());
                    if (income.GetType() != typeof(double))
                        throw new Exception("Input Must Be A Number");
                    break;


                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Add an Expense");
                    Console.WriteLine("2. View Expenses and Budget");
                    Console.WriteLine("3. Remove an Expense");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter Your Choice: ");
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid Input: {e.Message} Please Try Again!\n");
                }
            }

            /*
            switch(option)
            {
                case (1): // Add Expense
                    break;
                case (2): // View Expenses and Budget
                    break;
                case (3): // Remove Expense
                    break;
                case (4): // Exit
                    break;
                default:
                    Console.WriteLine("Kill Yourself Dumbass");
                    break;
            }
            */

            
            

        }
    }
}
