using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store
{
    public class Meat : Product
    {
        public double Weight { get; set; } // в килограммах

        public override string GetInformation()
        {
            return $"Мясо: {Name}, Вес: {Weight} кг, Цена: {Price:C}";
        }
    }
}
