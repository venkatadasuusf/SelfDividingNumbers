using System;

namespace SelfDividingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter starting range: ");

            string input_starting_range = Console.ReadLine();
            int value_of_starting_range = int.Parse(input_starting_range);


            Console.Write("Please enter ending range: ");

            string input_ending_range = Console.ReadLine();
            int value_of_ending_range = int.Parse(input_ending_range);
            Console.WriteLine("");

            printSelfDividingNumbers(value_of_starting_range, value_of_ending_range);
            
        }

        public static void printSelfDividingNumbers(int starting_range, int ending_range)
        {
            int self_divide_indicator = 1;

            Console.WriteLine("The self-dividing numbers between " + starting_range + " and " + ending_range + " are: ");

            for (int i = starting_range; i <= ending_range; i++)
            {
                self_divide_indicator = isSelfDividing(i);
                if (self_divide_indicator == 1 && i != 0)
                {
                    Console.Write(i + ", ");
                }

            }
            Console.WriteLine("");
        }

        public static int isSelfDividing(int current_number)
        {
            int current_digit = 0;
            int self_divide = 1;
            int number_for_digits = current_number;

            while (number_for_digits > 0 && self_divide == 1)
            {
                if (number_for_digits > 9)
                {
                    current_digit = number_for_digits % 10;
                }
                else
                {
                    current_digit = number_for_digits;
                }

                if (current_digit > 0)
                {
                    if (current_number % current_digit == 0)
                    {
                        self_divide = 1;
                    }
                    else
                    {
                        self_divide = 0;

                    }
                }
                else
                {
                    self_divide = 0;

                }

                number_for_digits = number_for_digits / 10;
            }

            return self_divide;

        }
    }
}
