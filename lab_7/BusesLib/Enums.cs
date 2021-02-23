using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesLib
{
    public enum TheWaysInKilometers : int
    {
        Гомель = 0,
        Речица = 42,
        Светлогорск = 103,
        Жлобин = 153,
        Бобруйск = 219
    }

    public enum Stops
    {
        Гомель,
        Речица,
        Светлогорск,
        Жлобин,
        Бобруйск
    }

    public enum BusesType
    { 
        МАЗ,
        MAN,
        Хёндай,
        Мерседес
    }
}
