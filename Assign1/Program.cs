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
         int n, i,j;
         n = Convert.ToInt32(Console.ReadLine());
         for (i = 0; i<=n; i++)
            {
                for (j=1; j <= n-i; j++)
                
                Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                     Console.Write("*");
                Console.Write("\n");
                

            }
        }
}
}
