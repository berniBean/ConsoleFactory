using Factory.ConcreteProduct;
using Factory.Creator;
using Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ConcreteCreator
{
    public class InternetSaleFactory : SaleFactory
    {
        private decimal _descuento;
        public InternetSaleFactory(decimal descuento)
        {
            _descuento = descuento;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_descuento);
        }
    }
}
