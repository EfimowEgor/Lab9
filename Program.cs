using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1

            //Статическая функция 
            //Money acc1 = new Money(Input.GetValues(0, 1000, "Введите количество рублей"), Input.GetValues(0, 1000, "Введите количество копеек"));
            //acc1.ShowValues();
            //Money acc2 = new Money(Input.GetValues(0, 1000, "Введите количество рублей"), Input.GetValues(0, 1000, "Введите количество копеек"));
            //acc2.ShowValues();

            //Статическая функция
            //acc1 = Money.Minus(acc1, acc2);
            //acc1.ShowValues();

            //Console.WriteLine(); 

            // Метод класса

            //Money acc3 = new Money(Input.GetValues(0, 1000, "Введите количество рублей"), Input.GetValues(0, 1000, "Введите количество копеек"));
            //acc3.ShowValues();
            //Money acc4 = new Money(Input.GetValues(0, 1000, "Введите количество рублей"), Input.GetValues(0, 1000, "Введите количество копеек"));
            //acc4.ShowValues();
            //acc3 = acc3.Minus(acc4);
            //acc3.ShowValues();
            //Console.WriteLine(Money.GetQuant);

            // Part 2

            // Overload inc
            //Money acc5 = new Money(Input.GetValues(0, 1000, "Введите количество рублей"), Input.GetValues(0, 1000, "Введите количество копеек"));
            //acc5.ShowValues();
            //acc5++;
            //acc5.ShowValues();
            //acc5++;
            //acc5.ShowValues();

            // Overload dec
            //Money acc6 = new Money(Input.GetValues(0, 1000, "Введите количество рублей"), Input.GetValues(0, 1000, "Введите количество копеек"));
            //acc6--;
            //acc6.ShowValues();

            //Money acc7 = new Money(Input.GetValues(0, 1000, "Введите количество рублей"), Input.GetValues(0, 1000, "Введите количество копеек"));
            //acc7.ShowValues();

            //// Implicit
            //int x = acc7;
            //Console.WriteLine(x);
            //// Explicit
            //double y = (double)acc7;
            //Console.WriteLine(y);

            // Пример бинарных операций допишу на месте
            //acc7 = acc7 - acc6;
            //acc7.ShowValues();
            // Part 3


            //MoneyArr ar = new MoneyArr(Input.GetValues(1, 5, "Введите длину массива"));
            try
            {
                MoneyArr ar = new MoneyArr();
                ar.ShowElems();
                Money test = new Money();
                Console.WriteLine("Max");
                test = ar.FindMax();
                test.ShowValues();
                try
                {
                    ar[0].ShowValues();
                    ar[100].ShowValues();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("неправильно задан индекс");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Нельзя работать с null");
            }

            MoneyArr arr = new MoneyArr(Input.GetValues(1, 5, "Введите длину массива"), 1);
            arr.ShowElems();
            //Money test2 = new Money();
            //test2 = arr.FindMax();
            //test2.ShowValues();
            //Console.WriteLine(MoneyArr.GetCount);
        }
    }
}
