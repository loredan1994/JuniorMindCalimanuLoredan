using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWords
{
    class Admin : IEnumerator
    {
        private WordSorting[] words = new WordSorting[0];
        private int position = -1;
        public void Sort(string text)
        {
            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i].CompareTo(new WordSorting(text, 1)) == 0)
                    return;
            }
            Array.Resize(ref words, words.Length + 1);
            words[words.Length - 1] = new WordSorting(text, 1);
            for (int j = 0; j < words.Length - 1; ++j)
            {
                for (int k = j + 1; k > 0; k--)
                    if (words[k - 1].CompareTo(words[k]) < 0)
                        Swap(ref words[k - 1], ref words[k]);
            }
        }
        public void Swap<T>(ref T a, ref T b)
        {
            T aux = a;
            a = b;
            b = aux;
        }
        public int GetNumber()
        {
            return words.Length;
        }
        public WordSorting GetWord()
        {
            MoveNext();
            return Current;
        }
        public bool MoveNext()
        {
            position++;
            return (position < words.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public WordSorting Current
        {
            get
            {
                try
                {
                    return words[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
        }
    

