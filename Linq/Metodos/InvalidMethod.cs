using Linq.Classes;
using System;

namespace Linq.Metodos
{
    public class InvalidMethod : ITestLinq
    {
        public void Executar()
        {
            Titulo.ExibirSub("MÉTODO INVÁLIDO");

            Console.ReadKey();
        }
    }
}
