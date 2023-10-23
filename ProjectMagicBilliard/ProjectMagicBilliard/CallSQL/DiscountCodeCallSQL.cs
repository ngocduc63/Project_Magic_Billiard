using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectMagicBilliard.CallSQL
{
    class DiscountCodeCallSQL
    {
        static private DiscountCodeCallSQL instance;

        public static DiscountCodeCallSQL Instance
        {
            get { if (instance == null) instance = new DiscountCodeCallSQL(); return instance; }
            private set => instance = value;
        }

        public bool CheckDiscount(string code)
        {
            string query = $"select * from discountCode where name = '{code}'";

            return DataManager.Instance.ExecuteOuery(query).Rows.Count > 0;
        }

        public double GetQuantityCode(string code)
        {
            string query = $"select quantity from discountCode where name = '{code}'";

            return (double) DataManager.Instance.ExecuteOuery(query).Rows[0][0];
        }
    }
}
