using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product
    {
        public string Name { get; set; }
        public virtual decimal Price { get; set; }

        public abstract string GetInformation();
    }
}
