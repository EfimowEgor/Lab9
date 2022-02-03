using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Money
    {
        int rub, kop;
        static int quantity = 0;
        public int Rub
        {
            get 
            { 
                return rub; 
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Количество рублей не может быть меньше 0");
                    rub = 0;
                }
                else
                    rub = value; 
            }
        }
        public int Kop
        {
            get 
            { 
                return kop; 
            }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Число копеек не может быть меньше 0");
                    kop = 0;
                }
                else
                {
                    if (value > 99)
                    {
                        rub += value / 100;
                        kop = value % 100;
                    }
                    else
                        kop = value;
                }
            }
        }
        public static int GetQuant
        {
            get
            {
                return quantity;
            }
        }
        public Money()
        {
            rub = 0;
            kop = 0;
            quantity += 1;
        }
        public Money(int rb, int kp)
        {
            Rub = rb;
            Kop = kp;
            quantity += 1;
        }
        public void ShowValues()
        {
            Console.WriteLine($"У вас {Rub} руб. и {Kop} коп.");
        }
        // Статическая функция 
        public static void Minus(Money m1, Money m2)
        {
            int sumKop1 = m1.Rub * 100 + m1.Kop;
            int sumKop2 = m2.Rub * 100 + m2.Kop;
            if(sumKop1 >= sumKop2)
            {
                m1.Rub = (sumKop1 - sumKop2) / 100;
                m1.Kop = (sumKop1 - sumKop2) % 100;
            }
            else
            {
                Console.WriteLine("Денежная разность не может быть меньше 0. Уменьшаемое остаётся без изменений.");
            }
        }
        // Метод класса
        public void Minus(Money m2)
        {
            int sumKopMethod = this.Rub * 100 + this.Kop;
            int sumM2 = m2.Rub * 100 + m2.Kop;
            if (sumKopMethod >= sumM2)
            {
                this.Rub = (sumKopMethod - sumM2) / 100;
                this.Kop = (sumKopMethod - sumM2) % 100;
            }
            else
            {
                Console.WriteLine("Денежная разность не может быть меньше 0. Уменьшаемое остаётся без изменений.");
            }
        }
        // Перегрузка операторов
        
        // Перегрузка инкремента
        public static Money operator ++(Money m1)
        {
            m1.Kop += 1;
            return m1;
        }
        // Перегрузка декремента 
        public static Money operator --(Money m1)
        {
            int sumKopRub = m1.Rub * 100 + m1.Kop;
            if (sumKopRub > 0)
            {
                sumKopRub -= 1;
                m1.Rub = sumKopRub / 100;
                m1.Kop = sumKopRub % 100;
                return m1;
            }
            else
            {
                Console.WriteLine("Нельзя убрать копейку. Значение осталось без изменений.");
                return m1;
            }
        }
    }
}
