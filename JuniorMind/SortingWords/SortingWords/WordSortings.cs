using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWords
{
    public class WordSorting
    {
        private string words;
        private int appearance;

        public WordSorting(string words, int appearance)
        {
            this.words = words;
            this.appearance = appearance;
        }
        public override bool Equals(object ob)
        {
            if (ob == null || !(ob is WordSorting))
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return appearance;
        }

        public int CompareTo(WordSorting other)
        {
            return words.CompareTo(other.words);
        }

        public int CompareToByAppearances(WordSorting word)
        {
            return appearance.CompareTo(word.appearance);
        }

        public void Appearances()
        {
            appearance++;
        }
    }

}

