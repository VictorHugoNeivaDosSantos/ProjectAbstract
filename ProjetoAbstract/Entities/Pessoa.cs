using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAbstract.Entities
{

    abstract class Pessoa
    {
       

        public string Nome { get; protected set; }
        public double Renda { get; protected set; }

        public Pessoa(string nome, double renda)
        {
            Nome = nome;
            Renda = renda;
        }

        protected Pessoa()
        {
        }

        public abstract double CalculoImposto();

       
    }
}
