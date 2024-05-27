using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your in small letter: ");
            string n = Console.ReadLine();

            //Regex name = new Regex("^[a-z]+$");                                  // for small latter from     a: z
            //Regex name = new Regex("^[A-Z]+$");                                  // for capital letter from   A: Z
            //Regex name = new Regex("^[A-Z][a-z]+$");                             // first letter capital and the rest is small
            //Regex name = new Regex("^[A-Z][a-z]+\\s[A-Z][a-z]+$");               // to insert the first and the last name all of them with capetal letter in the first and small at the rest of them
            //Regex name = new Regex("^[A-Z][a-z]+\\s[A-Z][a-z]+\\s[A-Z][a-z]+$"); // to write the name in_3 all of them with capetal letter in the first and small at the rest of them

            Regex name = new Regex("^[A-Z][a-z]+(\\s[A-Z][a-z]+)*$");        //to insert any number of names all of them with capetal letter in the first and small at the rest of them

            //Regex name = new Regex("^[ا-ي]+$");             // insert your first name in arbic 
            //Regex name = new Regex("^[ا-ي]+(\\s[ا-ي])+$");      // insert your first and second name in arabic

            //Regex name = new Regex("^([ا-ي]+(\\s[ا-ي]+)*)$|([A-Z][a-z]+(\\s[A-Z][a-z]+)*)$"); //insert your name in arabic or english
                                                                                          

            if (name.IsMatch(n))
                Console.WriteLine("Welcome : " + n);
            else
                Console.WriteLine("the name isn't valid....");
        }
    }
}
