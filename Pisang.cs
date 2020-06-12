using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction.Interface
{

    public class Pisang : IBuah
    {
        public void berwarna()
        {
            Console.WriteLine("Pisang berwarna kuning");
            Console.WriteLine("Bagian dalam pisang berwarna kuning muda");
        }
    }
}
