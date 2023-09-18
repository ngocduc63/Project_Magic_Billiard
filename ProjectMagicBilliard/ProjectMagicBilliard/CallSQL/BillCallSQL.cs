using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectMagicBilliard.CallSQL
{
    public class BillCallSQL
    {
        static private BillCallSQL instance;

        public static BillCallSQL Instance
        {
            get { if (instance == null) instance = new BillCallSQL(); return instance; }
            private set => instance = value;
        }

        public bool InsertToBill(DateTime time, string idTable)
        {
            string query = $"insert into bill (dateCheckIn, idTable, totalPrice) values ('{time}', '{idTable}', 0)";

            return DataManager.Instance.ExecuteNonOuery(query);
        }

        public DataTable GetTimeStart(string idTable)
        {
            string query = $"select dateCheckIn from bill where idTable = '{idTable}'";

            return DataManager.Instance.ExecuteOuery(query);
        }
    }
}
