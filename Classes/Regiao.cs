using System;
using System.Collections.Generic;

namespace Linq.Classes
{
    public class Regiao
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public static List<Regiao> ObterTodos() {
            return new List<Regiao>
            {
                new Regiao{Id = 1, Nome = "Sul"},
                new Regiao{Id = 2, Nome = "Sudeste"},
                new Regiao{Id = 3, Nome = "Centro-Oeste"},
                new Regiao{Id = 4, Nome = "Nordeste"},
                new Regiao{Id = 5, Nome = "Norte"}
            };
        }
    }
}