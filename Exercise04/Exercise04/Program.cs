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

            Xuat(-5);
            Console.WriteLine("gia tri cua so {0} mu {1} la {2} ", 3, 5, pow(3, 5));
            Console.WriteLine(" ABs of {0} la {1}", -5, ABS(-5));
            Console.WriteLine("ceil lam tron cua sua {0} la {1}", -5.3, ceil(-5.3f));
            Console.WriteLine("floot lam tron cua so {0} la {1}", -5.6, floot(-5.6f));
            Console.WriteLine("so ramdom tu {0} den {1} la  {2}", 0, "(2^31)-1", rand1());
            Console.WriteLine("so random tu {0} den {1} la {2}", 0, 1, rand2());
            xet(-6);




            
            

           // Console.WriteLine(Math.Ceiling(3.4));
        }
        public static bool IsOdd(int n)
        {
            return n % 2 == 1;
        }
        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int j = 0;
            for (int i = 1; i <= n; i++)
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

            Console.WriteLine("can bat 2 cua {0} la {1}", n, Square(n));
            Console.WriteLine("can bat 3 cua {0} la {1}", n, Cube(n));

        }
        public static int Square(int n)
        {
            int c;
            return c = n * n;
        }
        public static int Cube(int n)
        {
            int c;
            return c = n * n * n;
        }
        public static int pow(int x, int y)
        {
            int a = 1;
            for (int i = 0; i < y; i++)
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
            if (x == a || a < 0)
            {
                return x;
            }
            else
            {
                return x + 1;
            }
        }
        static int floot( float a)
        {
            int x; //phan nguyen
            x = (int)a;
            if( a < 0)
            {
                Console.WriteLine("OK");
                return x - 1;
            }
            else
            {
                return x;
            }
        }
        static long rand1()
        {
            long a;
            return a = new Random().Next();
        }
        static double rand2()
        {
            double a;
            return a = new Random().NextDouble();
        }
        static long factorial(int n)
        {
         
           if (n<0)
           {
               return 0;
           }
            if (n == 0)
            {
                return 1;
            }
            else
            {
                long a = 1;
                for (int i = 1 ; i<=n ; i++)
                {
                 a *= i;
                }
                return a;
            } 
        }
        static void xet(int a)
        {
        if(factorial(a) == 0 )
            {
               Console.WriteLine("so cua ban nhap la so am nen khong co giai thua");
            }
            else
            {
               Console.WriteLine("Factorinal cua {0} la {1}", a, factorial(a));
            }
        }


    }
}
