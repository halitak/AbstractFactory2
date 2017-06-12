using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    class RamConcrete2:IRam
    {
        public void RamIslem()
        {
            Console.WriteLine("RamConcrete2 birleştirildi");
        }

        public string RamTur
        {
            get { return "Ram turu 'Concrete2'"; }
        }
    }
}
