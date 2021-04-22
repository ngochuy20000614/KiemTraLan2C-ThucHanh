using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.EF
{
    public class ConnectionString
    {
        private static string cName = "Data Source=.; database=UTEWEBSHOP2019; integrated security=SSPI";
        public static string CName
        {
            get => cName;
        }
    }
}
