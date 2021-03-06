using Linq.Classes;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class GroupBy2Linq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("GROUP_BY2");

            #region Linq

            Titulo.ExibirSub("LINQ");
            var grupo = Vendedor.ObterTodos()
                                        .GroupBy(x => new { x.VendasSemestrais, x.Sexo })
                                        .OrderBy(k => k.Key.VendasSemestrais)
                                        .ThenBy(s => s.Key.Sexo)
                                        .Select(v => new {
                                            Vendas = v.Key.VendasSemestrais,
                                            Sexo = v.Key.Sexo,
                                            Vendedor = v.OrderBy(x => x.PrimeiroNome)
                                        });

            foreach (var item in grupo)
            {
                Console.WriteLine($"Os funcionários do sexo {item.Sexo} fizeram {item.Vendas} e são {item.Vendedor.Count()}:");
                Console.WriteLine("--------------------------------------------------------");

                foreach (var v in item.Vendedor)
                    Console.WriteLine($"{v.Id} : {v.PrimeiroNome} {v.UltimoNome}");

                Console.WriteLine();
            }

            #endregion

            #region Sql

            Titulo.ExibirSub("SQL");

            var grupoSql = from v in Vendedor.ObterTodos()
                           group v by new { v.VendasSemestrais, v.Sexo } into vGrupo
                           orderby vGrupo.Key.VendasSemestrais, vGrupo.Key.Sexo
                           select new
                           {
                               Vendas = vGrupo.Key.VendasSemestrais,
                               Sexo = vGrupo.Key.Sexo,
                               Vendedor = vGrupo.OrderBy(x => x.PrimeiroNome)
                           };

            foreach (var item in grupoSql)
            {
                Console.WriteLine($"Os funcionários do sexo {item.Sexo} fizeram {item.Vendas} e são {item.Vendedor.Count()}:");
                Console.WriteLine("--------------------------------------------------------");

                foreach (var v in item.Vendedor)
                    Console.WriteLine($"{v.Id} : {v.PrimeiroNome} {v.UltimoNome}");

                Console.WriteLine();
            }

            #endregion

            Console.ReadKey();
        }
    }
}