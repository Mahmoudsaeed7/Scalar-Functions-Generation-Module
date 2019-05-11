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
            if (PassData.singleValue)
            {
                colNames.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                GridView_Table.Visible = true;
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
            else
            {
                colNames.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                int ind = 0;
                string[] names = new string[PassData.columns.Count];
                foreach(Column col in PassData.columns)
                {
                    names[ind++] = col.header; 
                }
                colNames.Items.AddRange(names);
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (PassData.singleValue)
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
            else
            {
                if (PassData.isNumber)
                {
                    try
                    {
                        List<int> accIndicies = new List<int>();
                        double num = double.Parse(conditionTxt.Text);
                        switch (PassData.oper)
                        {
                            case ">":
                                accIndicies.Clear();
                                for (int i = 0; i < PassData.selColumn.values.Count; i++)
                                    if (double.Parse(PassData.selColumn.values[i]) > num)
                                        accIndicies.Add(i);
                                showResualt(accIndicies);
                                break;
                            case "<":
                                accIndicies.Clear();
                                for (int i = 0; i < PassData.selColumn.values.Count; i++)
                                    if (double.Parse(PassData.selColumn.values[i]) < num)
                                        accIndicies.Add(i);
                                showResualt(accIndicies);
                                break;
                            case "=":
                                accIndicies.Clear();
                                for (int i = 0; i < PassData.selColumn.values.Count; i++)
                                    if (Math.Abs(double.Parse(PassData.selColumn.values[i]) - num) <= 1e-10)
                                        accIndicies.Add(i);
                                showResualt(accIndicies);
                                break;
                        }
                    }
                    catch(FormatException formatex) { MessageBox.Show("Please write a proper datatype.", "DataType", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    try
                    {
                        string str = conditionTxt.Text;
                        List<int> accIndicies = new List<int>();
                        switch (PassData.oper)
                        {
                            case "Start with":
                                accIndicies.Clear();
                                for (int i = 0; i < PassData.selColumn.values.Count; i++)
                                    if (PassData.selColumn.values[i].StartsWith(str))
                                        accIndicies.Add(i);
                                showResualt(accIndicies);
                                break;
                            case "End with":
                                accIndicies.Clear();
                                for (int i = 0; i < PassData.selColumn.values.Count; i++)
                                    if (PassData.selColumn.values[i].EndsWith(str))
                                        accIndicies.Add(i);
                                showResualt(accIndicies);
                                break;
                        }
                    }
                    catch (FormatException formatex) { MessageBox.Show("Please write a proper datatype.", "DataType", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
        public void showResualt(List<int> inds)
        {
            GridView_Table.Visible = true;
            GridView_Table.Columns.Clear();
            GridView_Table.Rows.Clear();
            int rows = 0, cols = 0;
            for(int i= 0;i < PassData.columns.Count;i++)
            {
                if (PassData.colName.FindIndex(0,x => x == PassData.columns[i].header) != -1)
                {
                    rows = 0;
                    GridView_Table.Columns.Add(PassData.columns[i].header, PassData.columns[i].header);
                    for (int j = 0; j < PassData.columns[i].values.Count; j++)
                    {
                        if(inds.FindIndex(0, x => x == j) != -1) {
                            GridView_Table.Rows.Add();
                            GridView_Table.Rows[rows++].Cells[cols].Value = PassData.columns[i].values[j];
                        }
                    }
                    cols++;
                } 
            }
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

        private void colNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHeader = colNames.SelectedItem.ToString();
            foreach (Column c in PassData.columns)
            {
                if(c.header == selectedHeader)
                {
                    PassData.selColumn = c;
                    operation.Visible = true;
                    conditionTxt.Visible = true;
                    if (c.dataType == "int" || c.dataType == "double")
                    {
                        PassData.isNumber = true;
                        operation.Items.Clear();
                        operation.Items.AddRange(new string[] { ">", "=", "<" });
                    }
                    else
                    {
                        PassData.isNumber = false;
                        operation.Items.Clear();
                        operation.Items.AddRange(new string[] { "Start with", "End with" });
                    }
                    break;
                }
            }
        }

        private void operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            PassData.oper = operation.SelectedItem.ToString();
        }
    }
}
