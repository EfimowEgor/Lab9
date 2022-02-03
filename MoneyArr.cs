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
        public static int GetCount
        {
            get
            {
                return count;
            }
        }
        public MoneyArr()
        {
            count += 1;
            arr = null;
        }
        public MoneyArr(int size)
        {
            count += 1;
            arr = new Money[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Money m = new Money(rnd.Next(0, 1000), rnd.Next(0, 1000));
                arr[i] = m;

            }
        }
        public void ShowElems()
        {
            foreach (Money m in arr)
            {
                m.ShowValues();
            }
        }
    }
}
