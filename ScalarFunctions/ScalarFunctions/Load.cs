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
            List<Table> tables = new List<Table>();
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

            tables.Add(table);
            FileStream fileStream = new FileStream("Tables.xml", FileMode.Create);
            XmlSerializer ser = new XmlSerializer(tables.GetType());
            ser.Serialize(fileStream, tables);
            fileStream.Close();
            fileStream = new FileStream("Functions.xml", FileMode.Create);
            ser = new XmlSerializer(functions.GetType());
            ser.Serialize(fileStream, functions);
            fileStream.Close();
        }

        private void CB_TableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Table> TableData = new List<Table>();
            Table table = new Table("Data");
            XmlSerializer ser = new XmlSerializer(TableData.GetType());
            FileStream fs = new FileStream("Tables.xml", FileMode.Open);
            TableData = (List<Table>)ser.Deserialize(fs);      
            foreach (Table T in TableData)
            {
                if (CB_TableName.SelectedItem.Equals(T.name))
                {
                    List<Column> C = T.columns;
                    for (int i=0;i<T.columns.Count;i++)
                    {
                        string C_name = C[i].header;
                        GridView_Table.Columns.Add(C_name,C_name);
                        List<string> Str = C[i].values;
                        for (int j=0;j< Str.Count;j++)
                        {
                            GridView_Table.Rows.Add();
                            GridView_Table.Rows[j].Cells[i].Value=Str[j];
                        }
                    }
                    break;
                }

            }
            fs.Close();
        }
    }
}
