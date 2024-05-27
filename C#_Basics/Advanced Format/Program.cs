using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numvoice = { 101, 324, 653, 345, 654, 234, 514, 234, 534, 232, 234, 605, 345 };

            foreach(int i in numvoice)
            {
                Console.WriteLine("   {0:0000}", i);
            }
            Console.WriteLine("____________________\n");
            foreach (int i in numvoice)
            {
                Console.WriteLine("   {0:c}", i);              //to show name coin 
            }
        }
    }
}
