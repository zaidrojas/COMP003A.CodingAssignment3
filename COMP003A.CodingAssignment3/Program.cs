/*
* [Zaid Rojas]
* COMP-003A
* Faculty: Jonnathan Cruz
* Purpose: Budget management application demonstrating control flow
*/

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize Variables
            double income = 0;
            string[] expenses_name = new string[50]; 
            double[] expenses_costs = new double[50]; 
            int expense_list_len = 0;
            double expense_total = 0;

            while (true)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Welcome to the Budget Management Tool!");
                Console.Write("\nEnter your monthly income: ");

                // Input validation
                if (!double.TryParse(Console.ReadLine(), out income))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

            MainMenu:
                // Main Menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Your Choice: ");
                int option;

                // Input validation
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                // Handle The Selection From Menu
                switch (option)
                {
                    case 1: // Add Expense
                        Console.Write("Enter the expense name: ");
                        string cur_expense_name = Console.ReadLine().ToLower();

                        Console.Write("Enter the expense amount: ");
                        double cur_expense_cost;
                        if (!double.TryParse(Console.ReadLine(), out cur_expense_cost))
                        {
                            Console.WriteLine("Invalid input for expense amount. Please enter a valid number.");
                            continue;
                        }

                        expenses_name[expense_list_len] = cur_expense_name;
                        expenses_costs[expense_list_len] = cur_expense_cost;
                        expense_list_len++;
                        goto MainMenu;
                        break;

                    case 2: // View Expenses and Budget
                        Console.WriteLine("\nExpenses:");
                        expense_total = 0;
                        for (int i = 0; i < expense_list_len; i++)
                        {
                            expense_total += expenses_costs[i];
                            Console.WriteLine($"  - {expenses_name[i]}: ${expenses_costs[i]}");
                        }
                        Console.WriteLine($"Total Expenses: ${expense_total}");
                        Console.WriteLine($"Remaining Budget: ${income - expense_total}");
                        goto MainMenu;
                        break;

                    case 3: // Remove Expense (Not implemented in your original code)
                        if (expense_list_len == 0)
                        {
                            Console.WriteLine("No Expenses to Remove Yet");
                            goto MainMenu;
                            break;
                        }
                        string remove_expense;
                        Console.Write("\nEnter the name of the expense to remove: ");
                        remove_expense = Console.ReadLine().ToLower();
                        for (int i = 0; i < expense_list_len; i++)
                        {
                            if (expenses_name[i] == remove_expense)
                            {
                                expenses_name[expense_list_len - 1] = null;
                                expenses_costs[expense_list_len - 1] = 0;
                                expense_list_len--;
                            }
                        }
                        Console.WriteLine("Expense Removed!");
                        goto MainMenu;
                        break;

                    case 4: // Exit
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Options are integers 1, 2, 3, and 4.");
                        goto MainMenu;
                        break;
                }
            }
        }
    }
}
