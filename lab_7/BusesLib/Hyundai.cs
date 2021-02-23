using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesLib
{
    public class Hyundai : Bus
    {
        public Hyundai(int freePlacesQuantity, string type, double pricePerKilometer)
            : base(freePlacesQuantity, type, pricePerKilometer)
        { }
    }
}
