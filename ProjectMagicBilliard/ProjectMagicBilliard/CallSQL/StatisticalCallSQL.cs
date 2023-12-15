using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.CallSQL
{
    class StatisticalCallSQL
    {
        static private StatisticalCallSQL instance;

        public static StatisticalCallSQL Instance
        {
            get { if (instance == null) instance = new StatisticalCallSQL(); return instance; }
            private set => instance = value;
        }

        public DataTable GetRevenueMonth(int year)
        {
            string query = "SELECT "
                            + "CASE "
                            + "WHEN MONTH(dateCheckOut) = 1 THEN N'Tháng Một'"
                            + "WHEN MONTH(dateCheckOut) = 2 THEN N'Tháng Hai'"
                            + " WHEN MONTH(dateCheckOut) = 3 THEN N'Tháng Ba'"
                            + "WHEN MONTH(dateCheckOut) = 4 THEN N'Tháng Tư'"
                            + "WHEN MONTH(dateCheckOut) = 5 THEN N'Tháng Năm'"
                            + "WHEN MONTH(dateCheckOut) = 6 THEN N'Tháng Sáu'"
                            + "WHEN MONTH(dateCheckOut) = 7 THEN N'Tháng Bảy'"
                            + "WHEN MONTH(dateCheckOut) = 8 THEN N'Tháng Tám'"
                            + "WHEN MONTH(dateCheckOut) = 9 THEN N'Tháng Chín'"
                            + "WHEN MONTH(dateCheckOut) = 10 THEN N'Tháng Mười'"
                            + "WHEN MONTH(dateCheckOut) = 11 THEN N'Tháng Mười Một'"
                            + "WHEN MONTH(dateCheckOut) = 12 THEN N'Tháng Mười Hai'"
                            + "END as 'Thang', "
                            + "SUM(totalPrice) as 'Doanh Thu'"
                            + $"FROM bill WHERE status = 1 and YEAR(dateCheckOut) = {year} GROUP BY MONTH(dateCheckOut)";
            return DataManager.Instance.ExecuteOuery(query);
        }

        public DataTable GetDetailRevenue()
        {
            string query = "select bill.id, dateCheckIn, dateCheckOut, idTable as 'table', guest.name as 'guest' ,staff.name as 'staff', totalPrice, status from bill join staff on bill.idStaff = staff.id join guest on guest.id = bill.idGuest";

            return DataManager.Instance.ExecuteOuery(query);
        }
    }
}
