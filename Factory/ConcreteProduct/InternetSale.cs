using Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ConcreteProduct
{
    public class InternetSale : ISale
    {
        private decimal _descuento;
        public InternetSale(decimal descuento)
        {
            _descuento = descuento;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta por INTERNERT tiene un total de{total - _descuento}");
        }
    }
}
