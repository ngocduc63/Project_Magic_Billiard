using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.CallSQL
{
    public class FoodCallSQL
    {
        static private FoodCallSQL instance;

        public static FoodCallSQL Instance
        {
            get { if (instance == null) instance = new FoodCallSQL(); return instance; }
            private set => instance = value;
        }

        public DataTable GetAllFood()
        {
            string query = "select * from food";

            return DataManager.Instance.ExecuteOuery(query);
        }
    }
}
