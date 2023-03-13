using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    public class Dataset : Prototype
    {
        private List<List<string>> data; //list of lists of strings
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
            return
            new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

        //SHALLOW COPY
        //public Prototype Clone()
        //{
            //return (Prototype)this.MemberwiseClone();
        //}
        
        //DEEP COPY
        public Prototype Clone()
        {
            Dataset dataSet = new Dataset();
            foreach(List<string> list in data)
            {
                List<string> row = new List<string>();
                foreach (string stringer in list)
                {
                    row.Add(stringer);
                }
                dataSet.data.Add(row);
            }
            return dataSet;
        }

    }
}
