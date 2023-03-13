using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public interface IVisitor
    {
        double Visit(DVD DVDItem);
        double Visit(VHS VHSItem);

        double Visit(Book BOOKItem);
    }
}
