using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    internal class Cucumber : Tomato
    {
        public Cucumber(string name, int weight, int kkal, int carbohydrat, bool seeds)
            : base(name, weight, kkal, carbohydrat, seeds)
        {
        }

        public override string Cut()
        {
            var removeseeds = RemoveSeeds();
            return removeseeds + "Cutting cucumber into rounds";
        }

        public override string Wash()
        {
            return "washing cucumber";
        }
    }
}
