using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    internal static class SaladExtention
    {
        internal static IProduct FindByName(this Salad salad, string productname)
        {
            foreach (var product in salad.GetSalad())
            {
                if (string.Equals(product.Name, productname, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }

            return null;
        }
    }
}
