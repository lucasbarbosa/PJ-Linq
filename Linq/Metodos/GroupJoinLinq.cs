using Linq.Classes;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class GroupJoinLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("GROUP_JOIN");

            var vendedores = Vendedor.ObterTodos();

            #region Linq

            Titulo.ExibirSub("LINQ");
            var grupo = Regiao.ObterTodos()
                                    .GroupJoin(vendedores,
                                                r => r.Id,
                                                v => v.RegiaoId,
                                                (regiao,vendedor) => new {
                                                    Vendedor = vendedor,
                                                    Regiao = regiao
                                                });

            foreach (var item in grupo)
            {
                Console.WriteLine(item.Regiao.Nome);
                foreach (var vendedor in item.Vendedor)
                    Console.WriteLine($"\t {vendedor.PrimeiroNome} {vendedor.UltimoNome}");
                Console.WriteLine();
            }

            #endregion

            #region Sql

            Titulo.ExibirSub("SQL");
            var grupoSql = from r in Regiao.ObterTodos()
                           join v in Vendedor.ObterTodos()
                           on r.Id equals v.RegiaoId into vGrupo
                           select new
                           {
                               Vendedor = vGrupo,
                               Regiao = r
                           };

            foreach (var item in grupoSql)
            {
                Console.WriteLine(item.Regiao.Nome);
                foreach (var vendedor in item.Vendedor)
                    Console.WriteLine($"\t {vendedor.PrimeiroNome} {vendedor.UltimoNome}");
                Console.WriteLine();
            }

            #endregion

            Console.ReadKey();
        }
    }
}
