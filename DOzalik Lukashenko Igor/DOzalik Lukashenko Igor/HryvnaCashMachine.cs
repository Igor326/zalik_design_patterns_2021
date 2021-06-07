using System;
using System.Collections.Generic;
using System.Text;

namespace DOzalik_Lukashenko_Igor
{
    public class HryvnaCashMachine : CashMachineBase
    {
        
        private readonly int _countOnPage = 64;//кількість купюр на одному аркуші пперу

       
        private int _denomination;//Номінал купюри

        
        private int[] _correntDenomination = { 50, 100, 200, 500, 1000, 2000, 5000 };//Можливі номінали валюти

        public HryvnaCashMachine(int denomination = 1000)//Створити новий екземпляр пристрою для друку.
            : base("Устройство для печати российских рублей")
        {
            // Перевірка вхідних даних.
            if (denomination <= 0)
            {
                throw new ArgumentException("Номинал валюты должен быть больше нуля.", nameof(denomination));
            }

           

            // Встановлюємо значення.
            _denomination = denomination;
        }

       
        public override MoneyBase[] Create(int pageCount)
        {
            // Підраховуємо к-сть сторінок.
            var count = _countOnPage * pageCount;

            //Створюємо колекцію для зберігання грошей.
            var money = new List<MoneyBase>();

            //Створюємо гроші і додаємо в колекцію.
            for (var i = 0; i < count; i++)
            {
                var ruble = new Hryvna(_denomination);
                money.Add(ruble);
            }

            // Повертаємо гроші.
            return money.ToArray();
        }
    }
}

