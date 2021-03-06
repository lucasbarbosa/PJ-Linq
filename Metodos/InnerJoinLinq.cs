using Linq.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class InnerJoinLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("INNER_JOIN");

            #region Linq

            Titulo.ExibirSub("LINQ");

            List<Vendedor> vendedores = Vendedor.ObterTodos().ToList();

            vendedores.Add(new Vendedor { Id = 20, PrimeiroNome = "Carlos", UltimoNome = "Silva", VendasSemestrais = 800 });
            vendedores.Add(new Vendedor { Id = 21, PrimeiroNome = "Sandro", UltimoNome = "Silva", VendasSemestrais = 800, RegiaoId = 5 });
            vendedores.Add(new Vendedor { Id = 22, PrimeiroNome = "Antonio", UltimoNome = "Silva", VendasSemestrais = 800, RegiaoId = 8 });

            var grupo = vendedores
                            .Join(Regiao.ObterTodos(),
                                    v => v.RegiaoId,
                                    r => r.Id,
                                    (v,r) => new
                                    {
                                        Vendedor = $"{v.PrimeiroNome} {v.UltimoNome}",
                                        Regiao = r.Nome
                                    });

            foreach(var item in grupo)
            {
                Console.WriteLine($"{item.Vendedor} - {item.Regiao}");
            }

            #endregion

            #region Sql

            Titulo.ExibirSub("SQL");

            var grupoSql = from v in Vendedor.ObterTodos()
                           join r in Regiao.ObterTodos()
                           on v.RegiaoId equals r.Id
                           select new
                           {
                               Vendedor = $"{v.PrimeiroNome} {v.UltimoNome}",
                               Regiao = r.Nome
                           };

            foreach (var item in grupoSql)
            {
                Console.WriteLine($"{item.Vendedor} - {item.Regiao}");
            }

            #endregion

            Console.ReadKey();
        }
    }
}