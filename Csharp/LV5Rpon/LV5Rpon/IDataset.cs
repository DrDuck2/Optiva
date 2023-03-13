using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace LV5Rpon
{
    public interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
