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
            string query = "SELECT * from food";

            return DataManager.Instance.ExecuteOuery(query);
        }
        public bool insertFood(string name,string price,string idCategory)
        {
            string query = $"insert into food (name,price,idCategory) values ('{name}','{price}','{idCategory}')";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool deleteFood(string id)
        {
            string query = $"DELETE FROM food WHERE id='{id}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool updateFood(string id, string name,string price,string idCategory)
        {
            string query = $"UPDATE food SET name='{name}', price='{price}', idCategory='{idCategory}' WHERE id='{id}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool searchFood(string name)
        {
            string query = $"SELECT * FROM food WHERE name LIKE '{name}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetFood()
        {
            string query = "SELECT dbo.food.id,dbo.food.name,dbo.food.price,dbo.foodCategory.name FROM dbo.foodCategory,dbo.food WHERE dbo.food.idCategory=dbo.foodCategory.id";

            return DataManager.Instance.ExecuteOuery(query);
        }
    }
}
