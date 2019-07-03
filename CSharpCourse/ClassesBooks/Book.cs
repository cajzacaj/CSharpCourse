using System;

namespace ClassesBooks
{
    internal class Book : Product
    {

        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        private int _nrOfPages;
        private double _weightInGrams = SetWeight(_nrOfPages);

        private static double SetWeight(int nrOfPages)
        {
            double weight = nrOfPages * 0.8;
            return weight;
        }

        private string _size;

        public int NrOfPages
        {
            get
            {
                return _nrOfPages;
            }
            set
            {
                if (value > 1000)
                    _nrOfPages = 300;
                else
                    _nrOfPages = value;
            }
        }
        public double WeightInGrams
        {
            get
            {
                return _weightInGrams;
            }
            private set
            {
                _weightInGrams = _nrOfPages * 0.8;
            }
        }
        public string Size
        {
            get
            {
                return _size;
            }
            private set
            {
                if (_nrOfPages < 100)
                    _size = "Tunn";
                else if (_nrOfPages >= 100 && _nrOfPages < 300)
                    _size = "Normal";
                else if (_nrOfPages >= 300)
                    _size = "Tjock";
            }
        }

    }
}