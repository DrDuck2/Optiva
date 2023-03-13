using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Rpon
{
    public class DataConsolePrinter
    {
        private static DataConsolePrinter instance;

        private DataConsolePrinter() { }

        public static DataConsolePrinter GetInstance()
        {
           if(instance == null)
           {
                instance = new DataConsolePrinter();
           }
           return instance;
        }

        public void PrintData(IDataset dataset)
        {
            StringBuilder builder = new StringBuilder();
            int rows =dataset.GetData().Count;
            int columns =dataset.GetData()[0].Count;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    builder.Append(dataset.GetData()[i][j] );
                    if(j+1!=columns)
                    {
                        builder.Append(", ");
                    }
                }
                Console.WriteLine(builder.ToString());
                builder.Clear();
            }
        }
    }
}
