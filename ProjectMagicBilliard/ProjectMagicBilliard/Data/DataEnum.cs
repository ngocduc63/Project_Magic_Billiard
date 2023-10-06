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
        [StringValue("Có người")] Full = 1,
        [StringValue("Chờ thanh toán")] WaitPay = 2
    }
    public enum StatusBillEnum
    {
        [StringValue("Chưa thanh toán")] NotPaid = 0,
        [StringValue("Đã thanh toán")] Paid = 1
    }

    public enum TableCategory
    {
        [StringValue("Aplus")] aplus = 1,
        [StringValue("MrSung")] mrsung = 2,
        [StringValue("KKing")] kking = 3,

    }
}
