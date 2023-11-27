using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.CallSQL
{
    class CodeManagerCallSQL
    {
        static private CodeManagerCallSQL instance;

        public static CodeManagerCallSQL Instance
        {
            get { if (instance == null) instance = new CodeManagerCallSQL(); return instance; }
            private set => instance = value;
        }

        public DataTable GetAllCode()
        {
            string query = "select * from discountCode";

            return DataManager.Instance.ExecuteOuery(query);
        }

        public DataTable SearchCode(string name)
        {
            string query = $"select * from discountCode where name like '%{name}%' ";

            return DataManager.Instance.ExecuteOuery(query);
        }

        public bool InsertCode(string code ,int quantity)
        {
            string query = $"insert into discountCode values('{ code}', {quantity})";

            return DataManager.Instance.ExecuteNonOuery(query);
        }

        public bool DeleteCode(string id)
        {
            string query = $"delete from discountCode where id = '{id}'";

            return DataManager.Instance.ExecuteNonOuery(query);
        }

        public bool UpdateCode(string id, string code, int quantity)
        {
            string query = $"update discountCode set quantity = {quantity}, name = '{code}' where id = '{id}'";

            return DataManager.Instance.ExecuteNonOuery(query);
        }
    }
}
