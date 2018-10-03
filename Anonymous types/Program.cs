using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mycar = new {color = "Black", Brand = "BMW", speed = 180};
            Console.WriteLine("My car has {0} colour {1} as brand and runs at {2} km/hr");
            List<int> allnumbers=new List<int>{1,2,4,5,6,7};
            List<int> evennumbers = allnumbers.FindAll(x => (x % 2) == 0);
            foreach (var VARIABLE in evennumbers)
            {
                Console.WriteLine(VARIABLE);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
