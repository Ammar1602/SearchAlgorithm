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
                if ((n > 0) && (n <= 20))
                    break;
                else
                Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }
            //
            Console.WriteLine("");
            Console.WriteLine("======================");
            Console.WriteLine(" Enter Array Elements ");
            Console.WriteLine("======================");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                //Accept the number to be ssearched
                Console.Write
                    ("\nEnter Element Want You To Search");
                int item = Convert.ToInt32(Console.ReadLine());

                // Apply binary serach
                int lowerbound = 0;
                int upperbound = n - 1;

                // Obtain the index of the middle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                // Loop to search for the elements in the array 
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "Found At Position" + (mid + 1).ToString() + "Not Found In The Array\n");
                Console.WriteLine("\nNumber Of Comparasion :" + ctr);

                Console.WriteLine("\nContinue Search (y/n):");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        public void LinearSearch()
        {
            char ch;
            // Search for number of comparison
            int ctr;
            do
            {
                // Accept the number to be searched
                Console.WriteLine("\nEnter The Element You Want To Search");
                int item = Convert.ToInt32((Console.ReadLine()));

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " Found st Potition " + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                Console.WriteLine("\n" + item.ToString() + " not found in the array ");
                Console.WriteLine("\n Number of comparasion: " + ctr);
                Console.WriteLine("\nContinue search (y/n):");
                ch = Char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("================");
                    Console.WriteLine(" 1. Linear Search ");
                    Console.WriteLine(" 2. Binary Option ");
                    Console.WriteLine(" 3. Exit ");
                    Console.WriteLine(" Enter You're Choice  (1, 2, 3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Linear Search");
                            Console.WriteLine("-----------------");
                            myList.input();
                            myList.BinarySearch();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Binary Search");
                            Console.WriteLine("-----------------");
                            myList.input();
                            myList.BinarySearch();
                            break;
                        case 3:
                            Console.WriteLine(" Exit. ");
                            break;
                        default:
                            Console.WriteLine(" Error ");
                            break;
                    }
                    Console.WriteLine("\nPilih Menu Lagi (y/n) : ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');

                // To Exit From The Console
                Console.WriteLine("\n\nPress Return To Exit. ");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
