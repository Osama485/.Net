using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUper_Lower_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "OSAMA KHALLAF SAMIR";
            Console.WriteLine(name.ToLower());

            string name2 = "osama khallaf samir";
            Console.WriteLine(name2.ToUpper());

            // example by using array

            string name3 = "osama";
            string n1 = "";
            char [] n2 = name3.ToCharArray();

            for (int i = 0; i < 5; i++) 
            {
                if (i == 2 || i == 0 || i == 4)   // to make the first, therd and the last character capital in (osama -> OsAmA)
                {
                    n1 += n2[i].ToString().ToUpper();
                }
                else
                {
                    n1 += n2[i];
                }
                
            }
            Console.WriteLine("___________________________");
            Console.WriteLine(n1);
        }
    }
}
