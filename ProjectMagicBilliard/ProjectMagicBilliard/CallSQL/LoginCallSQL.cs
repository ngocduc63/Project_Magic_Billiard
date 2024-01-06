﻿using System;
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
        public (string, string, string) GetDisplayName(string userName, string passWord)
        {
            string query = "SELECT displayName, idStaff, idPosition FROM account join staff on staff.id = account.idStaff WHERE userName =N'" + userName + "' AND passWord = N'" + passWord + "'";
            DataTable result = DataManager.Instance.ExecuteOuery(query);

            return (result.Rows[0]["displayName"].ToString() , result.Rows[0]["idStaff"].ToString(), result.Rows[0]["idPosition"].ToString());
        }

        public DataTable GetAllAccount()
        {
            string query = "select * from account";

            DataTable result = DataManager.Instance.ExecuteOuery(query);

            return result;
        }
        public bool insertAccount(string usernameAccount, string passwordAccount, string displayNameAccount, string idStaff)
        {
            string query = $"insert into account (username, passWord, displayName, idStaff) values ('{usernameAccount}','{passwordAccount}','{displayNameAccount}','{idStaff}')";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool deleteAccount(string usernameAccount)
        {
            string query = $"DELETE FROM account WHERE userName='{usernameAccount}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool updateAccount(string usernameAccount, string passwordAccount, string displayNameAccount, string idStaff)
        {
            string query = $"UPDATE account SET passWord='{passwordAccount}', displayName='{displayNameAccount}', idStaff='{idStaff}' WHERE username='{usernameAccount}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public DataTable searchAccount(string usernameAccount)
        {
            string query = $"SELECT * FROM account WHERE username LIKE '%{usernameAccount}%'";
            DataTable retult = DataManager.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
