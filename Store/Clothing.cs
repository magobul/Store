using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store
{
    public class Clothing : Product
    {
        public string Size { get; set; }

        public override string GetInformation()
        {
            return $"Одежда: {Name}, Размер: {Size}, Цена: {Price:C}";
        }
    }
}
