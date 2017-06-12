using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    class Concrete1Factory:FactoryAbstract
    {
        public override HddAbstract CreateHdd()
        {
            return new HddConcrete1();
        }

        public override IRam CreateRam()
        {
            return new RamConcrete1();
        }
    }
}
