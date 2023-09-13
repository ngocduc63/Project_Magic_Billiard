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
    }
}
