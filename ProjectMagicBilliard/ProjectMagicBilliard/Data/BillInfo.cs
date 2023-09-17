using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.Data
{
    public class BillInfo
    {
        public string IdBill { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int QuantityFood { get; set; }
        public double TotalPrice
        {
            get
            {
                return Price * QuantityFood;
            }
        }

        public BillInfo()
        {

        }

        public BillInfo(DataRow row)
        {
            this.IdBill = row["id"].ToString();
            this.Name = row["name"].ToString();
            this.Price = (double) row["price"];
            this.QuantityFood = (int) row["quantityFood"];
        }
    }
}
