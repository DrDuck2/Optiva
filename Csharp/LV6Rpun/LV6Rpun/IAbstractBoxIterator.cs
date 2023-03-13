using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public interface IAbstractBoxIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
