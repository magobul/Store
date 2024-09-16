using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store
{
    public class Drinks : Product
    {
        public int Volume { get; set; } // в миллилитрах

        public override string GetInformation()
        {
            return $"Напиток: {Name}, Объем: {Volume} мл, Цена: {Price:C}";
        }
    }
}
