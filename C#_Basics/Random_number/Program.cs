using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Random_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int nums = rand.Next(1, 8);    // printing only monthes
            DateTime dt = Convert.ToDateTime(nums + "/" + nums + "/" + "2000");
            Console.Write("Month is: ");
            Console.WriteLine(dt.ToString( "MMMM"));
            DateTime d = Convert.ToDateTime(nums + "/" + nums + "/" + "2000");
            Console.Write("Day is: ");
            Console.WriteLine(dt.ToString("dddd"));
        }
    }
}
