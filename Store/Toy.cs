using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Toy : Product
    {
        public string Material { get; set; }

        public override string GetInformation()
        {
            return $"Название: {Name}, Материал: {Material}, Цена: {Price:C}";
        }
    }
}
