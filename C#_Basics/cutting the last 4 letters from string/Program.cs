using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutting_the_last_4_letters_from_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name: ");
            string file = Console.ReadLine();
            string file2 = "";

            if (file.Length > 4) 
            {
                file2 = file.Substring(0, file.Length - 4);
                Console.WriteLine("file name is: " + file2);
            }
            else
            {
                Console.WriteLine("Error........\n");
            }
        }
    }
}
