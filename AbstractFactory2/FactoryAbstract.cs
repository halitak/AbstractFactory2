using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    abstract class FactoryAbstract
    {
        public abstract HddAbstract CreateHdd();
        public abstract IRam CreateRam();
    }
}
