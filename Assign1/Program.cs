using System;
using System.Linq;

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
            Console.WriteLine("2. The Series till " + n1 + " Terms is as follows : ");
            PrintPellSeries(n1);

            // QUESTION 3:
            int A = 5;
            SquareSums(A);

            //QUESTION 4:
            int k = 2;
            DiffPairs(new int[] { 3, 1, 4, 1, 5 }, k);

            //QUESTION 5:
            UniqueEmails(new string[] {"dis.email+bull@usf.com", "dis.e.mail+bob.cathy@usf.com", "disemail+david@us.f.com"});

            //Question 6:
            DestCity(new string [,] { { "B", "C" },{ "D", "B" },{ "C", "A" } } );


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
        private static bool SquareSums(int A)
        { 
            for (long i = 1; i * i <= A; i++)
                for (long j = 1; j * j <= A; j++ )
                    if (i * i + j * j == A)
                    {
                        Console.WriteLine( "\n3. True:" + i + "^2 + " + j + "^2 = " + A);
                        return true;
                    }
            Console.WriteLine("\n3. False");
            return false;
        }
        private static int DiffPairs(int[] nums, int k)
        {
            int i , j,count = 0;
            for ( i = 0; i < nums.Length; i++)
            {
                for ( j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] - nums[j] == k || nums[j] - nums[i] == k)
                        count++;
                }

            }
            Console.WriteLine("\n4. Count of pairs with given diff " + k + " is "+ count);
            return count;

        }
        private static int UniqueEmails(string[] emails)
        {
            int count,i=0;
            string[] list = new string[emails.Length];
            foreach ( string email in emails)
            {
                string[] words = email.Split('@');

                int index = words[0].LastIndexOf("+");
             
                if (index > 0)
                    words[0] = words[0].Substring(0, index);

                string word = words[0].Replace(".", "");
                //list[i] = word +"@"+ words[1];

                if (!(list.Contains(word + "@" + words[1])))
                {
                    list[i] = word + "@" + words[1];
                    Console.WriteLine(list[i]);
                    i++;
                }
               
            }
            count = i;
            Console.WriteLine("\n5." + count + " actually receive mails");
            return count;
        }
        private static string DestCity(string[,] paths)
        {
            int d1 = paths.GetLength(0);
            int d2 = paths.GetLength(1);
            string [] dest = new string[d1];
            string [] ori  = new string[d1];
            for (int i = 0; i < d1; i++)
            {
                for (int j = 0; j < d2 -1; j++)
                {
                    ori[i] = paths[i,j];
                    dest[i] = paths[i, j+1];
                }
            }

            foreach (string c in dest)
            {
                if (Array.Exists(ori, element => element == c) == false)//(ori.Contains(c) == false)
                {
                    Console.WriteLine("\n6.The destination city is " + c);
                    return c;

                }
            }
            
            return " ";
                   
        }
    }
}
