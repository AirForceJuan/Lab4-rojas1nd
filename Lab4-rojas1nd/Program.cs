using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_rojas1nd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }; // array of integers 

            string[] textArray = { "dog", "cat", "mouse", "lion", "bat" }; // array of strings

            Console.WriteLine("A INT and STRING Array");

            Print(numArray);
            Print(textArray);

            Find(6, numArray) = 12; // Calls Find method for integers and replaces the 6 with a 12
            Find("cat", textArray) = "owl"; // Calls Find Method for Strings and replaces the cat elemet with owl

            Console.WriteLine("New INT and STRING Array");

            Print(numArray); // prints out new Arrays
            Print(textArray);
            Console.ReadLine();


        }

        private static ref int Find(int num,int[] arra1) //Find method for integers
        {
            for(int i =0;i < arra1.Length;i++) 
            {
                if(num==arra1[i])
                {
                    return ref arra1[i];
                }
            }
            return ref arra1[0];
        }

        private static ref string Find(string text,string[] arra2) //Find Method for Strings
        {
            for (int i = 0; i < arra2.Length; i++)
            {
                if (text == arra2[i])
                {
                    return ref arra2[i];
                }
            }
            return ref arra2[0];
        }

        private static void Print<T>(IEnumerable<T> ans) //Generic Print Method for Arrays
        {
            foreach (var item in ans)
                Console.Write(item + "|");
            Console.WriteLine();
        }

    }
}
