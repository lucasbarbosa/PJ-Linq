using Linq.Classes;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class OperadoresLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("OPERADORES");

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] vazio = { };

            var first = numeros.First();
            Console.WriteLine($"first: {first}");

            var firstComplexo = numeros.First(x => x % 2 == 0 && x % 3 == 0);
            Console.WriteLine($"firstComplexo: {firstComplexo}");

            var firstPadrao = numeros.FirstOrDefault(x => x % 2 == 0 && x % 10 == 0);
            Console.WriteLine($"firstPadrao: {firstPadrao}");

            var elemento = numeros.ElementAt(0);
            Console.WriteLine($"elemento: {elemento}");

            var elementoPadrao = numeros.ElementAtOrDefault(9);
            Console.WriteLine($"elementoPadrao: {elementoPadrao}");

            var padraoNumeros = numeros.DefaultIfEmpty();
            foreach(var item in padraoNumeros)
                Console.WriteLine($"- padraoNumeros: {item}");

            var padraoVazio = vazio.DefaultIfEmpty(404);
            foreach (var item in padraoVazio)
                Console.WriteLine($"- padraoVazio: {item}");

            Console.ReadKey();
        }
    }
}
