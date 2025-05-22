using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DevExpress.XtraReports.Serialization;



namespace POS_BACK_OFFICE
{
    internal class mssqlBaglanti

    {
            public string conString = ((IEnumerable<string>)File.ReadAllLines("Solution.jpg")).FirstOrDefault<string>();
    }
}
