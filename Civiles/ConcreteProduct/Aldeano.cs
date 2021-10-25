using Civiles.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiles.ConcreteProduct
{
    public class Aldeano : ICriar
    {
        private string _sexo;
        public Aldeano(string sexo)
        {
            _sexo = sexo;
        }

        public void Criar()
        {
            Console.WriteLine($"Aldeando:Creación finalizada. {_sexo}");
        }
    }
}
