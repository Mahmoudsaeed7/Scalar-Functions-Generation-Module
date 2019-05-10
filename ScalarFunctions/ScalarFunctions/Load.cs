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
            PassData.colIndex.Clear();
            PassData.colName.Clear();
            if (!File.Exists("Tables.xml") && !File.Exists("Functions.xml"))
            {
                Random random = new Random();
                int rowsCount = 10;

                Table table = new Table("Products");
                List<Table> tables = new List<Table>();

                Column price = new Column("Price", "double");
                Column id = new Column("id", "int");
                Column Year = new Column("Model Year", "int");

                Function sumInt = new Function("SumInt", rowsCount);
                Function sumDouble = new Function("SumDouble", rowsCount);
                Function Avg = new Function("Avg", rowsCount);
                Function count = new Function("Count", rowsCount);
                Function minInt = new Function("MinInt", rowsCount);
                Function minDouble = new Function("MinDouble", rowsCount);
                Function maxInt = new Function("maxInt", rowsCount);
                Function maxDouble = new Function("maxDouble", rowsCount);

                List<Function> functions = new List<Function>();

                
                sumInt.setDataTypes("int");
                sumDouble.setDataTypes("double");
                Avg.setDataTypes("default");
                count.setDataTypes("default");
                minInt.setDataTypes("int");
                maxInt.setDataTypes("int");
                minDouble.setDataTypes("double");
                maxDouble.setDataTypes("double");

                functions.AddRange(new List<Function>() { minDouble, maxDouble, maxInt,minInt, count,Avg, sumInt, sumDouble });
                for (int i = 0; i < rowsCount; i++)
                {
                    price.values.Insert(i, Math.Round(random.NextDouble() * 100, 3).ToString());
                }
                for (int i = 0; i < rowsCount; i++)
                {
                    id.values.Insert(i, random.Next(1, 1000).ToString());
                }
                for (int i = 0; i < rowsCount; i++)
                {
                    Year.values.Insert(i, random.Next(1998, 2019).ToString());
                }
                table.columns.Add(price);
                table.columns.Add(id);
                table.columns.Add(Year);

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
        }

        private void CB_TableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PassData.tableName = CB_TableName.SelectedItem.ToString();
            List<Table> TableData = new List<Table>();
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
                        GridView_Table.Columns[C_name].SortMode = DataGridViewColumnSortMode.NotSortable;
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
            GridView_Table.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
            fs.Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (CB_fnType.SelectedIndex==0)
            {
                if (GridView_Table.SelectedColumns.Count == 1)
                {
                    PassData.colIndex.Add(GridView_Table.SelectedColumns[0].Index);
                    PassData.colName.Add(GridView_Table.Columns[PassData.colIndex[0]].Name);
                    FunctionsForm functionsform = new FunctionsForm();
                    Hide();
                    functionsform.Show();
                }
                else
                    MessageBox.Show("Please select a column.", "SelectColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CB_fnType.SelectedIndex==1)
            {
                if (GridView_Table.SelectedColumns.Count >= 1)
                {
                    for (int i=0;i< GridView_Table.SelectedColumns.Count; i++)
                    {
                        PassData.colIndex.Add(GridView_Table.SelectedColumns[i].Index);
                        PassData.colName.Add(GridView_Table.Columns[PassData.colIndex[i]].Name);
                    }
                    FunctionsForm functionsform = new FunctionsForm();
                    Hide();
                    functionsform.Show();
                }
                else
                    MessageBox.Show("Please select at least a column.", "SelectColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB_fnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectBtn.Visible = true;
        }
    }
}
