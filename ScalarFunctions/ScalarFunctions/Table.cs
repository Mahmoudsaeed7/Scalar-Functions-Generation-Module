using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalarFunctions
{
    
    public class Table
    {
        public string name;
        public List<Column> columns;

        public Table() { }

        public Table(string name)
        {
            this.name = name;
            columns = new List<Column>();
        }
    }

    public class Column
    {
        public string header;
        public string dataType;
        public List<string> values;

        public Column() { }

        public Column(string header, string dataType)
        {
            this.header = header;
            this.dataType = dataType;
            values = new List<string>();
        }
    }
}
