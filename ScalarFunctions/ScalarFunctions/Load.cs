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
            Table table = new Table("Products");
            Column price = new Column("Price", "double");
            for(int i = 0; i < 10; i++)
            {
                price.values.Insert(i, (new Random().NextDouble() * 100).ToString());
            }
            Column id = new Column("id", "int");
            for (int i = 0; i < 10; i++)
            {
                id.values.Insert(i, new Random().Next(10, 1000).ToString());
            }
            table.columns.Add(price);
            table.columns.Add(id);

            FileStream fileStream = new FileStream("Tables.xml", FileMode.Create);
            XmlSerializer ser = new XmlSerializer(table.GetType());
            ser.Serialize(fileStream, table);
            fileStream.Close();
        }
    }
}
