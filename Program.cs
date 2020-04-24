using System;

namespace first_csharp_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //if statement
            int number1 = 10;
            int number2 = 20;
            if (number2 > number1)
            {
                Console.WriteLine("number2 is greater than number1.");
            }
            //if else statement
            int n = 15;
            if (n < 10)
            {
                Console.WriteLine("n is less than 10");
            }
            else if (n < 20)
            {
                Console.WriteLine("n is less than 20");
            }
            else if (n < 30)
            {
                Console.WriteLine("n is less than 30");
            }
            else
            {
                Console.WriteLine("n is greater than or equal to 30");
            }
            //switch statement
            int op1 = 5;
            int op2 = 5;
            char opr = '*';
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unknown Operator");
                    return;
            }
            Console.WriteLine("Result: {0}", result);
            //while statement
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("i is equal to " + i);
                i++;
            }
            //do while statement
            i = 1;
            do
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
            while (i <= 5);
            //for statement
            for (int y = 1; y <= 5; y++)
            {
                Console.WriteLine("The value of y = {0}", y);
            }
            //for each statement
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int w in numbers)
            {
                Console.WriteLine("The value of w = {0}", w);
            }
        }
    }
}
