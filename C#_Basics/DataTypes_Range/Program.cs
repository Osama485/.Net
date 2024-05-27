using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("byte");
            Console.WriteLine(byte.MinValue + " : " + byte.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("sbyte");
            Console.WriteLine(sbyte.MinValue + " : " + sbyte.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("short");
            Console.WriteLine(short.MinValue + " : " + short.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("ushort");
            Console.WriteLine(ushort.MinValue + " : " + ushort.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("int");
            Console.WriteLine(int.MinValue + " : " + int.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("uint");
            Console.WriteLine(uint.MinValue + " : " +uint.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("long");
            Console.WriteLine(long.MinValue + " : " +long.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("ulong");
            Console.WriteLine(ulong.MinValue + " : " + ulong.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("float");
            Console.WriteLine(float.MinValue + " : " + float.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("double");
            Console.WriteLine(double.MinValue + " : " + double.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("decimal");
            Console.WriteLine(decimal.MinValue + " : "+ decimal.MaxValue);
            Console.WriteLine("==============================");

            Console.WriteLine("char");
            Console.WriteLine(char.MinValue + " : " + char.MaxValue);
            Console.WriteLine("==============================");
        }
    }
}
