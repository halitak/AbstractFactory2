using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    abstract class HddAbstract
    {
        public abstract void HddIslem();
        public abstract string HddTur { get; }
    }
}
