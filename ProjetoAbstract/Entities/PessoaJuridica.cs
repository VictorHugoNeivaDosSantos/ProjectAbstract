﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAbstract.Entities
{
    class PessoaJuridica : Pessoa
    {

        public int NFuncionario { get; protected set; }

        public PessoaJuridica(string nome, double renda,int nFuncionario) : base(nome, renda) 
        {
            NFuncionario = nFuncionario;
        }



        public override double CalculoImposto()
        {

            double imposto = 0;

            if (NFuncionario > 10)
            {
                imposto = (Renda * 0.14);
            }
            else
            {

                imposto = (Renda * 0.16);

            }

            return imposto;

        }
     
    }
}
