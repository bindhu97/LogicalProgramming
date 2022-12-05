using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class CouponNumber
    {
        public void coupon(int v)
        {
            Console.Write("Check Coupon number");
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
            int max = 100000000;

            int random = (v);
            StringBuilder sb = new StringBuilder();
            random = int.Parse(Console.ReadLine());


            while (random > 0)
            {
                sb.Append(chars[random % chars.Length]);
                random /= chars.Length;
            }
            String couponCode = sb.ToString();
            Console.WriteLine("Coupon Code: " + couponCode);
        }

        internal void coupon()
        {
            throw new NotImplementedException();
        }
    }
}
