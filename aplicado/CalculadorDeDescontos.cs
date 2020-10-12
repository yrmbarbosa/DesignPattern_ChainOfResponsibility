using System;
using System.Collections.Generic;
using System.Text;

namespace aplicado
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {

            // Implementação da corrente de responsabilidades
            Desconto d1 = new DescontoPorMaisDeCincoItens();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto sd = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = sd;

            return d1.AplicaDesconto(orcamento);

        }
    }
}
