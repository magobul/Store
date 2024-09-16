using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store
{
    public class Electronics : Product
    {
        public int WarrantyPeriod { get; set; } // в месяцах

        public override string GetInformation()
        {
            return $"Электронника: {Name}, Гарантия: {WarrantyPeriod} месяцев, Цена: {Price:C}";
        }
    }
}
