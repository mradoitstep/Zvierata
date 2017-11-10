using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvierata
{
    class Program
    {
        static void Main(string[] args)
        {
            zviera p = new pes();
            p.NakrmZviera();
            p.VydajZvuk();
            zviera m = new macka();
            m.NakrmZviera();
                    
            m.VydajZvuk();

            Console.ReadLine();
        }
    }
}
