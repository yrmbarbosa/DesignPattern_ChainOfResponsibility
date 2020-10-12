using System;
using System.Collections.Generic;
using System.Text;

namespace nao_aplicado
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {

            //Desconto de 10% caso existam mais de 5 itens
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            //Desconto de 7% caso o valor seja maior que 500
            else if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.07;
            }

            return 0;

        }
    }
}
