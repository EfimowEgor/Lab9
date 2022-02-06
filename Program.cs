using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Статическая функция 
            //Money acc1 = new Money(1, 0);
            //acc1.ShowValues();
            //Money acc2 = new Money(3, 0);
            //acc2.ShowValues();
            //// В результате вычитания изменяется Money mn1
            //Money.Minus(acc1, acc2);
            //acc1.ShowValues();

            //Console.WriteLine();

            //// Метод класса
            //Money acc3 = new Money(-12, 0);
            //acc3.ShowValues();
            //Money acc4 = new Money(4, 93);
            //acc4.ShowValues();
            //acc3.Minus(acc4);
            //acc3.ShowValues();

            //// Overload inc
            //Money acc5 = new Money(0, 99);
            //acc5.ShowValues();
            //acc5++;
            //acc5.ShowValues();
            //acc5++;
            //acc5.ShowValues();

            //// Overload dec
            //Money acc6 = new Money(0, 1000);
            ////acc6--;
            //acc6.ShowValues();

            //Money acc7 = new Money(123, 87);
            //acc7.ShowValues();

            //// Implicit
            //int x = acc7;
            //Console.WriteLine(x);
            //// Explicit
            //double y = (double)acc7;
            //Console.WriteLine(y);

            MoneyArr ar = new MoneyArr(5);
            ar.ShowElems();
            Console.WriteLine(MoneyArr.GetCount);
            Console.WriteLine(Money.GetQuant);
            Money test = new Money();
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

            MoneyArr arr = new MoneyArr(2, 1);
            arr.ShowElems();
            Money test2 = new Money();
            test2 = arr.FindMax();
            test2.ShowValues();
        }
    }
}
