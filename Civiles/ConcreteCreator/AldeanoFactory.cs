using Civiles.ConcreteProduct;
using Civiles.Creator;
using Civiles.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiles.ConcreteCreator
{
    public class AldeanoFactory : CriarFactory
    {
        private string _sexo;

        public AldeanoFactory(string sexo)
        {
            _sexo = sexo;
        }

        public override ICriar GetCriado()
        {
            return new Aldeano(_sexo); 
        }
    }
}
