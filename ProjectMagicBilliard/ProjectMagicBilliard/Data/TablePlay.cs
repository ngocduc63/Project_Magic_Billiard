using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.Data
{
    class TablePlay
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public StatusTableEnum Status { get; set; }
        public string Price { get; set; }
    }
}
