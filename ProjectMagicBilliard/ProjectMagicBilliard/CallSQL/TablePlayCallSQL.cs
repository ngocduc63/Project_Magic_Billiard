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
            string query = "select tablePlay.id, status, idCategory , price from tablePLay join tableCategory on tableCategory.id = tablePLay.idCategory";

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

        public DataTable GetDataTablePlay()
        {
            string query = "SELECT dbo.tablePLay.id,dbo.tablePLay.status,dbo.tableCategory.name,dbo.tableCategory.price FROM dbo.tableCategory,dbo.tablePLay WHERE dbo.tablePLay.idCategory=dbo.tableCategory.id";

            DataTable result = DataManager.Instance.ExecuteOuery(query);
            return result;
        }
        public bool insertTable(string status,string idCategory)
        {
            string query = $"insert into tablePlay (status,idCategory) values ('{status}','{idCategory}')";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool deleteFoodCategory(string id)
        {
            string query = $"DELETE FROM tablePlay WHERE id='{id}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool updateFoodCategory(string id, string status,string idCategory)
        {
            string query = $"UPDATE tablePlay SET status ='{status}', idCategory = '{idCategory}' WHERE id='{id}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public DataTable searchTable(string name)
        {
            string query = $"SELECT * FROM tablePlay WHERE name LIKE '{name}'";
            DataTable retult = DataManager.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
