using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.CallSQL
{
    class LoginCallSQL
    {
        static private LoginCallSQL instance;

        public static LoginCallSQL Instance
        {
            get { if (instance == null) instance = new LoginCallSQL(); return instance; }
            private set => instance = value;
        }

        public bool LoginCheck(string userName, string passWord)
        {
            string query = "SELECT * FROM account WHERE userName =N'" + userName + "' AND passWord = N'" + passWord + "'";
            DataTable result =  DataManager.Instance.ExecuteOuery(query);

            return result.Rows.Count > 0;
        }
        public string GetDisplayName(string userName, string passWord)
        {
            string query = "SELECT displayName FROM account WHERE userName =N'" + userName + "' AND passWord = N'" + passWord + "'";
            DataTable result = DataManager.Instance.ExecuteOuery(query);

            return result.Rows[0][0].ToString();
        }

        public DataTable GetAllAccount()
        {
            string query = "select * from account";

            DataTable result = DataManager.Instance.ExecuteOuery(query);

            return result;
        }
        public bool insertAccount(string usernameAccount, string passwordAccount, string displayNameAccount, string idStaff)
        {
            string query = $"insert into account (name, address, phoneNumber, idPosition) values ('{usernameAccount}','{passwordAccount}','{displayNameAccount}','{idStaff}')";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool deleteAccount(string usernameAccount)
        {
            string query = $"DELETE FROM account WHERE id='{usernameAccount}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool updateAccount(string usernameAccount, string passwordAccount, string displayNameAccount, string idStaff)
        {
            string query = $"UPDATE account SET password='{passwordAccount}', displayName='{displayNameAccount}', idStaff='{idStaff}' WHERE id='{usernameAccount}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
    }
}
