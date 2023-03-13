using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace LV5Rpon
{
    public class Dataset : IDataset
    {
        private string filePath;
        private List<List<string>> data;

        public Dataset(string filePath)
        {
            this.filePath = filePath;
            this.data = new List<List<string>>();
            this.LoadDataFromCSV();
        }

        private void LoadDataFromCSV()
        {
            string[] lines = System.IO.File.ReadAllLines(this.filePath);
            foreach (string line in lines)
            {
                List<string> row = new List<string>(line.Split(','));
                data.Add(row);
            }
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            return new ReadOnlyCollection<List<string>>(this.data);
        }

    }
}
