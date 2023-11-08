using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectMagicBilliard.CallSQL
{
    internal class FoodCategoryCallSQL 
    {
        static private FoodCategoryCallSQL instance;
        public static FoodCategoryCallSQL Instance
        {
            get { if (instance == null) instance = new FoodCategoryCallSQL(); return instance; }
            private set => instance = value;
        }
        public DataTable GetAllFoodCategory()
        {
            string query = "select * from foodCategory";

            return DataManager.Instance.ExecuteOuery(query);
        }

        public bool insertFoodCategory(string nameFoodCategory)
        {
            string query = $"insert into foodCategory (name) values ('{nameFoodCategory}')";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool deleteFoodCategory(string idFoodCategory)
        {
            string query = $"DELETE FROM foodCategory WHERE id='{idFoodCategory}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool updateFoodCategory(string idFoodCategory, string nameFoodCategory)
        {
            string query = $"UPDATE foodCategory SET name='{nameFoodCategory}' WHERE id='{idFoodCategory}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public DataTable searchFoodCategory(string name)
        {
            string query = $"SELECT * FROM foodCategory WHERE name LIKE '%{name}%'";
            DataTable retult = DataManager.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
