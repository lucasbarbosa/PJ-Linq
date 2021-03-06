using Linq.Interfaces;
using Linq.Metodos;

namespace Linq.Classes
{
    static class ExerciciosFactory
    {
        public static ITestLinq Method(string id)
        {
            switch (id)
            {
                case "1":
                    return new AggregateLinq();
                case "2":
                    return new WhereLinq();
                case "3":
                    return new SelectLinq();
                case "4":
                    return new SelectManyLinq();
                case "5":
                    return new OrderByLinq();
                case "6":
                    return new TakeLinq();
                case "7":
                    return new IEnumerableLinq();
                case "8":
                    return new ConversoresLinq();
                case "9":
                    return new GroupByLinq();
                case "10":
                    return new GroupBy2Linq();
                case "11":
                    return new GroupJoinLinq();
                case "12":
                    return new InnerJoinLinq();
                case "13":
                    return new OperadoresLinq();
                case "14":
                    return new LeftJoinLinq();
                case "15":
                    return new DistinctLinq();
                default:
                    return new InvalidMethod();
            }
        }
    }
}