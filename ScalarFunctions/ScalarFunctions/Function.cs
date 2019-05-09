using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace ScalarFunctions
{
    public class Function
    {
        public string name;
        public int numOfArg;
        public string[] dataTypes;

        public Function() { }

        public Function(string name, int numOfArg)
        {
            this.name = name;
            this.numOfArg = numOfArg;
            dataTypes = new string[numOfArg];
        }

        public void setDataTypes(string dataType)
        {
            for(int i = 0; i < numOfArg; i++)
            {
                dataTypes[i] = dataType;
            }
        }
    }

    public class Functions
    {
        private List<Table> tables;
        private Column column; 
        
        public Functions(string tableName, string columnHeader)
        {
            FileStream file = new FileStream("Tables.xml", FileMode.Open);
            XmlSerializer ser = new XmlSerializer(tables.GetType());
            tables = (List<Table>)ser.Deserialize(file);

            for(int i = 0; i < tables.Count; i++)
            {
                Table table = tables[i];
                if(table.name == tableName)
                {
                   for(int j = 0; j < table.columns.Count; j++)
                    {
                        Column column = table.columns[j];
                        if (column.header == columnHeader) {
                            this.column = column;
                            break;
                        }
                    }
                }
            }
        }

        public double Avg()
        {
            double answer = 0.0;
            int count = column.values.Count;
            for (int i = 0; i < column.values.Count; i++)
            {
                   if (column.dataType == "double")
                    {
                        double sum = 0;
                        double number = double.Parse(column.values[i]);
                        sum += number;
                        answer =  (sum / count);
                    }
                    else
                    {
                        int sum = 0;
                        int number = int.Parse(column.values[i]);
                        sum += number;
                        answer = (sum / count);
                     }
                }
            return answer;
        }

        public int sumIntegers()
        {
            int sum = 0;
            for (int i = 0; i < column.values.Count; i++)
            {
                    int value = int.Parse(column.values[i]);
                    sum += value;
            }
            return sum;
        }

        public double sumDoubles()
        {
            double sum = 0.0;
            for (int i = 0; i < column.values.Count; i++)
            {
                double value = double.Parse(column.values[i]);
                sum += value;
            }
            return sum;
        }

        public int Count()
        {
            int valuesCount = 0;
            valuesCount = column.values.Count;
            return valuesCount;
        }

        public int MinIntegers()
        {
            int minValue = int.Parse(column.values[0]);
            for (int i = 0; i < column.values.Count; i++)
            {
                if (int.Parse(column.values[i]) < minValue)
                {
                    minValue = int.Parse(column.values[i]);
                }
            }
            return minValue;
        }

        public double MinDoubles()
        {
            double minValue = double.Parse(column.values[0]);
            for (int i = 0; i < column.values.Count; i++)
            {
                if (double.Parse(column.values[i]) <= minValue)
                {
                    minValue = double.Parse(column.values[i]);
                }
            }
            return minValue;
        }

        public int MaxInt()
        {
            int max = int.Parse(column.values[0]);
            for(int i = 0; i < column.values.Count; i++)
            {
                int value = int.Parse(column.values[i]);
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }
        public double MaxDouble()
        {
            double max = double.Parse(column.values[0]);
            for (int i = 0; i < column.values.Count; i++)
            {
                double value = double.Parse(column.values[i]);
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }

    }
}
