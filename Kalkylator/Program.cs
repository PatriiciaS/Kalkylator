using System;
using System.Collections.Generic;
namespace Kalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            double result;
            string operators;

            //Create a list to save your calculations
            List<string> calculations = new List<string>();

            //Input: Name
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nWelcome " + name);


            //Input: Enter two numbers
            {
                Console.WriteLine("\nEnter two numbers: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
            }

            //Input: Chose operator and run operation
            Console.WriteLine("\nChose operator to proceed with your calculation: ");
            operators = (Console.ReadLine());

            result = number1 + number2;

            if (operators == "+")
            {
                Console.WriteLine("{0} + {1} = {2}", number1, number2, (number1 + number2));
                calculations.Add(string.Format("{0} + {1} = {2}", number1, number2, number1 + number2));
            }

            else if (operators == "-")
            {
                Console.WriteLine("{0} - {1} = {2}", number1, number2, (number1 - number2));
                calculations.Add(string.Format("{0} - {1} = {2}", number1, number2, number1 - number2));
            }

            else if (operators == "*")
            {
                Console.WriteLine("{0} * {1} = {2}", number1, number2, (number1 * number2));
                calculations.Add(string.Format("{0} * {1} = {2}", number1, number2, number1 * number2));
            }

            else if (operators == "/")
            {
                Console.WriteLine("{0} / {1} = {2}", number1, number2, ((double)number1 / (double)number2));
                calculations.Add(string.Format("{0} / {1} = {2}", number1, number2, (double)number1 / (double)number2));
            }

            else
            {
                Console.WriteLine("Invalid input.");
            }
            //View previous calculation

            char choice1;
            bool runAgain = true;
            Console.WriteLine("Would you like to see your previous calculation? Type Y for yes or N for no. ", 'Y' / 'N');
            choice1 = Convert.ToChar(Console.ReadLine());

            {
                if (choice1 == 'Y')

                    foreach (string item in calculations)
                    {
                        Console.WriteLine("The result of your previous calculation is: {0}", item);

                    }

                else if (choice1 == 'N')
                {
                    runAgain = false;
                }

            }


            //Chose one of the following options in the menu below.

            string usersChoice = " ";
            Console.WriteLine("\nIn the next step you will be able to proceed with a new calculation. ");
            Console.WriteLine("If you don't wish to calculate, just end the program.\n");

            while (usersChoice != "3")
            {
                Console.WriteLine("Chose one of the following options: \n");
                Console.WriteLine("\t1. Add two numbers");
                Console.WriteLine("\t2. Multiply two numbers");
                Console.WriteLine("\t3. Finish program");

                usersChoice = Console.ReadLine();

                //Procees with the users choice.
                switch (usersChoice)
                {

                    case "1":
                        Console.WriteLine("\nEnter two numbers: ");
                        double num1 = double.Parse(Console.ReadLine());
                        double num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;

                    case "2":
                        Console.WriteLine("\nEnter two numbers: ");
                        double num3 = double.Parse(Console.ReadLine());
                        double num4 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{num3}*{num4} = {num3 * num4}");
                        break;

                    case "3":
                        Console.WriteLine("The program will end. ");
                        break;

                    default:
                        Console.WriteLine("Invalid option. ");
                        break;


                }


            }




        }

    }
}