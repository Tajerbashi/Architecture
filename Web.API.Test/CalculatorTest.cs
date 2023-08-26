using Web.API.Services;

namespace Web.API.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Should_Return_When_Sum1And2()
        {
            CalculatorService calculator = new CalculatorService();
            int result1 = calculator.Sum(15,44);
            int result2 = calculator.Sum(44,-1);
            int result3 = calculator.Sum(258,0);
            int result4 = calculator.Sum(150000,2015);

            Assert.Equal(59, result1);
            Assert.Equal(43, result2);
            Assert.Equal(258, result3);
            Assert.Equal(152015, result4);
        }
    }
}