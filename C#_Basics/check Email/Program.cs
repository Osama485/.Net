using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace check_Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Email: ");
            string mail = Console.ReadLine();

            Regex txt = new Regex(@"^(\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)$");
            if(txt.IsMatch(mail))
            {
                Console.WriteLine("Welcome your mail is correct....");
            }
            else
            {
                Console.WriteLine("Your mail isn't Valid");
            }
        }
    }
}
