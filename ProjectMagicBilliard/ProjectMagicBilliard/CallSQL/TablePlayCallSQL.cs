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
            string query = "select tablePlay.id, status, name, price from tablePLay join tableCategory on tableCategory.id = tablePLay.idCategory";

            DataTable result = DataManager.Instance.ExecuteOuery(query);

            return result;
        }

        public DataTable GetBillOfTable(string idTable)
        {
            string query = "select billInfo.id, food.name, food.price, billInfo.quantityFood from bill "
                            + "join billInfo on billInfo.idBill = bill.id "
                            + "join food on billInfo.idFood = food.id "
                            + $"where idTable = '{idTable}' and bill.status = 0";

            DataTable result = DataManager.Instance.ExecuteOuery(query);

            return result;
        }
    }
}
