using System;
using System.Collections.Generic;
using System.Text;

namespace aplicado
{
    public class DescontoPorMaisDeCincoItens : Desconto
    {
        public Desconto Proximo { get; set; }
        //Desconto de 10% caso existam mais de 5 itens
        public double AplicaDesconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.AplicaDesconto(orcamento);
        }
    }
}
