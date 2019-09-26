using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Program
    {
        static void Main(string[] args)
        {

            Xuat(-7);
            Console.WriteLine("gia tri cua so {0} mu {1} la {2} ",3,5,pow(3 , 5));
            Console.WriteLine(" ABs of {0} la {1}", -5, ABS(-5));
            Console.WriteLine("ceil lam tron cua sua {0} la {1}", 3.5, ceil(3.5f));          
        }
        public static bool IsOdd(int n)
        {
            return n % 2 == 1;
        }
        public static bool IsPrime(int n)
        {
            if( n < 2 )
            {
                return false;
            }
            int j = 0;
            for (int i =1 ; i <= n; i++)
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

            Console.WriteLine("can bat 2 cua {0} la {1}", n , Square(n));
            Console.WriteLine("can bat 3 cua {0} la {1}", n, Cube(n));

        }
        static int Square(int n)
        {
            int c;
            return c = n*n;
        }
        static int Cube(int n)
        {
            int c;
            return c = n * n * n;
        }
        static int pow(int x , int y)
        {
            int a =1;
            for (int i=0; i<y ; i++)
            {
                a = a * x;
            }
            return a;
        }
        static int ABS(int x)
        {
            if (x > 0)
                return x;
            else
                return -x;
        }
        static int ceil(float a)
        { 
            int x; //phan nguyen
                x = (int)a;
            int n;
            if (a >= x + 0.5)
            {
                return n = x + 1;
            }
            else
                return n = x;

        }
    }
}
