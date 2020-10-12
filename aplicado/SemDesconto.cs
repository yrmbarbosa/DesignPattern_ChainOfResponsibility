using System;
using System.Collections.Generic;
using System.Text;

namespace aplicado
{
    public class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }
        public double AplicaDesconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}
