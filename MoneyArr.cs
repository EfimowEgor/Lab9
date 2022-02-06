using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class MoneyArr
    {
        static Random rnd = new Random(100101);
        static int count = 0;
        Money[] arr = null;

        public int Size
        {
            get
            {
                return arr.Length;
            }
        }
        public Money this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index];
                else
                    throw new ArgumentException();
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
            }
        }
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
        // Create arr RNS
        public MoneyArr(int size)
        {
            count += 1;
            arr = new Money[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Money m = new Money(rnd.Next(1, 1000), rnd.Next(1, 1000));
                arr[i] = m;
            }
        }
        public MoneyArr(int size, int option)
        {
            count += 1;
            arr = new Money[size];
            for (int i = 0; i < arr.Length; ++i)
            {
                Money m = new Money();
                arr[i] = Input.GetMoney(m);
            }
        }
        public Money FindMax()
        {
            Money tmpMax = new Money();
            if(arr != null)
            {
                foreach (Money elem in arr)
                {
                    if (elem > tmpMax)
                    {
                        tmpMax = elem;
                    }
                }
                return tmpMax;
            }
            return null;
        }
        public void ShowElems()
        {
            {
                foreach (Money m in arr)
                {
                    m.ShowValues();
                }
            }
        }
    }
}
