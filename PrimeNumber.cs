using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Check_Prime(number);
            if (result == 0)
            {
                Console.WriteLine("{0} is not a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is  a prime number", number);
            }
            Console.Read();
        }

        private static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }
    }
}
