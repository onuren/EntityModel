using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriKatmani
{
    public class ConnectionString_VeriYolu
    {
        //static alanlar nesne oluşturmaya gerek duymadan derleme aşamasında RAM üzerinde oluşurlar. Stack bölgesinde tutulurlar.
        public static string ConStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = My_DB;Integrated Security = True";
    }
}
