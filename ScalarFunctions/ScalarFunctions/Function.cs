using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Threading.Tasks;

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
        public int sumIntegers(string tableName , string Header)
        {
            int sum = 0;
            XmlDocument doc = new XmlDocument();
            doc.Load("Tables.xml");
            XmlNodeList List = doc.GetElementsByTagName("Column");
            for (int i = 0; i < List.Count; i++)
            {
                XmlNodeList childs = List[i].ChildNodes;

                string header = childs[0].Name;
                string headerValue = childs[0].InnerText;

                if (headerValue == "Price")
                {
                    XmlNodeList values = childs[2].ChildNodes;

                    for (int j = 0; j < values.Count; j++)
                    {
                        int value = int.Parse(values[j].InnerText);
                        sum += value;
                    }
                    break;
                }
            }
            return sum;
        }

        public double sumDoubles(string tableName, string Header)
        {
            double sum = 0.0;
            XmlDocument doc = new XmlDocument();
            doc.Load("Tables.xml");
            XmlNodeList List = doc.GetElementsByTagName("Column");
            for (int i = 0; i < List.Count; i++)
            {
                XmlNodeList childs = List[i].ChildNodes;

                string header = childs[0].Name;
                string headerValue = childs[0].InnerText;

                if (headerValue == "Price")
                {
                    XmlNodeList values = childs[2].ChildNodes;

                    for (int j = 0; j < values.Count; j++)
                    {
                        double value = double.Parse(values[j].InnerText);
                        sum += value;
                    }
                    break;
                }
            }
            return sum;
        }

        public int Count(string tableName , string Header)
        {
            int valuesCount = 0;
            XmlDocument doc = new XmlDocument();
            doc.Load("Tables.xml");
            XmlNodeList List = doc.GetElementsByTagName("Column");
            for (int i = 0; i < List.Count; i++)
            {
                XmlNodeList childs = List[i].ChildNodes;

                string headerValue = childs[0].InnerText;
                if (headerValue == "Price")
                {
                    XmlNodeList values = childs[2].ChildNodes;
                    valuesCount = values.Count;
                }
            }
            return valuesCount;
        }
    }
}
