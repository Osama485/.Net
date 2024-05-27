using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insert_data_using_format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Osama Khallaf";
            string job = "Programmer";
            string phone = "01151749204";
            string title = "Mallawi / Minia/ Egypt";

            string data = string.Format(" Name: {0} \n Job: {1} \n phone number: {2} \n Title: {3}", name, job, phone, title);
            Console.WriteLine(" information about me..\n" +"______________________\n"+ data);
        }
    }
}
