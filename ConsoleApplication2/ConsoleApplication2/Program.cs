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
            vechuv();
            vetamgiacnguoc();
            vetamgiac();
            veW();
        }
        public static void hamgoi(int[] arr )
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
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                String str = Console.ReadLine();
                arr[i] = int.Parse(str);
            }
        }
        public static bool Checkhave5(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++ )
            {
                if (arr[i] == 5) ;
                    return true;
            }
                return false;
        }
        public static bool checkhave5or6(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++ )
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
            for (int i = 0; i < arr.Length; i++ )
            {
                if( arr[i] == 5)
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
            int a=0;
            for(int i=0; i<arr.Length; i++)
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
             for(int i=0; i<arr.Length; i++)
             {
                 if(arr[i] == 6)
                 {
                     b++;
                 }
             }
             return b;
             
        }
        public static int tong(int[] arr)
        {
            int a = 0;
             for(int i=0; i<arr.Length; i++)
             {
                 a += arr[i];
             }
             return a;
        }
        public static void vecot()
        {
            for(int i=0; i<4; i++)
            {
                Console.WriteLine("i");
            }
        }
        public static void vehinhvuong()
        {
            for (int i=0; i< 4; i++)
            {
                for(int j=0; j<4;j++)
                {
                    Console.Write("* ");
                    if (j == 3)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        public static void vehinhvuongrongruoc()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("o ");
            }
                Console.WriteLine();
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0 || i == 3)
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
            //Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("o ");
            }
        }


        public static void vechuu()
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            { 
                for (int i = 0; i < 4; i++)
                    {
                        if (i == 0 || i == 3)
                        {
                             Console.Write("U");
                        }
                        
                        else
                        {
                            Console.Write(" ");
                        }
                }
                Console.WriteLine();
            }
                for (int i = 0; i < 4; i++)
                {
                      Console.Write("U");
                }
            Console.WriteLine();
        }
        public static void vechuv()
        {
            int n = 3;
            for (int i = 0; i <= 2 * n; i++)
            {
                if (i == 0 || i == 2 * n)
                {
                    Console.Write("V");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            //hang2
            for (int i = 0; i <= 2 * n; i++)
            {
                if (i == 1 || i == 2 * n - 1)
                {

                    Console.Write("V");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            //hang3
            for (int i = 0; i <= 2 * n; i++)
            {
                if (i == 2 || i == 2 * n - 2)
                {
                    Console.Write("V");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            //hang4
            for (int i = 0; i <= 2 * n; i++)
            {
                if (i == n)
                {
                    Console.Write("V");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        
        public static void vetamgiacnguoc()
            {
           //hang1
                int n = 3;
                for (int i = 0; i <= 2 * n; i++)
                {
                Console.Write("V");
                }
                Console.WriteLine();
                //hang2
                for (int i = 0; i <= 2 * n; i++)
                {
                    if (i == 1 || i == 2 * n - 1)
                    {

                        Console.Write("V");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                //hang3
                for (int i = 0; i <= 2 * n; i++)
                {
                    if (i == 2 || i == 2 * n - 2)
                    {
                        Console.Write("V");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                //hang4
                for (int i = 0; i <= 2 * n; i++)
                {
                    if (i == n)
                    {
                        Console.Write("V");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            Console.WriteLine();
            Console.WriteLine("---------------------");
        }
        public static void vetamgiac()
        {
            int n = 3;
            //hang1
            for (int i = 0; i <= 2 * n; i++)
            {
                if (i == n)
                {
                    Console.Write("A");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            //hang2
            for (int i = 0; i <= 2 * n; i++)
            {
                if (i == 2 || i == 2 * n - 2)
                {
                    Console.Write("A");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            //hang3
            for (int i = 0; i <= 2 * n; i++)
            {
                if (i == 1 || i == 2 * n - 1)
                {

                    Console.Write("A");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            //hang4

            for (int i = 0; i <= 2 * n; i++)
            {
                Console.Write("A");
            }
            Console.WriteLine();
            Console.WriteLine("---------------");
        }
        public static void veW()
        {
            int n = 7;
           
                for (int i = 1; i < n * 2; i++)
                {
                    if (i == n - (n - 1) || i == n || i == 2 * n - 1)
                    {
                        Console.Write("W");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                for (int i = 1; i < n * 2; i++)
                {
                    if (i == n - (n - 2) || i == 2 * n - 2 || i == n - 1 || i == n + 1)
                    {
                        Console.Write("W");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            for (int i = 1; i < n * 2; i++)
            {
                if (i == n - (n - 3) || i == 2 * n - 3 || i == n - 2 || i == n + 2)
                {
                    Console.Write("W");
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
            for (int i = 1; i < n * 2; i++)
            {
                if (i == n - (n - 4) || i == 2 * n - 4 || i == n - 3 || i == n + 3)
                {
                    Console.Write("W");
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();









        }













    }
}

