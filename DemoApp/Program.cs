using SampleAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass sc = new SomeClass();
            sc.DoSomething();

            Console.ReadLine();
        }
    }
}
