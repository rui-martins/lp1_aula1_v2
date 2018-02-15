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

            Console.WriteLine(numd.ToString() + "\n" + numf.ToString() + "\n" + numdec.ToString() + "\n" +
                numuint.ToString() + "\n" + numint.ToString() + "\n" + numlong.ToString() + "\n" + numulong.ToString());           
        }
    }
}
