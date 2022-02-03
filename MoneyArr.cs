using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class MoneyArr
    {
        static Random rnd = new Random();
        static int count = 0;
        Money[] arr = null;
        int size;
        public MoneyArr()
        {
            arr = null;
        }
        public MoneyArr(int size)
        {
            arr = new Money[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Money m = new Money(rnd.Next(0, 1000), rnd.Next(0, 1000));
                arr[i] = m;

            }
        }

    }
}
