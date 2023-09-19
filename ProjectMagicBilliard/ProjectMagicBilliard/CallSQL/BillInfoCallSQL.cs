using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMagicBilliard.Data;

namespace ProjectMagicBilliard.CallSQL
{
    public class BillInfoCallSQL
    {
        static private BillInfoCallSQL instance;

        public static BillInfoCallSQL Instance
        {
            get { if (instance == null) instance = new BillInfoCallSQL(); return instance; }
            private set => instance = value;
        }

        public bool InsertToBillInfo(string idFood, int quantity, string idBill)
        {
            string query = $"insert into billInfo values('{idFood}', {quantity}, '{idBill}')";

            return DataManager.Instance.ExecuteNonOuery(query);
        }

        public bool DeleteToBillInfo(string id)
        {
            string query = $"delete from billInfo where id = '{id}'";

            return DataManager.Instance.ExecuteNonOuery(query);
        }
    }
}
