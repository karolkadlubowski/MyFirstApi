using Librus.data;
using Librus.forms;
using Librus.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librus
{
    static class Program
    {
        public static Teacher TeacherLogin { get; set; }

        [STAThread]
        static void Main()
        {  
            IDatabaseManagement databaseManagement = new DatabaseManagement();
            databaseManagement.InitDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegisterOrLogin());
        }
    }
}
