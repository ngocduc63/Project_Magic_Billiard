using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMagicBilliard.Data
{
    public enum StatusTableEnum
    {
        [StringValue("Trống")] Empty = 0,
        [StringValue("Có người")] Full = 1
    }
    public enum StatusBillEnum
    {
        [StringValue("Chưa thanh toán")] NotPaid = 0,
        [StringValue("Đã thanh toán")] Paid = 1
    }
}
