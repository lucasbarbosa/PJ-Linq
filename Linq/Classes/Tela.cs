using System;
using System.Collections.Generic;

namespace Linq.Classes
{
    static class Tela
    {
        public static string Iniciar()
        {
            List<string> metodos = new List<string>() {
                "Aggregate",
                "Where",
                "Select",
                "SelectMany",
                "OrderBy",
                "Take",
                "IEnumerable",
                "Conversores",
                "GroupBy",
                "GroupBy2",
                "GroupJoin",
                "InnerJoin",
                "Operadores",
                "LeftJoin",
                "Distinct"
            };

            for (int i = 0; i < metodos.Count; i++)
                Console.WriteLine($"{i + 1} - {metodos[i]}");

            return Titulo.ExibirRead("Digite o número do método: ");
        }

        public static void Finalizar()
        {
            Titulo.ExibirRead("Pressione qualquer tecla para encerrar...");
        }
    }
}