using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvierata
{
    class macka : zviera
    {
        public override void VydajZvuk()
        {
            Console.WriteLine("Mnau");
        }
        public override void NakrmZviera()
        {
            Nakrmeny = true;
        }
    }
}
