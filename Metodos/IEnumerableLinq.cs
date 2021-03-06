using Linq.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class IEnumerableLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("IENUMERABLE");

            List<Vendedor> lista = Vendedor.ObterTodos().ToList();

            var consultaSql = from v in lista
                           where v.Sexo == "M"
                           select v;

            var consultaLinq = (from v in lista
                              where v.Sexo == "M"
                              select v).ToList();

            lista.Add(new Vendedor() {
                Id = 8,
                PrimeiroNome = "Joselito",
                UltimoNome = "Santos",
                Sexo = "M",
                VendasSemestrais = 700
            });

            Titulo.ExibirSub("SQL");
            foreach (var item in consultaSql)
                Console.WriteLine(item.PrimeiroNome);

            Titulo.ExibirSub("LINQ");
            foreach (var item in consultaLinq)
                Console.WriteLine(item.PrimeiroNome);

            Console.ReadKey();
        }
    }
}