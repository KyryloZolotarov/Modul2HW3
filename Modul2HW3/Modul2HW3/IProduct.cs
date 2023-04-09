using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    public interface IProduct : ICut, IWash, IComparable
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public double KkallInWeight
        {
            get
            {
                return Kkall * 0.01 * Weight;
            }

            set
            {
                this.KkallInWeight = value;
            }
        }

        public int Kkall { get; set; }
    }
}
