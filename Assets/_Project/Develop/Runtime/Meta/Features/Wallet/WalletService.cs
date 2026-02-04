using Assets._Project.Develop.Runtime.Utilities.Reactive;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets._Project.Develop.Runtime.Meta.Features.Wallet
{
    public class WalletService
    {
        private readonly Dictionary<CurrencyTypes, ReactiveVariable<int>> _currencies;

        public WalletService(Dictionary<CurrencyTypes, ReactiveVariable<int>> currencies)
        {
            _currencies = new Dictionary<CurrencyTypes, ReactiveVariable<int>>(currencies);
        }

        public List<CurrencyTypes> AvailableCurrencies => _currencies.Keys.ToList();

        public IReadOnlyVariable<int> GetCurrency(CurrencyTypes currencyType) => _currencies[currencyType];

        public bool Enought(CurrencyTypes type, int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            return _currencies[type].Value >= amount;
        }

        public void Add(CurrencyTypes type, int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            _currencies[type].Value += amount;
        }

        public void Spend(CurrencyTypes type, int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            if (Enought(type, amount) == false)
                throw new InvalidOperationException("Not enought: " + type.ToString());

            _currencies[type].Value -= amount;
        }
    }
}
