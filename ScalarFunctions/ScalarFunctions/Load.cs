using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace ScalarFunctions
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int rowsCount = 10;

            Table table = new Table("Products");
            Column price = new Column("Price", "double");
            Column id = new Column("id", "int");
            Function sumInt = new Function("SumI", rowsCount);
            Function sumDouble = new Function("SumD", rowsCount);
            List<Function> functions = new List<Function>();

            sumInt.setDataTypes("int");
            sumDouble.setDataTypes("double");
            functions.Add(sumInt);
            functions.Add(sumDouble);
            for(int i = 0; i < rowsCount; i++)
            {
                price.values.Insert(i, Math.Round(random.NextDouble() * 100, 3).ToString());
            }
            for (int i = 0; i < rowsCount; i++)
            {
                id.values.Insert(i, random.Next(1, 1000).ToString());
            }
            table.columns.Add(price);
            table.columns.Add(id);

            FileStream fileStream = new FileStream("Tables.xml", FileMode.Create);
            XmlSerializer ser = new XmlSerializer(table.GetType());
            ser.Serialize(fileStream, table);
            fileStream = new FileStream("Functions.xml", FileMode.Create);
            ser = new XmlSerializer(functions.GetType());
            ser.Serialize(fileStream, functions);
            fileStream.Close();
        }
    }
}
