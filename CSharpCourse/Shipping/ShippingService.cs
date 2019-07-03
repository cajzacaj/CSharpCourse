using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace shipping
{
    public class ShippingService
    {
        //private decimal[] fees = new decimal[] { 9, 18, 36, 54, 72, 90, 88, 97, 115, 133, 151, 169 };
        

        public decimal CalculateShipping(Letter letter, string year)
        {
            List<decimal> fees = FeesFromFile($"{year}.txt");

            decimal fee = 0;
            decimal feeBulky = 18;

            if (!letter.RecommendedLetter)
            {
                if (letter.Weight <= 50)
                    fee = fees[0];
                else if (letter.Weight <= 100)
                    fee = fees[1];
                else if (letter.Weight <= 250)
                    fee = fees[2];
                else if (letter.Weight <= 500)
                    fee = fees[3];
                else if (letter.Weight <= 1000)
                    fee = fees[4];
                else if (letter.Weight <= 2000)
                    fee = fees[5];
            } else if (letter.RecommendedLetter)
            {
                if (letter.Weight <= 50)
                    fee = fees[6];
                else if (letter.Weight <= 100)
                    fee = fees[7];
                else if (letter.Weight <= 250)
                    fee = fees[8];
                else if (letter.Weight <= 500)
                    fee = fees[9];
                else if (letter.Weight <= 1000)
                    fee = fees[10];
                else if (letter.Weight <= 2000)
                    fee = fees[11];
            }

            if (letter.Bulky)
                fee += feeBulky;

            return fee; 
        }
        public List<decimal> FeesFromFile(string file)
        {
            var feesFromFile = new List<decimal>();

            string[] stringInput = File.ReadAllLines(file);

            foreach (var item in stringInput)
            {
                feesFromFile.Add(decimal.Parse(item));
            }

            return feesFromFile;
        }
    }
}
