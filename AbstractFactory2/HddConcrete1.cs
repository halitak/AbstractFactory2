using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    class HddConcrete1:HddAbstract
    {

        public override void HddIslem()
        {
            Console.WriteLine("HddConcrete1 birleştirildi");
        }

        public override string HddTur
        {
            get { return "Hdd türü 'Concrete1'"; }
        }
    }
}
