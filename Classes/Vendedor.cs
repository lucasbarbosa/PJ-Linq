using System.Collections.Generic;

namespace Linq.Classes
{
    public class Vendedor
    {
        public int Id { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public int VendasSemestrais { get; set; }

        public string Sexo { get; set; }

        public int RegiaoId { get; set; }

        public static IEnumerable<Vendedor> ObterTodos() {
            return new List<Vendedor>
            {
                new Vendedor
                {
                    Id = 1,
                    PrimeiroNome = "Paulo",
                    UltimoNome = "Jesus",
                    VendasSemestrais = 1200,
                    Sexo = "M",
                    RegiaoId = 1
                },
                new Vendedor
                {
                    Id = 2,
                    PrimeiroNome = "Pedro",
                    UltimoNome = "Silva",
                    VendasSemestrais = 1800,
                    Sexo = "M",
                    RegiaoId = 2
                },
                new Vendedor
                {
                    Id = 3,
                    PrimeiroNome = "Carla",
                    UltimoNome = "Castro",
                    VendasSemestrais = 1800,
                    Sexo = "F",
                    RegiaoId = 2
                },
                new Vendedor
                {
                    Id = 4,
                    PrimeiroNome = "Luciana",
                    UltimoNome = "Magalhães",
                    VendasSemestrais = 2000,
                    Sexo = "F",
                    RegiaoId = 1
                },
                new Vendedor
                {
                    Id = 5,
                    PrimeiroNome = "Paola",
                    UltimoNome = "Magalhães",
                    VendasSemestrais = 1800,
                    Sexo = "F",
                    RegiaoId = 3
                },
                new Vendedor
                {
                    Id = 6,
                    PrimeiroNome = "Luis",
                    UltimoNome = "Silva",
                    VendasSemestrais = 1200,
                    Sexo = "M",
                    RegiaoId = 2
                },
                new Vendedor
                {
                    Id = 7,
                    PrimeiroNome = "João",
                    UltimoNome = "Silva",
                    VendasSemestrais = 1800,
                    Sexo = "M",
                    RegiaoId = 1
                },
                new Vendedor
                {
                    Id = 7,
                    PrimeiroNome = "João",
                    UltimoNome = "Silva",
                    VendasSemestrais = 1800,
                    Sexo = "M",
                    RegiaoId = 1
                },
                new Vendedor
                {
                    Id = 8,
                    PrimeiroNome = "Claudia",
                    UltimoNome = "Souza",
                    VendasSemestrais = 1300,
                    Sexo = "F"
                }
            };
        }
    }
}