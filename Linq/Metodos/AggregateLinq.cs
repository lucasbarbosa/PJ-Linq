using Linq.Classes;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class AggregateLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("AGGREGATE");

            string[] nomes = { "João", "da", "Silva", "Saulo" };
            var resultado = nomes.Aggregate((a, b) => a + " " + b);

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
