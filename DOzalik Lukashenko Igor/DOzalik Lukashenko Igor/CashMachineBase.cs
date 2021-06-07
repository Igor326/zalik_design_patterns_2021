using System;
using System.Collections.Generic;
using System.Text;

namespace DOzalik_Lukashenko_Igor
{
    public abstract class CashMachineBase//Базовий клас для пристроїв друку грошей 
    {
        
        public string Name { get; protected set; }//Назва пристрою

        public CashMachineBase(string name)/// Конструктор для створення нового екземпляру пристрою для друку .
        {
            // Перевіряємо дані на корректність.
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            // Встановлюємо значення.
            Name = name;
        }
        
        public abstract MoneyBase[] Create(int pageCount);//Надрукувати нову партію грошей

        
        public override string ToString() // Приводимо об'єкт до String'а.
        {
            return Name;
        }
    }
}
