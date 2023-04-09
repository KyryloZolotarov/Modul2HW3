using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    internal class Lettuce : Vegetables, ICut, IWash
    {
        public Lettuce(string name, int weight, int kkal, int carbohydrat, string leaves)
            : base(name, weight, kkal, carbohydrat)
        {
            Leaves = leaves;
        }

        public string Leaves { get; set; }
        public override string Cut()
        {
            return "cut lettuce";
        }

        public virtual new string Wash()
        {
            return "Washing lettuce";
        }
    }
}
