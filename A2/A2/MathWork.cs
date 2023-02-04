using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public class MathWork
    {


        public void Start()
        {
            PrintMultiplicationTable();
            Calculate();
        }

        private void PrintMultiplicationTable()
        {
            Console.WriteLine("                 **************** Multiplication Table ****************             ");

            for(short row = 1; row <= 12; row++) 
            {
                for(short column = 1; column <= 12;column++)
                    Console.Write(row * column + "\t");

                Console.Write("\n");
            }
        }

        public void Calculate()
        {
            bool done = false;

            do
            {
                int sum = 0;

                Console.WriteLine("\nSum of numbers between two numbers\n");
                Console.WriteLine("Note! First number has to be lower than second for correct calculations!\n");
                int s_num = startNumber();
                int e_num = endNumber();

                sum = SumNumbers(s_num, e_num);

                /* Display Sum */
                Console.WriteLine($"\nThe sum of numbers between {s_num} and {e_num} is: {sum}\n");

                /* Print Even and Odd Numbers */
                PrintEvenAndOddNumbers(s_num, e_num);

                /* Square Root of numbers in range */
                CalculateSquareRoots(s_num, e_num);

                done = ExitCalculation();

            } while (!done);
            
        }

        private int SumNumbers(int startNum, int endNum)
        {
            int sum = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                sum += i;
            }

            return sum;
        }

        private void PrintEvenAndOddNumbers(int number1, int number2)
        {
            int count = 0;
            List<int> odd_num = new List<int>();

            Console.WriteLine($"****Even numbers between {number1} and {number2}");

            for (int i = number1; i <= number2; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write($"{i} \t\t");
                    count++;
                }
                else
                    odd_num.Add(i);

                if (count == 8)
                {
                    count = 0;
                    Console.Write("\n");
                }

            }


            Console.WriteLine($"\n\n****Odd numbers between {number1} and {number2}");

            count = 0;

            for (int i = 0; i < odd_num.Count; i++)
            {
                count++;
                Console.Write($"{odd_num[i]} \t");

                if (count == 8)
                {
                    count = 0;
                    Console.Write("\n");
                }
            }

        }

        private int startNumber()
        {
            Console.Write("Enter first number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private int endNumber()
        {
            Console.Write("\nGive end number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private bool ExitCalculation()
        {
            Console.WriteLine("\n***********************\n" +
                "Exit Math Work? (y/n)");
            string? var = Console.ReadLine();

            return (var == "y" || var == "Y" || var == "Yes" || var == "YES");
        }

        private void CalculateSquareRoots(int num1, int num2)
        {
            Console.WriteLine("\n\n     ************ Square Roots ************");

            for (int i = num1; i <= num2; i++)
            {

                Console.Write("\nSqrt({0,2} to {1}): ",i, num2);

                for (int j = i; j <= num2; j++)
                {
                    Console.Write($"{Math.Sqrt(j):0.00}\t");

                    if (j == num2)
                        Console.Write("\n");
                }
            }
        }
    }
}
