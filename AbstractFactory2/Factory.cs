using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    class Factory
    {
        private FactoryAbstract factoryAbstract;
        private HddAbstract hddAbstract;
        private IRam ramInterface;

        public Factory(FactoryAbstract factoryAbstract) {
            this.factoryAbstract = factoryAbstract;
            hddAbstract = factoryAbstract.CreateHdd();
            ramInterface = factoryAbstract.CreateRam();
        }

        public void Birlestir() {
            Console.WriteLine(hddAbstract.HddTur);
            hddAbstract.HddIslem();

            Console.WriteLine(ramInterface.RamTur);
            ramInterface.RamIslem();
        }
    }
}
