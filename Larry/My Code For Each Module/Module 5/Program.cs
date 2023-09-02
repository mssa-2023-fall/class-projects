using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {//build a constructor next
            int num1;
            int num2;
            string op;

            Console.WriteLine("Enter no1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation");
            op = Console.ReadLine();
            switch (op)
            {
                case "a":
                Console.WriteLine(num1 + num2);
                return;
                case "s":
                Console.WriteLine(num1 - num2);
                return;
                case "m":
                Console.WriteLine(num1 * num2);
                return;
                case "d":
                if (num1 == 0 || num2 == 0)
                {
                    try
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    catch(DivideByZeroException)
                    {
                        Console.WriteLine("Try a number other than 0");
                    }
                    finally
                    {
                        GC.Collect();
                    }

                }
                else
                {
                      Console.WriteLine(num1 / num2);

                }
                return;
                default:
                Console.WriteLine("Please try again");
                return;
            }
        }

    }
}

