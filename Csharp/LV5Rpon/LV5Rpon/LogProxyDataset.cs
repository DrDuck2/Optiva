using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections;

namespace LV5Rpon
{
    public class LogProxyDataset : IDataset
    {
        private Dataset dataset;
        private ConsoleLogger consoleLogger;
        private DateTime time;

        private string filePath;

        public LogProxyDataset(string filePath)
        {
            consoleLogger = ConsoleLogger.GetInstance();
            time = DateTime.Now;
            this.filePath = filePath;
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            return dataset.GetData();
        }
        public void LogData()
        {
            if(dataset == null)
            {
                this.GetData();
            }
            consoleLogger.Log(dataset);
            
        }
    }
}
