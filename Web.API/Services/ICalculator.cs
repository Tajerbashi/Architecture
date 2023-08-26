namespace Web.API.Services
{
    public interface ICalculator
    {
        int Sum(int a,int b);
    }

    public class CalculatorService : ICalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
