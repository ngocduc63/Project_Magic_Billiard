﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectMagicBilliard.CallSQL
{
    public class StaffCallSQL
    {
        static private StaffCallSQL instance;

        public static StaffCallSQL Instance
        {
            get { if (instance == null) instance = new StaffCallSQL(); return instance; }
            private set => instance = value;
        }

        public bool insertStaff(string nameStaff, string addressStaff, string phoneNumberStaff, string idPositionStaff)
        {
            string query = $"insert into staff (name, address, phoneNumber, idPosition) values ('{nameStaff}','{addressStaff}','{phoneNumberStaff}','{idPositionStaff}')";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool deleteStaff(string idStaff)
        {
            string query = $"DELETE FROM staff WHERE id='{idStaff}'";
            return DataManager.Instance.ExecuteNonOuery(query);
        }
        public bool updateStaff(string idStaff, string nameStaff, string addressStaff, string phoneNumberStaff, string idPositionStaff)
        {
            string query = $"UPDATE staff SET name='{nameStaff}', address='{addressStaff}', phoneNumber='{phoneNumberStaff}', idPosition='{idPositionStaff}' WHERE id='{idStaff}'";
            return DataManager.Instance.ExecuteNonOuery(query) ;
        }
        public DataTable GetAllStaff()
        {
            string query = $"SELECT staff.id, staff.name, address, phoneNumber, position.name as 'NamePosition' FROM staff join position on staff.idPosition = position.id";
            DataTable retult = DataManager.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable GetAllPosition()
        {
            string query = "select * from position";

            return DataManager.Instance.ExecuteOuery(query);
        }
        public DataTable searchStaff(string param, bool isSearchForcusName)
        {
            string query;
            if (isSearchForcusName) query = $"SELECT * FROM staff WHERE name LIKE '%{param}%'";
            else query = $"SELECT * FROM staff WHERE phoneNumber LIKE '%{param}%'";

            return DataManager.Instance.ExecuteOuery(query);
        }
    }
}
