using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
