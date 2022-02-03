using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Статическая функция 
            Money acc1 = new Money(0, 0);
            acc1.ShowValues();
            Money acc2 = new Money(0, 0);
            acc2.ShowValues();
            // В результате вычитания изменяется Money mn1
            Money.Minus(acc1, acc2);
            acc1.ShowValues();

            Console.WriteLine();

            // Метод класса
            Money acc3 = new Money(12, 0);
            acc3.ShowValues();
            Money acc4 = new Money(4, 93);
            acc4.ShowValues();
            acc3.Minus(acc4);
            acc3.ShowValues();

            Money acc5 = new Money(0, 0);
            acc5.ShowValues();
            acc5++;
            acc5.ShowValues();
            acc5++;
            acc5.ShowValues();

            Console.WriteLine(Money.GetQuant);

        }
    }
}
