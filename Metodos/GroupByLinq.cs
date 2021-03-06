using Linq.Classes;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class GroupByLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("GROUP_BY");

            var vendedores = Vendedor.ObterTodos();

            #region Linq

            Titulo.ExibirSub("LINQ");
            var grupoLinq = vendedores.GroupBy(x => x.VendasSemestrais);

            foreach(var item in grupoLinq)
            {
                Console.WriteLine($"{item.Key} - {item.Count()}");
                foreach (var v in item)
                    Console.WriteLine($"\t {v.PrimeiroNome} {v.UltimoNome}");
            }

            #endregion

            #region Sql

            Titulo.ExibirSub("SQL");
            var grupoSql = from v in vendedores
                           group v by v.VendasSemestrais into vGrupo
                           //select vGrupo;
                           select new
                           {
                               Key = vGrupo.Key,
                               Vendedor = vGrupo.OrderBy(x => x.PrimeiroNome)
                           };

            foreach (var item in grupoSql)
            {
                Console.WriteLine($"{item.Key} - {item.Vendedor.Count()}");
                foreach (var v in item.Vendedor)
                    Console.WriteLine($"\t {v.PrimeiroNome} {v.UltimoNome}");
            }

            #endregion

            Console.ReadKey();
        }
    }
}