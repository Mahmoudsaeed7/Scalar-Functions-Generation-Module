using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalarFunctions
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class PassData
    {
        public static List<string> colName= new List<string>();
        public static string tableName;
        public static List<Column> columns;
        public static bool singleValue = true ;
        public static bool isNumber = true ;
        public static Column selColumn = null;
        public static string oper;
    }
}
