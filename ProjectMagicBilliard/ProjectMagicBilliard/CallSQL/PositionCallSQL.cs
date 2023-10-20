using ProjectMagicBilliard.Scene;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.CallSQL
{
    internal class PositionCallSQL
    {
        static private PositionCallSQL instance;
        public static PositionCallSQL Instance
        {
            get { if (instance == null) instance = new PositionCallSQL(); return instance; }
            private set => instance = value;
        }
        public DataTable GetAllPosition()
        {
            string query = "select * from position";

            return DataManager.Instance.ExecuteOuery(query);
        }
        public bool insertPosition(string namePosition)
        {
            string query = $"insert into position (name) values ('{namePosition}')";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool deletePosition(string idPosition)
        {
            string query = $"DELETE FROM position WHERE id='{idPosition}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool updatePosition(string idPosition, string namePosition)
        {
            string query = $"UPDATE position SET name='{namePosition}' WHERE id='{idPosition}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool searchPosition(string name)
        {
            string query = $"SELECT * FROM position WHERE name LIKE '{name}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
    }
}
