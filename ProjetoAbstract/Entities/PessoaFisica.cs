using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAbstract.Entities
{
    class PessoaFisica : Pessoa
    {

        public double GastoSaude { get; protected set; }


        public PessoaFisica(string nome, double renda, double gastoSaude) : base(nome, renda)
        {
            GastoSaude = gastoSaude;

        }



        public override double CalculoImposto()
        {


            double imposto = 0;
            if (Renda >= 20000)
            {

                imposto = (Renda * 0.25) - (GastoSaude * 0.5);

            }
            else
            {


                imposto = (Renda * 0.15) - (GastoSaude * 0.5);


            }


            return imposto;

        }
      
    }
}
