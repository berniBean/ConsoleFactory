using Civiles.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiles.Creator
{
    public abstract class EntrenarFactory : IEntrenar
    {
        public void Entrenar(string sexo)
        {
            throw new NotImplementedException();
        }
    }
}
