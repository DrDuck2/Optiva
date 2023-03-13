using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Rpon
{
    public interface IShipable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }
}
