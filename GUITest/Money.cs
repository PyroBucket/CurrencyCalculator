using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculator
{
    public class Money
    {
        private string _currencyCode;
        private Decimal _value;

        public string CurrencyCode => _currencyCode;
        public Decimal Value => _value;

        public Money(string currencyCode, Decimal value)
        {
            _currencyCode = currencyCode;
            _value = value;
        }
        
        public static implicit operator Money(Decimal v)
        {
            return new Money("EUR", v);
        }

        public override string ToString()
        {
            return Value.ToString() + " " + CurrencyCode;
        }
        public static Money operator *(Money amount1, Decimal amount2)
        {
            return new Money(amount1.CurrencyCode, amount1.Value * amount2);
        }
        public static Money operator /(Money amount1, Decimal amount2)
        {
            return new Money(amount1.CurrencyCode, amount1.Value / amount2);
        }

        public static Money operator +(Money amount1, Money amount2)
        {
            if (amount1._currencyCode != amount2._currencyCode)
                throw new InvalidOperationException("Cannot add different currencies");

            return new Money(amount1.CurrencyCode, amount1.Value + amount2.Value);
        }

        public static Money operator -(Money amount1, Money amount2)
        {
            if (amount1._currencyCode != amount2._currencyCode)
                throw new InvalidOperationException("Cannot add different currencies");

            return new Money(amount1.CurrencyCode, amount1.Value - amount2.Value);
        }

        public static bool operator >(Money amount1, Money amount2)
        {
            if (amount1._currencyCode != amount2._currencyCode)
                throw new InvalidOperationException("Cannot compare amounts of different currencies");

            return amount1._value > amount2._value;
        }
        public static bool operator <(Money amount1, Money amount2)
        {
            if (amount1._currencyCode != amount2._currencyCode)
                throw new InvalidOperationException("Cannot compare amounts of different currencies");

            return amount1._value < amount2._value;
        }


    }
}
