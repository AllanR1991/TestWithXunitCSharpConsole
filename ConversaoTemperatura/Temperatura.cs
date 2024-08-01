using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperatura
{
    public class Temperatura
    {
        public static float ConverterCelsiusParaFahrenheit(int celsius)
        {
            return ((celsius * (9F/5F)) + 32F);
        }
    }
}
