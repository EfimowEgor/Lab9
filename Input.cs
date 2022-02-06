using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Input
    {
        public static int GetValues(int min, int max, string msg)
        {
            int Number;
            bool isRead;
            do
            {
                Console.WriteLine(msg);
                isRead = int.TryParse(Console.ReadLine(), out Number);
                if (!isRead)
                {
                    Console.WriteLine("Ошибка! Не правильно введено целое число");
                }
                else
                {
                    if (Number < min || Number > max)
                    {
                        Console.WriteLine("Ошибка! Число не попадает в заданный диапазон");
                        isRead = false;
                    }
                }
            } while (!isRead);
            return Number;
        }
        public static Money GetMoney(Money m1)
        {
            Money tmpMoney = new Money();
            tmpMoney.Rub = GetValues(0, 1000, "Введите количество рублей");
            tmpMoney.Kop = GetValues(0, 1000, "Введите количество копеек");
            return tmpMoney;
        }
    }
}
