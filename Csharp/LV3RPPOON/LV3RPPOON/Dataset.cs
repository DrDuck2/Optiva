using System;
using System.Collections.Generic;
using System.Text;

namespace LV3RPPOON
{
    class Dataset : Prototype
    {
        private List<List<string>> data;
        public Dataset()
        {
            this.data = new List<List<string>>();
        }

        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }

        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }

        public IList<List<string>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }

        public void ClearData()
        {
            this.data.Clear();
        }

        public Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

        public Prototype DeepCopy()
        {
            Prototype deepCopyData = new Dataset();
            return deepCopyData;
        }
    }
}
