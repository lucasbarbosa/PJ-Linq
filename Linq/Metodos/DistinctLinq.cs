using Linq.Classes;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class DistinctLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("DISTINCT");

            string[] paises = { "BR", "br", "eua", "uk", "UK", "BR" };

            #region Distinct

            Titulo.ExibirSub("Padrão");

            var resultado = paises.Distinct();

            foreach (var item in resultado)
                Console.WriteLine(item);

            #endregion

            #region OrdinalIgnoreCase

            Titulo.ExibirSub("OrdinalIgnoreCase");

            var resultadoIgnore = paises.Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var item in resultadoIgnore)
                Console.WriteLine(item);

            #endregion

            #region DistinctComplexo

            Titulo.ExibirSub("Vendedores");

            // Todo: Distinct para tipo complexo
            var vendedores = Vendedor.ObterTodos()
                                        .Select(x => new {
                                            Id = x.Id,
                                            PrimeiroNome = x.PrimeiroNome,
                                            UltimoNome = x.UltimoNome,
                                            VendasSemestrais = x.VendasSemestrais,
                                            Sexo = x.Sexo,
                                            RegiaoId = x.RegiaoId
                                        })
                                        .Distinct();

            foreach (var item in vendedores)
                Console.WriteLine(item.Id);

            #endregion

            Console.ReadKey();
        }
    }
}
