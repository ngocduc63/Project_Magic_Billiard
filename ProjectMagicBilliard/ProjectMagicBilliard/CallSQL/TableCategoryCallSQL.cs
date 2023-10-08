﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.CallSQL
{
    internal class TableCategoryCallSQL
    {

        static private TableCategoryCallSQL instance;

        public static TableCategoryCallSQL Instance
        {
            get { if (instance == null) instance = new TableCategoryCallSQL(); return instance; }
            private set => instance = value;
        }
        public DataTable GetAllTableCategory()
        {
            string query = "select * from tableCategory";

            return DataManager.Instance.ExecuteOuery(query);
        }
        public bool insertTableCategory(string nameTableCategory, string priceTableCategory)
        {
            string query = $"insert into staff (name,price) values ('{nameTableCategory}','{priceTableCategory}')";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool deleteTableCategory(string idTableCategory)
        {
            string query = $"DELETE FROM staff WHERE id='{idTableCategory}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool updateTableCategory(string idTableCategory, string nameTableCategory, string priceTableCategory)
        {
            string query = $"UPDATE staff SET name='{nameTableCategory}', address='{priceTableCategory}' WHERE id='{idTableCategory}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
    }
}