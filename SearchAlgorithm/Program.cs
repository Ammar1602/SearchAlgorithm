using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        //Aaray to be searched
        int[] arr = new int[20];
        //Number of element in the array 
        int n;
        //Get the number of elements to show in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array:");
                string s = Console.ReadLine();
                if ((n > 0) && (n <= 0))
                    break;
                else
                Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }
            //
            Console.WriteLine("");
            Console.WriteLine("======================");
            Console.WriteLine(" Enter Array Elements ");
            Console.WriteLine("======================");
            for (i = 0; 1 < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
