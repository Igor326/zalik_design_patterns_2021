using System;
using System.Collections.Generic;
using System.Text;

namespace DOzalik_Lukashenko_Igor
{
    public abstract class MoneyBase//Базовий клас для будь-якої валюти.
    {
        public string Name { get; protected set; }//Назва валюти

        public string Symbol { get; protected set; }//Символ валюти

        public MoneyBase(string name, string symbol)
        {
            // Перевіряємо дані на корректність
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrEmpty(symbol))
            {
                throw new ArgumentNullException(nameof(symbol));
            }

            //Встановлюємо значення.
            Name = name;
            Symbol = symbol;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
