using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction.Interface
{
    public class Apel : IBuah
    {
        public void berwarna()
        {
            Console.WriteLine("Apel berwarna merah atau hijau");
            Console.WriteLine("Bagian dalam apel berwarna putih");
        }
    }
}
