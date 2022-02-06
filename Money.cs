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
                if (value > 99)
                {
                    rub += value / 100;
                    kop = value % 100;
                }
                else
                    kop = value;
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
            Console.WriteLine($"{Rub} руб. {Kop} коп.");
        }
        // Статическая функция 
        public static Money Minus(Money m1, Money m2)
        {
            Money tmp = new Money();
            int sumKop1 = m1.Rub * 100 + m1.Kop;
            int sumKop2 = m2.Rub * 100 + m2.Kop;
            if(sumKop1 >= sumKop2)
            {
                tmp.Rub = (sumKop1 - sumKop2) / 100;
                tmp.Kop = (sumKop1 - sumKop2) % 100;
                return tmp;
            }
            else
            {
                Console.WriteLine("Операция не совершена. Результирующее значение не может быть меньше 0. Значение рублей и копеек результаты установлены на 0 0");
                tmp.Rub = 0;
                tmp.Kop = 0;
                return tmp;
            }
        }
        // Метод класса
        public Money Minus(Money m2)
        {
            Money tmp = new Money();
            int sumKopMethod = this.Rub * 100 + this.Kop;
            int sumM2 = m2.Rub * 100 + m2.Kop;
            if (sumKopMethod >= sumM2)
            {
                tmp.Rub = (sumKopMethod - sumM2) / 100;
                tmp.Kop = (sumKopMethod - sumM2) % 100;
                return tmp;
            }
            else
            {
                Console.WriteLine("Операция не совершена. Результирующее значение не может быть меньше 0. Значение рублей и копеек результаты установлены на 0 0");
                tmp.Rub = 0;
                tmp.Kop = 0;
                return tmp;
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
                Console.WriteLine("Нельзя убрать копейку. Значение рублей и копеек установлено на 0 0.");
                return m1;
            }
        }

        // Приведение типа

        // Неявное преобразование
        public static implicit operator int(Money m1)
        {
            return m1.Rub;
        }
        // Явное преобразование
        public static explicit operator double(Money m1)
        {
            return m1.Kop / 100.0;
        }

        // Бинарные операции

        // Right
        public static Money operator -(Money m1, int Number)
        {
            Money tmp = new Money();
            int KopSum = m1.Rub * 100 + m1.Kop;
            if (KopSum >= Number)
            {
                KopSum -= Number;
                tmp.Rub = KopSum / 100;
                tmp.Kop = KopSum % 100;
                return tmp;
            }
            else
            {
                Console.WriteLine("Операция не совершена. Результирующее значение не может быть меньше 0. Значение рублей и копеек результаты установлены на 0 0");
                tmp.Rub = 0;
                tmp.Kop = 0;
                return tmp;
            }
        }
        // Left
        public static Money operator -(int Number, Money m1)
        {
            Money tmp = new Money();
            int KopSum = m1.Rub * 100 + m1.Kop;
            if (KopSum <= Number)
            {
                Number -= KopSum;
                tmp.Rub = Number / 100;
                tmp.Kop = Number % 100;
                return tmp;
            }
            else
            {
                Console.WriteLine("Операция не совершена. Результирующее значение не может быть меньше 0. Значение рублей и копеек результаты установлены на 0 0");
                tmp.Rub = 0;
                tmp.Kop = 0;
                return tmp;
            }
        }
        public static Money operator -(Money m1, Money m2)
        {
            Money tmpMoney = new Money();
            if(m1 > m2)
            {
                tmpMoney.Rub = ((m1.Rub * 100 + m1.Kop) - (m2.Rub * 100 + m2.Kop)) / 100;
                tmpMoney.Kop = ((m1.Rub * 100 + m1.Kop) - (m2.Rub * 100 + m2.Kop)) % 100;
                return tmpMoney;
            }
            else
            {
                Console.WriteLine("Операция не совершена. Результирующее значение не может быть меньше 0. Значение рублей и копеек результаты установлены на 0 0");
                tmpMoney.Rub = 0;
                tmpMoney.Kop = 0;
                return tmpMoney;
            }
        }
        public static bool operator >(Money m1, Money m2)
        {
            return m1.Rub * 100 + m1.Kop > m2.Rub * 100 + m2.Kop;
        }
        public static bool operator <(Money m1, Money m2)
        {
            return !(m1.Rub * 100 + m1.Kop > m2.Rub * 100 + m2.Kop);
        }
    }
}
