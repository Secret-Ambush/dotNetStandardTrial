using dotNetStandardTrialClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator o = new Operator();
            var myList = o.CreateListOfPeople();
            foreach (var item in myList)
            {
                Console.WriteLine($"{item.FirstName}{item.LastName} is on our list. ");
            }

            Console.ReadLine();
        }
    }
}
