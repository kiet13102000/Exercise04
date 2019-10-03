using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[10];
            //Input(arr);
            // hamgoi(arr);
            vecot();
            vehinhvuong();
            vehinhvuongrongruoc();
            vechuu();
            vechuv(10, 'v');
            vetamgiacnguoc(10, 'a');
            vetamgiac(10, 'v');
            veW(4, 'w');
            vechuA(10, 'A');
            veX(10, '*');
            DrawX2(5, '*');
        }
        public static void hamgoi(int[] arr)
        {
            if (Checkhave5(arr) == true)
            {
                Console.WriteLine("in array have number 5");
            }
            else
            {
                Console.WriteLine("in array haven't number 5");
            }

            if (checkhave5or6(arr) == true)
            {
                Console.WriteLine("in array have number 5 or 6");
            }
            else
            {
                Console.WriteLine("in array haven't number 5 or 6");
            }

            if (checkhave5and6(arr) == true)
            {
                Console.WriteLine("in array have number 5 and 6");
            }
            else
            {
                Console.WriteLine("in array haven't number 5 and 6");
            }
            Console.WriteLine(" have {0} number {1} in array", Count5(arr), 5);
            Console.WriteLine(" have {0} number {1} and {2} number {3} in array", Count5(arr), 5, Count6(arr), 6);
            Console.WriteLine(" tong cac gia tri trong mang la {0}", tong(arr));
        }
        public static void Input(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                String str = Console.ReadLine();
                arr[i] = int.Parse(str);
            }
        }
        public static bool Checkhave5(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                return true;
            }
            return false;
        }
        public static bool checkhave5or6(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 6)
                    return true;
            }
            return false;
        }
        public static bool checkhave5and6(int[] arr)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    a = 1;
                }
                if (arr[i] == 6)
                {
                    b = 1;
                }
            }
            if (a + b == 2)
            {
                return true;
            }
            else
                return false;
        }
        public static int Count5(int[] arr)
        {
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    a++;
                }
            }
            return a;
        }
        public static int Count6(int[] arr)
        {

            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 6)
                {
                    b++;
                }
            }
            return b;

        }
        public static int tong(int[] arr)
        {
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a += arr[i];
            }
            return a;
        }
        //đã xong
        public static void vecot()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("i");
            }
        }
        //đã xong
        public static void vehinhvuong()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                    if (j == n - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        //đã xong
        public static void vehinhvuongrongruoc()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.Write("o ");
            }
            Console.WriteLine();
            for (int j = 0; j < n - 2; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == 0 || i == n - 1)
                    {
                        Console.Write("o ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("o ");
            }
        }

        //đã xong
        public static void vechuu()
        {
            int n = 4;
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n + 1; i++)
                {
                    if (i == 0 || i == n)
                    {
                        Console.Write("U ");
                    }

                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write("U ");
            }
            Console.WriteLine();
        }

        //đã xong
        public static void vechuv(int n, char v)
        {
            int KC = 2 * n - 3;
            for (int i = 1; i < n; i++)
            {
                hamvengang(i - 1, ' ');
                hamvengang(1, v);
                hamvengang(KC, ' ');
                Console.WriteLine(v);
                KC -= 2;
            }
            hamvengang(n - 1, ' ');
            Console.WriteLine(v);

        }
        public static void hamvengang(int n, char a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a);
            }
        }

        //đã xong
        public static void vetamgiacnguoc(int n, char v)
        {
            int KC = 2 * n - 3;
            hamvengang(2 * n + 1, v);
            Console.WriteLine();
            for (int i = 1; i < n; i++)
            {
                hamvengang(i, ' ');
                hamvengang(1, v);
                hamvengang(KC, ' ');
                Console.WriteLine(v);
                KC -= 2;

            }
            hamvengang(n, ' ');
            Console.WriteLine(v);
        }
        //đã xong
        public static void vetamgiac(int n, char v)
        {

            hamvengang(n - 1, ' ');
            Console.WriteLine(v);

            int KC = 1;
            int temp = n - 2;
            for (int i = 1; i < n - 1; i++)
            {
                hamvengang(temp, ' ');
                hamvengang(1, v);
                hamvengang(KC, ' ');
                Console.WriteLine(v);
                KC += 2;
                temp -= 1;
            }
            hamvengang(2 * n - 1, v);
            Console.WriteLine();
        }



        //đã xong
        public static void veW(int n, char v)
        {
            hamvengang(1, v);
            hamvengang(2 * n - 3, ' ');
            hamvengang(1, v);
            hamvengang(2 * n - 3, ' ');
            hamvengang(1, v);
            Console.WriteLine();
            int tem = 2 * n - 5;
            int kc1 = 1;
            for (int i = 1; i < n - 1; i++)
            {
                hamvengang(i, ' ');
                hamvengang(1, v);
                hamvengang(tem, ' ');
                hamvengang(1, v);


                hamvengang(kc1, ' ');
                hamvengang(1, v);

                hamvengang(tem, ' ');
                hamvengang(1, v);

                tem -= 2;
                kc1 += 2;

                Console.WriteLine();
            }
            hamvengang(n - 1, ' ');
            hamvengang(1, v);
            hamvengang(kc1, ' ');
            hamvengang(1, v);
            Console.WriteLine();
        }

        public static void vechuA(int n, char v)
        {
            //n=4 n=5 n=6
            hamvengang(n, ' ');
            hamvengang(1, v);
            Console.WriteLine();
            int KT = n - 1;
            int tem = 1;
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                hamvengang(KT, ' ');
                hamvengang(1, v);
                hamvengang(tem, ' ');
                hamvengang(1, v);
                Console.WriteLine();
                tem += 2;
                KT -= 1;
            }
            hamvengang(KT, ' ');
            hamvengang(tem + 2, v);
            tem = tem + 2;
            Console.WriteLine();
            for (int i = 1; i <= n / 2; i++)
            {
                hamvengang(KT - 1, ' ');
                hamvengang(1, v);
                hamvengang(tem, ' ');
                hamvengang(1, v);
                KT -= 1;
                tem += 2;
                Console.WriteLine();
            }
        }
        public static void veX(int n, char v = '*')
        {
            int KT1 = 0;
            int KT2 = n - 2;
            for (int i = 0; i < n / 2; i++)
            {
                hamvengang(KT1, ' ');
                hamvengang(1, v);
                hamvengang(KT2, ' ');
                hamvengang(1, ' ');
                hamvengang(1, v);
                Console.WriteLine();
                KT1 += 1;
                KT2 -= 2;
            }
            //KT1 = KT1+1 ;
            hamvengang(KT1, ' ');
            hamvengang(1, v);
            Console.WriteLine();

            for(int i=0; i<n/2 ; i++)
            {
                KT1-=1;
                KT2+=2;
                hamvengang(KT1, ' ');
                hamvengang(1, v);
                hamvengang(KT2, ' ');
                Console.Write(' ');
                hamvengang(1, v);
                Console.WriteLine();
            }
        }
        public static void DrawX2(int n, char c = '*')
        {
            char[,] cArr = new char[n,n];
            for(int i=0; i<n;i++)
            {
                for(int j=0; j<n; j++)
                {
                    cArr[i, j] = '6';
                }
            }
            for(int i=0; i<n ; i++)
            {
                cArr[i, i] = c;
            }
            for (int i = 0; i < n; i++ )
            {
                cArr[i, n - 1 - i] = c;
            }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(cArr[i, j]);
                        Console.WriteLine();
                    }
                }
        }


    











    }
}

