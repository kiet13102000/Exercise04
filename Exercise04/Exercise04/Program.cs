using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {

            Xuat(5);
        }
        static bool IsOdd(int n)
        {
            return n % 2 == 0 ? true : false;
        }
        static bool IsPrime(int n)
        {
            int j = 0;
            for (int i =1 ; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    j++;
                }
            }
            if (j == 2)
            {
                return true;
            }
            else 
                return false;
        }
        static void Xuat(int n)
        {
            if (IsOdd(n) == true)
            {
                Console.WriteLine("day la so chan");
            }
            else Console.WriteLine("day la so le ");
            if (IsPrime(n) == true)
            {
                Console.WriteLine(" day la SNT");
            }
            else Console.WriteLine("day khong phai la SNT");
        }
 
    }
}
