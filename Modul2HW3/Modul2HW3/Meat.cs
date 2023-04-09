using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    internal abstract class Meat : IProduct
    {
        public Meat(string name, int weight, int kkal, int protein)
        {
            Name = name;
            Weight = weight;
            Kkall = kkal;
            Protein = protein;
        }

        public int Weight { get; set; }
        public int Kkall { get; set; }
        public int Protein { get; set; }
        public string Name { get; set; }
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

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            IProduct? otherProduct = obj as IProduct;
            if (otherProduct != null)
            {
                return this.KkallInWeight.CompareTo(otherProduct.KkallInWeight);
            }
            else
            {
                throw new ArgumentException("Object is not a Temperature");
            }
        }

        public virtual string Cut()
        {
            return "Cut beef";
        }

        public virtual string Wash()
        {
            return "Washing meat";
        }
    }
}
