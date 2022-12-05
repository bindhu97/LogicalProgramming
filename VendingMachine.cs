using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class VendingMachine
    {
        public void Vending()
        {
            int i = 0, total = 0;
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            long money;

            static int calculate(int money, int[] notes, int i, int total)
            {
                int rem, N;
                if (money == 0)
                {
                    return -1;
                }
                else
                {
                    if (money >= notes[i])
                    {
                        int calNotes = money / notes[i];
                        rem = money % notes[i];
                        money = rem;
                        total += calNotes;
                        Console.WriteLine(notes[i] + " Notes ---> " + calNotes);
                    }
                    i++;
                    return calculate(money, notes, i, total);
                }
            }
            static void main(String[] args, int total, int N, int[] notes, long money)
            {
                StringBuilder sb = new StringBuilder();
                Console.WriteLine("Enter the Amount:");
                money = Tuple.Create((int)Math.Ceiling('double i'), (int)Math.Floor(N / 1.0));

                VendingMachine.calculate((int)(long)int.Parse(Console.ReadLine()), notes);
                Console.WriteLine("Total Number of Notes are :" + total);
            }
        }

        private static void calculate(int money, int[] notes)
        {
            throw new NotImplementedException();
        }
    }
}
