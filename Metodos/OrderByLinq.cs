using Linq.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class OrderByLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("ORDER_BY");

            List<Estudante> lista = Estudante.ObterEstudantes();

            #region Linq

            Titulo.ExibirSub("LINQ");
            var ordenar = lista
                            .OrderBy(x => x.Sexo)
                            .ThenByDescending(x => x.Materias.Count)
                            .ThenBy(x => x.Nome);

            foreach (var item in ordenar)
                Console.WriteLine($"{item.Nome} \t {item.Sexo} \t {item.Materias.Count}");

            #endregion

            #region Sql

            Titulo.ExibirSub("SQL");
            var sql = (from e in lista
                      orderby e.Sexo, e.Materias.Count descending
                      select e).ThenBy(x => x.Nome);

            foreach (var item in sql)
                Console.WriteLine($"{item.Nome} \t {item.Sexo} \t {item.Materias.Count}");

            #endregion

            Console.ReadKey();
        }
    }
}