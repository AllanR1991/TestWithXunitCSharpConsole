using ConversaoTemperatura;

namespace TestConversaoTemperatura
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int celsius = 50;
            float result = 122; 

            float conversaoCelsiusFahrenheit = Temperatura.ConverterCelsiusParaFahrenheit(celsius);

            Assert.Equal(result, conversaoCelsiusFahrenheit);
        }
    }
}