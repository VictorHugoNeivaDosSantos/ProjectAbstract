using System;
using ProjetoAbstract.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoAbstract
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> lista = new List<Pessoa>();


            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(name, income, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(name, income, numberOfEmployees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Pessoa tp in lista)
            {
                double tax = tp.CalculoImposto();
                Console.WriteLine(tp.Nome + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;

            }

            Console.WriteLine("Total: " + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
