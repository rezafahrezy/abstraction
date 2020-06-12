using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstraction.AbstractClass
{
    public class Apel : Buah
    {
        public override void berwarna()
        {
            Console.WriteLine("Apel berwarna merah atau hijau");
            Console.WriteLine("Bagian dalam apel berwarna putih");
        }
    }
}
