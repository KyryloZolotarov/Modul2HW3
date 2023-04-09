using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    internal sealed class Parsley : Lettuce
    {
        public Parsley(string name, int weight, int kkal, int carbohydrat, string leaves, bool stem)
            : base(name, weight, kkal, carbohydrat, leaves)
        {
            Stem = stem;
        }

        public bool Stem { get; set; }
        public override string Cut()
        {
            var cutstemresult = CutStem();
            return cutstemresult + "cut parsley leaves";
        }

        public override string Wash()
        {
            return "Washing parsley";
        }

        private string CutStem()
        {
            Stem = false;
            return "Cut off stem";
        }
    }
}
