using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    internal class Beef : Meat, ICut, IWash
    {
        public Beef(string name, int weight, int kkal, int protein)
            : base(name, weight, kkal, protein)
        {
        }

        public string Roast()
        {
            return "Roasting beef";
        }

        public override string Cut()
        {
            return "Cut beef";
        }

        public override string Wash()
        {
            return "Washing beef";
        }
    }
}
