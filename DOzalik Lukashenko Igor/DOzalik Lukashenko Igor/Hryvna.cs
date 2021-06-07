using System;
using System.Collections.Generic;
using System.Text;

namespace DOzalik_Lukashenko_Igor
{
    public class Hryvna : MoneyBase//Українська гривня
    {
        
        public int Number { get; private set; }//номер

        
        public int Denomination { get; private set; }//Номінал валюти

        
        public Hryvna(int denomination)//Створення нового екземпляру гривні
            : base("Українська гривня", "₴")
        {
            // Перевірка на корректність
            if (denomination <= 0)
            {
                throw new ArgumentException("Номинал валюты должен быть больше нуля.", nameof(denomination));
            }

            
            var rnd = new Random();

            // Встановлюємо значення.
            Number = rnd.Next(1000, 9999);
            Denomination = denomination;
        }

        
        public override string ToString()
        {
            return $"{Name} {Number} номиналом {Denomination}{Symbol}";//інформацію про купюру
        }
    }
}

