using Linq.Metodos;

namespace Linq
{
    public class Program
    {
        private static ITestLinq linq;

        static void Main(string[] args)
        {
            linq = Factory.Method(14);
            linq.Executar();
        }
    }

    static class Factory
    {
        public static ITestLinq Method(int id)
        {
            switch (id)
            {
                case 0:
                    return new AggregateLinq();
                case 1:
                    return new WhereLinq();
                case 2:
                    return new SelectLinq();
                case 3:
                    return new SelectManyLinq();
                case 4:
                    return new OrderByLinq();
                case 5:
                    return new TakeLinq();
                case 6:
                    return new IEnumerableLinq();
                case 7:
                    return new ConversoresLinq();
                case 8:
                    return new GroupByLinq();
                case 9:
                    return new GroupBy2Linq();
                case 10:
                    return new GroupJoinLinq();
                case 11:
                    return new InnerJoinLinq();
                case 12:
                    return new OperadoresLinq();
                case 13:
                    return new LeftJoinLinq();
                case 14:
                    return new DistinctLinq();
                default:
                    return new InvalidMethod();
            }
        }
    }
}
