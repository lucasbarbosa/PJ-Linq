using Linq.Classes;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class TakeLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("TAKE");

            #region Listas

            string[] paises = { "BR", "JP", "AU", "AL", "EUA", "URU", "FRN", "CBA" };
            string[] paises2 = { "EUA", "URU", "FRN", "BR", "JP", "AU", "AL", "CBA" };

            #endregion

            #region Take

            Titulo.ExibirSub("TAKE LINQ");
            var take = paises.Take(3);

            foreach (var item in take)
                Console.WriteLine(item);

            Titulo.ExibirSub("TAKE SQL");
            var takeSql = (from p in paises
                          select p).Take(3);

            foreach (var item in takeSql)
                Console.WriteLine(item);

            #endregion

            #region Take.Reverse

            Titulo.ExibirSub("TAKE.REVERSE LINQ");
            var takeReverse = paises.Take(3).Reverse().ToList();

            foreach (var item in takeReverse)
                Console.WriteLine(item);

            #endregion

            #region TakeWhile

            Titulo.ExibirSub("TAKE_WHILE");
            var takeWhile = paises.TakeWhile(x => x.Length == 2);

            foreach (var item in takeWhile)
                Console.WriteLine(item);

            #endregion

            #region Skip

            Titulo.ExibirSub("SKIP");
            var skip = paises.Skip(3);

            foreach (var item in skip)
                Console.WriteLine(item);

            #endregion

            #region SkipWhile

            Titulo.ExibirSub("SKIP_WHILE");
            var skipWhile = paises2.SkipWhile(x => x.Length > 2);

            foreach (var item in skipWhile)
                Console.WriteLine(item);

            #endregion

            Console.ReadKey();
        }
    }
}
