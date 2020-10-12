using System;
using System.Collections.Generic;
using System.Text;

namespace aplicado
{
    public interface Desconto
    {
        Desconto Proximo { get; set; }
        double AplicaDesconto(Orcamento orcamento);
    }
}
