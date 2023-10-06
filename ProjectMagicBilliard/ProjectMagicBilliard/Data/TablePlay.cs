using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.Data
{
    public class TablePlay
    {
        public string Id { get; set; }
        public TableCategory IdCategpory { get; set; }
        public StatusTableEnum Status { get; set; }
        public double Price { get; set; }

        public TablePlay()
        {

        }

        public TablePlay(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Status = (StatusTableEnum) row["status"];
            this.IdCategpory = (TableCategory) row["idCategory"];
            this.Price = (double) row["price"];
        }
    }
}
