using System;
using System.Collections.Generic;
using System.Text;

namespace aplicado
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public Desconto Proximo { get; set; }
        //Desconto de 7% caso o valor seja maior que 500
        public double AplicaDesconto(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.07;
            }
            return Proximo.AplicaDesconto(orcamento);
        }
    }
}
