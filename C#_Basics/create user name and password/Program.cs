using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace create_user_name_and_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "y";
            Console.Write("Enter ypur name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your pass: ");
            int pass = int.Parse(Console.ReadLine());
            if (pass == 12345)
            {
                Console.WriteLine("Welcome " + name);
            }
            else
            {
                Console.WriteLine("invalid password please tray agin");
            }
;
        }
    }
}
