using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
