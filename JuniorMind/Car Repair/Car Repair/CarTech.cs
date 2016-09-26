using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Repair
{
    public class CarTech : IEnumerator
    {
        private Cars[] getRepaired = new Cars[0];
        private int number;
        int position = -1;
        public void Sort(PriorityLevel level)
        {
            for (int i = 0; i < getRepaired.Length; ++i)
            {
                if (getRepaired[i].CompareTo(new Cars(level, 1)) == 0) return;
            }
            Array.Resize(ref getRepaired, getRepaired.Length + 1);
            getRepaired[getRepaired.Length - 1] = new Cars(level, 1);
            for(int j = 0; j < getRepaired.Length - 1; ++j)
            {
                for (int k = j + 1; k > 0; k--)
                    if (getRepaired[k - 1].CompareTo(getRepaired[k]) < 0)
                        Swap(ref getRepaired[k - 1], ref getRepaired[k]);

            }
        }
        public void Swap<T>(ref T a, ref T b)
        {
            T aux = a;
            a = b;
            b = aux;
        }
        public void AddNumber()
        {
            for (int i=0; i < getRepaired.Length; i++)
            {
                number++;
            }
        }
        public Cars GetNext()
        {
            MoveNext();
            return Current;
        }
        public int GetNumber()
        {
            return getRepaired.Length;
        }
        public bool MoveNext()
        {
            position++;
            return (position < getRepaired.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Cars Current
        {
            get
            {
                try
                {
                    return getRepaired[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
