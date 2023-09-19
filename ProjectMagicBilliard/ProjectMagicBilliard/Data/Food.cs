using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.Data
{
    public class Food
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string IdCategory { get; set; }

        public Food()
        {
        }

        public  Food(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Name = row["name"].ToString();
            this.Price = (double)row["price"];
            this.IdCategory = row["idCategory"].ToString();
        }
    }
}
