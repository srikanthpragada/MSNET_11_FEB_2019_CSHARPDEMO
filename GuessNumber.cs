using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class GuessNumber
    {
        static void Main(string[] args)
        {
            int number;

            Random r = new Random();
            number = r.Next(25);
            // Console.WriteLine(number);


            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Guess Number : ");
                int n = Int32.Parse(Console.ReadLine());

                if (n == number)
                {
                    Console.WriteLine("Congratulation! You have done it!");
                    return;  // Stop program 
                }

                // Show hint for first two attempts
                if (i < 3)
                {
                    if (n < number)
                        Console.WriteLine("Bigger than what you entered!");
                    else
                        Console.WriteLine("Smaller than what you entered!");
                }
            }
            // Attempts are over
            Console.WriteLine("Sorry! Better luck next time!");
        }
    }
}
