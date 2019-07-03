using System;
using System.Collections.Generic;
using System.Text;

namespace shipping
{
    public class Letter
    {
        public bool RecommendedLetter { get; set; }
        public bool Bulky { get; set; }
        public int Weight { get; set; }

        public Letter(int weigthInGrams, bool isRecommendedLetter, bool isBulky)
        {
            if (weigthInGrams < 0)
                throw new ArgumentException("A letter can't have a negative weight");
            if (weigthInGrams > 2000)
                throw new ArgumentException("The letter is too heavy, please send as parcel");
            else
                Weight = weigthInGrams;

            RecommendedLetter = isRecommendedLetter;
            Bulky = isBulky;
        }
    }
}
