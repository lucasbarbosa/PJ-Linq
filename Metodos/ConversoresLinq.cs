using Linq.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class ConversoresLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("CONVERSORES");

            #region Listas

            string[] paises = { "EUA", "URU", "FRN", "BR", "JP", "AU", "AL", "CBA" };
            List<Vendedor> lista = Vendedor.ObterTodos().ToList();

            #endregion

            #region Array

            Titulo.ExibirSub("ARRAY");

            for (int i = 0; i < paises.Length; i++)
                Console.WriteLine(paises[i]);

            #endregion

            #region ToList

            Titulo.ExibirSub("TO_LIST");

            var result = paises.ToList();
            foreach(var item in result)
                Console.WriteLine(item);

            #endregion

            #region Dictionary

            Titulo.ExibirSub("TO_DICTIONARY - TIPO PRIMITIVO");

            Dictionary<int, string> vendedorPrimitivo = lista.ToDictionary(x => x.Id, x => x.PrimeiroNome);

            foreach (var item in vendedorPrimitivo)
                Console.WriteLine($"{item.Key} : {item.Value}");

            Titulo.ExibirSub("TO_DICTIONARY - TIPO COMPLEXO");

            Dictionary<int, Vendedor> vendedorComplexo = lista.ToDictionary(x => x.Id);

            foreach (var item in vendedorComplexo)
                Console.WriteLine($"{item.Key} : {item.Value.PrimeiroNome} \t {item.Value.VendasSemestrais}");

            #endregion

            #region ToLookup

            Titulo.ExibirSub("TO_LOOKUP");

            var resultLookup = lista.ToLookup(x => x.VendasSemestrais);
            foreach (var item in resultLookup)
            { 
                Console.WriteLine(item.Key);
                foreach (var v in resultLookup[item.Key])
                    Console.WriteLine($"\t {v.PrimeiroNome} {v.UltimoNome}");
            }

            #endregion

            #region ToArray

            Titulo.ExibirSub("TO_ARRAY");

            string[] colec = lista.Select(x => x.UltimoNome).Distinct().ToArray();

            for (int i = 0; i < colec.Length; i++)
                Console.WriteLine(colec[i]);

            #endregion

            Console.ReadKey();
        }
    }
}