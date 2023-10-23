using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.CallSQL
{
    internal class guestCallSQL
    {
        static private guestCallSQL instance;
        public static guestCallSQL Instance
        {
            get { if (instance == null) instance = new guestCallSQL(); return instance; }
            private set => instance = value;
        }
        public DataTable GetAllGuest()
        {
            string query = "select * from guest";

            DataTable result = DataManager.Instance.ExecuteOuery(query);

            return result;
        }
        public bool insertGuest(string NameGuest, string addressGuest, string PhoneNumberGuest, string TotalPointGuest)
        {
            string query = $"INSERT INTO guest (name,address,phoneNumber,totalPoint) VALUES ('{NameGuest}','{addressGuest}','{PhoneNumberGuest}','{TotalPointGuest}')";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool deleteGuest(string IDGuest)
        {
            string query = $"DELETE FROM guest WHERE id='{IDGuest}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool updateGuest(string IDGuest, string NameGuest, string addressGuest, string PhoneNumberGuest, string TotalPointGuest)
        {
            string query = $"UPDATE guest SET name='{NameGuest}', address='{addressGuest}', phoneNumber='{PhoneNumberGuest}',totalPoint='{TotalPointGuest}' WHERE id='{IDGuest}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public DataTable searchGuest(string param, bool isSearchForcusName)
        {
            string query;
            if (isSearchForcusName) query = $"SELECT * FROM guest WHERE name LIKE '%{param}%'";
            else query = $"SELECT * FROM guest WHERE phoneNumber LIKE '%{param}%'";

            return DataManager.Instance.ExecuteOuery(query);
        }
    }

}
