using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo status;
            while (true)
            {
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                int ferdinand = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 1st input: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2nd input: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (ferdinand)
                {
                    case 1:
                        Console.WriteLine("The result is : " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("The result is: " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("The result is: " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("The result is : " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("INVALID! CHOOSSE FROM 1 TO 4 ONLY");
                        break;

                }
                Console.WriteLine("Do you want another (Y/y)");
                status = Console.ReadKey();

                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}
