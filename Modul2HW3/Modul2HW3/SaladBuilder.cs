using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    internal class SaladBuilder
    {
        public Salad CreateSomeSalat()
        {
            var salad = new Salad();
            Cucumber cucumbers = new Cucumber("cucumbers", 200, 18, 3, true);
            cucumbers.Wash();
            cucumbers.Cut();
            salad.AddProductTOSalad(cucumbers);
            Tomato tomatos = new Tomato("tomatos", 180, 25, 4, true);
            tomatos.Wash();
            tomatos.Cut();
            salad.AddProductTOSalad(tomatos);
            Lettuce lettuce = new Lettuce("lettuce", 350, 15, 3, "leaves");
            lettuce.Wash();
            lettuce.Cut();
            salad.AddProductTOSalad(lettuce);
            Parsley parsley = new Parsley("parsley", 40, 36, 6, "small leaves", true);
            parsley.Wash();
            parsley.Cut();
            salad.AddProductTOSalad(parsley);
            Beef beef = new Beef("beef", 320, 250, 26);
            beef.Wash();
            beef.Cut();
            beef.Roast();
            salad.AddProductTOSalad(beef);
            return salad;
        }
    }
}
