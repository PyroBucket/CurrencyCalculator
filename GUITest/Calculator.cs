using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculator
{
    public class Calculator
    {
        private Dictionary<string, Decimal> _exchangeRates;

        public Calculator()
        {
            _exchangeRates = new Dictionary<string, Decimal>();
        }
        public Calculator(Dictionary<string, decimal> exchangeRates)
        {
            _exchangeRates = exchangeRates;
        }

        public Money Convert(Money money, string desiredCurrency)
        {
            Decimal exchangeRate;
            try
            {
                exchangeRate = _exchangeRates[desiredCurrency];
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Desired currency not found in the exchange rates provided");
                throw;
            }

            Decimal convertedAmount = money.Value * exchangeRate;
            return new Money(desiredCurrency, convertedAmount);
        }
    }
}
