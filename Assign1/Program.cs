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
            // initialized variable i and j
            int i, j;
            //Run a loop starting from 1 and incrementing it by 1 till n.
            for ( i = 0; i <= n; i++)
            {
                //Run a loop starting from 1 and incrementing it by 1 till n - i to printout spaces.
                for ( j = 1; j <= n - i; j++)
                    Console.Write(" ");
                // Run a loop starting from 1 and incrementing it by 1 till (2*i - 1) to printout '*'.
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

        }
        private static void PrintPellSeries(int n2)
        {
            // initialized variable i,a,b and cs
            int i,b =0,a=1, c = 0;

            //Run a loop starting from 1 and incrementing it by 1 till n2.
            for ( i = 1; i<= n2; i++)
            {
                //Calculate Next digit in the series and concatenate it with the series. 
                Console.Write(c + " ");
                c = a + 2 * b;
                a = b;
                b = c;

            }
        }

        private static bool SquareSums(int A)
        {
            // Run a loop starting from 1 and incrementing it by 1 till A.
            for (long i = 1; i * i <= A; i++)
                // Run a loop starting from 1 and incrementing it by 1 till j*j is less than and equal to A.
                for (long j = 1; j * j <= A; j++ )

                    // Check all combination of pair of squares of i and j
                    //Return true if condition succeed   else send False
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
            // initialized variable i, j and count.
            int i , j,count = 0;
            // Run a loop starting from o and incrementing it by 1 till length of an input array.
            for ( i = 0; i < nums.Length; i++)
            {
                // Check the difference of number at ith position with 
                // all the numbers from (i+1) till the end of the array
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
            // initialized variable count
            int count =0;
            string[] list = new string[emails.Length];
            foreach ( string email in emails)
            {
                // Split local name and domain
                string[] words = email.Split('@');

                //Get Index of local name after '+'
                int index = words[0].LastIndexOf("+");
                
                // Remove character of 'index' from local name
                if (index > 0)
                    words[0] = words[0].Substring(0, index);

                // Replace '.' with "" from local name
                string word = words[0].Replace(".", "");
                

                // Check for Unique email by concatenating local name and domain
                // If true add Unique email id in list array and increase the count
                if (!(list.Contains(word + "@" + words[1])))
                {
                    list[count] = word + "@" + words[1];
                    Console.WriteLine(list[count]);
                    count++;
                }
               
            }
            Console.WriteLine("\n5." + count + " actually receive mails");
            return count;
        }
        private static string DestCity(string[,] paths)
        {
            // // initialized variable d1 and d2

            // d1 is total pair of cities
            int d1 = paths.GetLength(0);
            int d2 = paths.GetLength(1);

            // Array for all the distination cities 
            string [] dest = new string[d1];
            // Array for all the Source cities
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
                // Check if all source cities exist in Destination array
                // If not That is out destination city.
                if (Array.Exists(ori, element => element == c) == false)
                {
                    Console.WriteLine("\n6.The destination city is " + c);
                    return c;

                }
            }
            
            return " ";
                   
        }
    }
}
