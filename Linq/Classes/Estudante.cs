using System.Collections.Generic;

namespace Linq.Classes
{
    public class Estudante
    {
        public string Nome { get; set; }

        public string Sexo { get; set; }

        public List<string> Materias { get; set; }

        public static List<Estudante> ObterEstudantes()
        {
            var lista = new List<Estudante>
            {
                new Estudante
                {
                    Nome = "Pedro",
                    Sexo = "M",
                    Materias = new List<string>{ "C#", "Controle", "IoT", "C" }
                },
                new Estudante
                {
                    Nome = "Luciane",
                    Sexo = "F",
                    Materias = new List<string>{ "Direito", "Letras" }
                },
                new Estudante
                {
                    Nome = "Isabela",
                    Sexo = "F",
                    Materias = new List<string>{ "Civil", "C", "Mecânica" }
                },
                new Estudante
                {
                    Nome = "Carlos",
                    Sexo = "M",
                    Materias = new List<string>{ "Psicologia Geral" }
                }
            };

            return lista;
        }
    }
}
