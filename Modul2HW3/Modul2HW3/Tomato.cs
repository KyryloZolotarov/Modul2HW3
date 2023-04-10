using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    internal class Tomato : Vegetables
    {
        public Tomato(string name, int weight, int kkal, int carbohydrat, bool seeds)
    : base(name, weight, kkal, carbohydrat)
        {
            Seeds = seeds;
        }

        public bool Seeds { get; set; }

        public override string Cut()
        {
            var removeseeds = RemoveSeeds();
            return removeseeds + "cutting Tomato to eight wedges";
        }

        public override string Wash()
        {
            return "washing tomato";
        }

        protected string RemoveSeeds()
        {
            Seeds = false;
            return "seeds removed, ";
        }
    }
}
