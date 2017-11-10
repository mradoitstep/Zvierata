using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvierata
{
    class pes : zviera
    {
        public override void VydajZvuk()
        {
            Console.WriteLine("Haf");
        }

        public override void NakrmZviera()
        {
            Nakrmeny = true;
        }

    }
}
