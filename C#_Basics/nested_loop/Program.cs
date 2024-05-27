using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int c = 1; c <= 3; c++) 
            {
                Console.WriteLine("Company " + c);
                Console.WriteLine("___________________");
                for (int bul = 1; bul <= 2; bul++) 
                {
                    Console.WriteLine("   Bulding " + bul);
                    for (int floor = 1; floor <= 3; floor++) 
                    {
                        Console.WriteLine("          floor_" + floor);
                       
                        for (int dep = 1; dep <= 2; dep++) 
                        {
                            Console.WriteLine("                 Department " + dep);
                        }
                    }
                    Console.WriteLine("*********************************");
                }
                
            }
        }
    }
}
