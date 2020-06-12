using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using abstraction.AbstractClass;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Buah buah;

            buah = new Pisang();
            buah.berwarna();

            Console.WriteLine();
            buah = new Apel();
            buah.berwarna();

            Console.ReadKey();
        }
    }
}
