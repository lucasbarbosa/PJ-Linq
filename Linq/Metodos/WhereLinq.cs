using Linq.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class WhereLinq : ITestLinq
    {
        List<int> numeros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void Executar()
        {
            Titulo.Exibir("WHERE");

            #region Linq

            Titulo.ExibirSub("LINQ");

            var resultadoLinq = numeros.Where(x => x % 2 == 0);
            foreach (var item in resultadoLinq)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Sql

            Titulo.ExibirSub("SQL");
            var resultadoSql = from pares in numeros
                               where pares % 2 == 0
                               select pares;
            foreach (var item in resultadoSql)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
