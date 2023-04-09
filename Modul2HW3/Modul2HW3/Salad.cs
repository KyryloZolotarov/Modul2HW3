using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3
{
    internal class Salad
    {
        private IProduct[] _salad = Array.Empty<IProduct>();
        public void AddProductTOSalad(IProduct product)
        {
            var length = _salad.Length;
            Array.Resize(ref _salad, newSize: length + 1);
            _salad[length] = product;
        }

        public IProduct[] GetSalad()
        {
            return _salad;
        }
    }
}
