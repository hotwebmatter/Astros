/**
 * ######################################################
 * ##    Programming Assignment #9                     ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: November 03 2019              ##
 * ##    Purpose: Use sentinel loops with prime reads  ##
 * ######################################################
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// MessageBox did not work on my system:
// Visual Studio 2019 Reference Manager did not include Framework
// using System.Windows.Forms;

namespace Astros
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeTotal;
            double expenseTotal;
            double profit;

            Write(BuildHeader());
            incomeTotal = ReadIncome();
            expenseTotal = ReadExpense();
            profit = incomeTotal - expenseTotal;

            WriteLine("**************************************************\n");
            WriteLine("Total Income is {0:c}", incomeTotal);
            WriteLine("Total Expense is {0:c}", expenseTotal);
            if (profit < 0)
            {
                WriteLine("Total Profit is ({0:c})\n", -1 * profit);
            }
            else
            {
                WriteLine("Total Profit is {0:c}\n", profit);
            }

            if (incomeTotal > expenseTotal)
            {
                WriteLine("PROFIT\n");
                WriteLine("Astros made a profit!");
            }
            else if (expenseTotal > incomeTotal)
            {
                WriteLine("LOSS\n");
                WriteLine("Astros had a loss.");
            }
            else
            {
                WriteLine("Astros broke even.");
            }
            Read();
        }

        static double ReadIncome()
        {
            string inputValue;
            double number;
            double incomeTotal = 0;

            Write("Enter income (enter value or -99 to stop): ");
            inputValue = ReadLine();
            while (inputValue != "-99")
            {
                if (double.TryParse(inputValue, out number) == false)
                {
                    // Invalid input
                    WriteLine("Invalid input.");
                }
                else
                {
                    // Valid input
                    incomeTotal += number;
                } // end if
                Write("Enter income (enter value or -99 to stop): ");
                inputValue = ReadLine();
            } // end while
            return incomeTotal;
        }
        static double ReadExpense()
        {
            // This method is unneccessary. It's identical to the
            // ReadIncome() method above and they should be combined.
            // The only difference necessary is in the input dialog,
            // where the string 'income' or 'expense' could be passed
            // as an argument.
            // I made them separate because the problem specification
            // clearly directs me to do so.
            string inputValue;
            double number;
            double expenseTotal = 0;

            Write("Enter expense (enter value or -99 to stop): ");
            inputValue = ReadLine();
            while (inputValue != "-99")
            {
                if (double.TryParse(inputValue, out number) == false)
                {
                    // Invalid input
                    WriteLine("Invalid input.");
                }
                else
                {
                    // Valid input
                    expenseTotal += number;
                } // end if
                Write("Enter expense (enter value or -99 to stop): ");
                inputValue = ReadLine();
            } // end while
            return expenseTotal;

        }
        static string BuildHeader()
        {
            string result = string.Empty;
            result += string.Format("**************************************************\n");
            result += string.Format("\tAstros Statement\n");
            result += string.Format("\tCalculate profit or loss\n");
            result += string.Format("\tMatthew Obert\n");
            result += string.Format("\t{0}\n", DateTime.Now.ToString("MMMM dd yyyy"));
            result += string.Format("**************************************************\n");
            result += string.Format("This program will calculate profit or loss.\n\n");
            result += string.Format("Enter the company's income\n");
            result += string.Format("When finished with income, enter the company's expenses.\n\n");
            result += string.Format("**************************************************\n\n");

            return result;
        }
    }
}
