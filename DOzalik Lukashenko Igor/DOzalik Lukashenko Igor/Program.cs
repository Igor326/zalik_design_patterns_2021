using System;
using System.Collections.Generic;
using System.Text;

namespace DOzalik_Lukashenko_Igor
{
    //Фабричний метод.
    //Легенда 1. Пристрій для друку грошей.
    class Program
    {
        static void Main(string[] args)
        {
            

           
            //Створюємо колекцію пристроїв для друку.
            //Також ми можемо зберігати всі пристрої в одній колекції.

            var machines = new List<CashMachineBase>
            {
                new HryvnaCashMachine(),
               
            };

            //Створюємо колекцію для зберігання грошей.
            var money = new List<MoneyBase>();

            //Створюємо генератор випадкових чисел.
            var rnd = new Random();

            //Запускаємо пристрої по черзі(хочу в мене лише один пристрій).
            foreach (var machine in machines)
            {
                //Генеруємо випадкову к-сть аркушів.
                var pageCount = rnd.Next(1, 3);

                //Викликаємо фабричний метод для створення валюти.
                var newMoney = machine.Create(pageCount);

                //Додаємо цю валюту в нашу колекцію.
                money.AddRange(newMoney);
            }

            // Виводимо дані на екран.
            foreach (var note in money)
            {
                Console.WriteLine(note);
            }

            Console.ReadLine();
        }
    }
}
