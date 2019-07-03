using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesBooks
{
    class ElectronicBook : Book
    {
        public void SendBookTo(string emailAdress)
        {
            Console.WriteLine($"   Skickar boken till {emailAdress}");
        }
    }
    
}
