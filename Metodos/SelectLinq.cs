using Linq.Classes;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class SelectLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("SELECT");

            Titulo.ExibirSub("IDs");
            var vendedores = Vendedor.ObterTodos();
            var ids = vendedores.Select(x => x.Id);
            foreach (var item in ids)
                Console.WriteLine(item);

            Titulo.ExibirSub("Anônimo");
            var objetoAnonimo = vendedores.Select(x => new { Nome = x.PrimeiroNome, Sexo = x.Sexo, Id = x.Id });
            foreach (var item in objetoAnonimo)
                Console.WriteLine($"{item.Id} \t {item.Nome} \t {item.Sexo}");

            Titulo.ExibirSub("Vendas Mensais");
            var vendasMensais = vendedores.Where(x => x.VendasSemestrais > 1500).Select(x => new {
                Nome = x.PrimeiroNome +"" + x.UltimoNome,
                Vendas = x.VendasSemestrais / 6,
                Id = x.Id
            });
            foreach (var item in vendasMensais)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}