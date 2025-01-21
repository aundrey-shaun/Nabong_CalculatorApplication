using System.Reflection;
using Nabong_CalculatorApplication.Calculator.Operations;

namespace Nabong_CalculatorApplication.Calculator
{
    internal class Program
    {
        // Declate the list of Hizztory
        private static List<string> History_calc = new List<string>();
        static void Main(string[] args)
        {
            bool calculate_cont = true;

            while (calculate_cont)
            {
                try
                {
                    DisplayMenu();

                    int operation_choice = UserOperation();

                    if (operation_choice == 7)
                    {
                        ShowHistory();
                        continue;
                    }

                    else if (operation_choice == 8)
                    {
                        Console.Clear();
                        calculate_cont = false;
                        Console.WriteLine("\n\n\nSalamat na lang sa lahat ha.\n\n\n");
                        continue;
                    }

                    Calculator calc = CreateCalc(operation_choice);
                    if (calc != null)
                    {
                        SolveCalc(calc);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error!: {ex.Message}");
                }

                Console.WriteLine("\n\nPress Any Key To Continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void DisplayMenu()
        {
            // Starting Code, Welcome
            Console.Clear();
            Console.WriteLine("Welcome to Sean's Calculator");

            // Show Operations
            Console.WriteLine("Calculator Menu:");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n");
            Console.WriteLine("More: ");
            Console.WriteLine("5. Power\n6. Remainder\n7. History\n8. Exit");

            Console.Write("\nSelect an Operation from 1 to 8: ");
        }

        private static int UserOperation()
        {
            int user_option;
            while (!int.TryParse(Console.ReadLine(), out user_option) || user_option < 1 || user_option > 8)
            {
                Console.Write("Invalid input. Please enter a number from 1 to 8: ");
            }

            return user_option;
        }

        private static Calculator CreateCalc(int user_option)
        {

            switch (user_option)
            {
                case 1: return new Addition();
                case 2: return new Subtraction();
                case 3: return new Multiplication();
                case 4: return new Division();
                case 5: return new Power();
                case 6: return new Remainder();
                default: return null;
            }
        }

        private static void SolveCalc(Calculator calc)
        {
            Console.Write("Enter first number: ");
            calc.Num_One = NumInput();

            Console.Write("Enter second number: ");
            calc.Num_Two = NumInput();

            string result = calc.DisplayOperation();
            Console.WriteLine($"Result: {result}");
            History_calc.Add(result);
        }

        private static double NumInput()
        {
            double num_input;
            while (!double.TryParse(Console.ReadLine(), out num_input))
            {
                Console.Write("Invalid input. Try Again: ");
            }

            return num_input;
        }

        private static void ShowHistory()
        {
            Console.Clear();
            Console.WriteLine("Calculation Hizztory");

            if (History_calc.Count == 0)
            {
                Console.WriteLine("No Hizztory");
            }
            else
            {
                foreach (string history in History_calc)
                {
                    Console.WriteLine(history);
                }
            }

            Console.WriteLine("\n\nPress Any Key To Continue...");
            Console.ReadKey();
        }
    }
}
