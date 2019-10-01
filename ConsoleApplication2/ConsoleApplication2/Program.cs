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
            int[] arr = new int[10];
            Input(arr);
            hamgoi(arr);
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
    }
}
