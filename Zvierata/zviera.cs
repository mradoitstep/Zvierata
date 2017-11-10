using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvierata
{
    abstract class zviera
    {
        protected bool Nakrmeny;
        public virtual void VydajZvuk()

        {
            Console.WriteLine("Zvuk");
        }
        public abstract void NakrmZviera();
    }   


}
