using Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Creator
{
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }
}
