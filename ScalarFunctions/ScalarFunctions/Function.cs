using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
           
    }
}
