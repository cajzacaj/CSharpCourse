using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharp4
{
    class Seats
    {

        public char[,] Map { get; set; }

        public void FillFromText(params string[] list)
        {
            char[,] newMap = new char[list.Length, list[0].Length];

            for (int i = 0; i < list.Length; i++)
            {
                char[] row = list[i].ToCharArray();

                for (int x = 0; x < row.Length; x++)
                {
                    newMap[i, x] = row[x];
                    
                }
            }

            Map = newMap;
        }

        public void FillFromFile(string file)
        {
            string[] seatInput = File.ReadAllLines("map.txt");


        }
    }
}
