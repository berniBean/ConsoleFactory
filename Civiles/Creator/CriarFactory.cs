using Civiles.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiles.Creator
{
    public abstract class CriarFactory
    {
        public abstract ICriar GetCriado();
    }
}
