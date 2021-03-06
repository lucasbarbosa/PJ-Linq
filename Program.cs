using Linq.Classes;

namespace Linq
{
    public class Program
    {
        private static ITestLinq linq;

        static void Main(string[] args)
        {
            linq = ExerciciosFactory.Method(14);
            linq.Executar();
        }
    }
}