using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//using abstraction.AbstractClass;
using abstraction.Interface;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuah buah;

            buah = new Pisang();
            buah.berwarna();

            Console.WriteLine();
            buah = new Apel();
            buah.berwarna();

            Console.ReadKey();
        }
    }
}
