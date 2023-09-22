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

        public bool UpdateEndTime(DateTime time, string idBill)
        {
            string query = $"update bill set dateCheckOut = '{time}' where id = '{idBill}'";

            return DataManager.Instance.ExecuteNonOuery(query);
        }

        public DateTime? GetTimeStart(string idTable)
        {
            try
            {
                string query = $"select dateCheckIn from bill where idTable = '{idTable}' and status = 0";

                return (DateTime)DataManager.Instance.ExecuteOuery(query).Rows[0]["dateCheckIn"];
            }
            catch (Exception)
            {

                return null;
            }
        }

        public DateTime? GetTimeEnd(string idTable)
        {
            try
            {
                string query = $"select dateCheckOut from bill where idTable = '{idTable}' and status = 0";

                return (DateTime)DataManager.Instance.ExecuteOuery(query).Rows[0]["dateCheckOut"];
            }
            catch (Exception)
            {

                return null;
            }
        }

        public string GetIdCurrent(string idTable)
        {
            string query = $"select id from bill where idTable = '{idTable}' and status = 0";

            return DataManager.Instance.ExecuteOuery(query).Rows[0]["id"].ToString();
        }
    }
}
