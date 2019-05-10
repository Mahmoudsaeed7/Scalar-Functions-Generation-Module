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
    public partial class FunctionsForm : Form
    {
        public FunctionsForm()
        {
            InitializeComponent();
        }

        private void FunctionsForm_Load(object sender, EventArgs e)
        {
            label1.Text = PassData.colName[0].ToString();
            List<Function> functions = new List<Function>();
            FileStream fs = new FileStream("Functions.xml", FileMode.Open);
            XmlSerializer ser = new XmlSerializer(functions.GetType());
            functions = (List<Function>)ser.Deserialize(fs);
            GridView_Table.Columns.Add("name", "Name");
            GridView_Table.Columns.Add("arg", "Number of Args");
            GridView_Table.Columns.Add("datatype", "DataType");
            foreach (Function function in functions)
            {
                GridView_Table.Rows.Add(function.name, function.numOfArg, function.dataTypes[0]);
            }
            fs.Close();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Functions functions = new Functions(PassData.tableName, PassData.colName[0]);
                int rowIndex = GridView_Table.SelectedRows[0].Index;
                string rowName = GridView_Table.Rows[rowIndex].Cells[0].Value.ToString();
                switch (rowName)
                {
                    case "SumInt":
                        int sumi = functions.sumIntegers();
                        MessageBox.Show("Answer: " + sumi);
                        break;
                    case "SumDouble":
                        double sumd = functions.sumDoubles();
                        MessageBox.Show("Answer: " + sumd);
                        break;
                    case "MinDouble":
                        double mind = functions.MinDoubles();
                        MessageBox.Show("Answer: " + mind);
                        break;
                    case "maxDouble":
                        double maxd = functions.MaxDouble();
                        MessageBox.Show("Answer: " + maxd);
                        break;
                    case "maxInt":
                        int maxi = functions.MaxInt();
                        MessageBox.Show("Answer: " + maxi);
                        break;
                    case "MinInt":
                        int mini = functions.MinIntegers();
                        MessageBox.Show("Answer: " + mini);
                        break;
                    case "Count":
                        int count = functions.Count();
                        MessageBox.Show("Answer: " + count);
                        break;
                    case "Avg":
                        double avg = functions.Avg();
                        MessageBox.Show("Answer: " + avg);
                        break;
                }
            }
            catch (FormatException formatex) { MessageBox.Show("Please select a proper datatype.", "DataType", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (ArgumentOutOfRangeException Argex) { MessageBox.Show("Please select a row.", "SelectRow", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FunctionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            Hide();
            fr.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
