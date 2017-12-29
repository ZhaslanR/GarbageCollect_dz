using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageColector
{
    class Program
    {
        static void Main(string[] args)
        {
            Test person = new Test() { Name = "Zhaslan", Age = 17 };
           
            Console.WriteLine("Поколения класса Test: " + GC.GetGeneration(person));
            GC.Collect();
            Console.WriteLine("Поколения класса Test: " + GC.GetGeneration(person));

            Console.ReadLine();
        }
    }
}
