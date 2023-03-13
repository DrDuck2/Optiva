using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace LV5Rpon
{
    public class VirtualProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;

        public VirtualProxyDataset(string filePath)
        {
            this.filePath = filePath;
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            if(dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            return dataset.GetData();
        }
    }
}
