using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double numd = 1.0000;
            float numf = 2.0000f;
            decimal numdec = 3.0000m;
            uint numuint = 4U;
            int numint = 5;
            long numlong = 6L;
            ulong numulong = 7UL;

            char copyrightSymbol = '\u00A9';
            char omegaSymbol = '\u03A9';

            Console.WriteLine("INTS:\n" + "\n" + numuint.ToString() + "\n" + numint.ToString() +
                "\n" + numlong.ToString() + "\n" + numulong.ToString());

            Console.WriteLine("\nChars:" + "\n" + copyrightSymbol.ToString() + "\n" + omegaSymbol);

            Console.WriteLine("\nREAIS:\n" + numd.ToString() + "\n" + numf.ToString() + "\n" + numdec.ToString());
        }
    }
}
