using System;

namespace Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 1:
            /*  Print a pattern with n rows given n as input 
             *  n – number of rows for the pattern, integer (int)
             */
            //int n, i,j;
            int n = 5;//Convert.ToInt32(Console.ReadLine());
         PrintTriangle(n);

            //QUESTION 2: 
            /*
             *  In mathematics, the Pell numbers are an infinite sequence of integers.
             * The sequence of Pell numbers starts with 0 and 1, and then each Pell number 
             * is the sum of twice of the previous Pell number and the Pell number before that.:
             */
            int n1 = 9;
            Console.WriteLine("The Series till " + n1 + " Terms is as follows : ");
            PrintPellSeries(n1);
        }

        private static void PrintTriangle(int n)
        {
            int i, j;
            for ( i = 0; i <= n; i++)
            {
                for ( j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

        }
        private static void PrintPellSeries(int n2)
        {
            int i,b =0,a=1, c = 0;

            for ( i = 1; i<= n2; i++)
            {
                Console.Write(c + " ");
                c = a + 2 * b;
                a = b;
                b = c;

            }
        }
    }
}
