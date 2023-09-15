using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.CallSQL
{
    class TablePlayCallSQL
    {
        static private TablePlayCallSQL instance;

        public static TablePlayCallSQL Instance
        {
            get { if (instance == null) instance = new TablePlayCallSQL(); return instance; }
            private set => instance = value;
        }

        public DataTable GetAllTable()
        {
            string query = "Select * from tablePlay";

            DataTable result = DataManager.Instance.ExecuteOuery(query);

            return result;
        }
    }
}
