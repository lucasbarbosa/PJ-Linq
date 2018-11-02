using Linq.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class SelectManyLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("SELECTMANY");

            var lista = Estudante.ObterEstudantes();

            Titulo.ExibirSub("Select");

            IEnumerable<List<string>> materias = lista.Select(x => x.Materias);

            foreach (var item in materias)
                foreach(var m in item)
                    Console.WriteLine(m);

            Titulo.ExibirSub("Many");

            IEnumerable<string> many = lista.SelectMany(x => x.Materias).Distinct();

            foreach (var item in many)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
