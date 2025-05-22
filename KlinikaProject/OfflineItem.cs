using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_BACK_OFFICE
{
    public class OfflineItem
    {
            public string Barcode { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public decimal Quantity { get; set; }
            public DateTime Date { get; set; }

            public bool IsSent { get; set; } // 🆕 yeni sahə

    }

}
