﻿using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class MultipleArguments
    {
        public List<string> SomeToUpper(List<string> list, List<bool> toUpper)
        {
            if (list == null || toUpper == null)
                throw new ArgumentException("Input can't be null");
            if (list.Count != toUpper.Count)
                throw new ArgumentException("Lists have to be the same lenght");

            var newList = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (toUpper[i] == true)
                    newList.Add(list[i].ToUpper());
                else
                    newList.Add(list[i]);
            }
            return newList;
        
        }

        public List<double> MultiplyAllBy(int factor, List<double> numbers)
        {
            if (numbers == null)
                throw new ArgumentException("Can't be null");

            var output = new List<double>();

            foreach (double num in numbers)
            {
                output.Add(num * factor);
            }

            return output;
        }

        public List<string> NearbyElements(int position, List<string> list)
        {
            if (position < 0 || position >= list.Count)
                throw new ArgumentException("Invalid position");

            var newList = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == position - 1 || i == position || i == position + 1)
                    newList.Add(list[i]);
            }
            return newList;
        }

        public List<List<int>> MultiplicationTable(int rowMax, int colMax)
        {
            if (rowMax == 0 || colMax == 0)
                throw new ArgumentException("Can't be zero");

            var upperList = new List<List<int>>();
            for (int i = 1; i <= rowMax; i++)
            {
                var innerList = new List<int>();
                for (int x = 1; x <= colMax; x++)
                {
                    innerList.Add(i * x);
                }
                upperList.Add(innerList);
            }
            return upperList;
        }
       

        public int ComputeSequenceSumOrProduct(int toNumber, bool sum)
        {
            if (toNumber <= 0)
                throw new ArgumentException("Can't be 0 or negative");

            int newNum = 0;

            if (sum == true)
            {
                for (int i = 1; i <= toNumber; i++)
                {
                    newNum += i;
                }
            }
            else if (sum == false)
            {
                newNum = 1;
                for (int i = 1; i <= toNumber; i++)
                {
                    newNum *= i;
                }
            }

            return newNum;
        }
        
        public int[] CombineLists(int[] list1, int[] list2)
        {
            var tempList = new List<int>();

            for (int i = 0; i < Math.Max(list1.Length, list2.Length); i++)
            {
                if (i < list1.Length)
                    tempList.Add(list1[i]);
                if (i < list2.Length)
                    tempList.Add(list2[i]);
            }

            return tempList.ToArray();

        }

        public int[] RotateList(int[] list, int rotation)
        {
            if (list == null)
                throw new ArgumentException("Can't be null");

            int[] rotatedList = new int[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                int newIndex = i + rotation - 1;

                if (newIndex > list.Length - 1)
                    newIndex -= list.Length;
                else if (newIndex < 0)
                    newIndex += list.Length;

                rotatedList[i] = list[newIndex];
            }

            return rotatedList;
        }

        //CollectionAssert.AreEqual(
        //        new[] { 3, 4, 5, 1, 2 },
        //        x.RotateList(new[] { 1, 2, 3, 4, 5 }, -2));

        //    CollectionAssert.AreEqual(
        //        new[] { 2, 3, 4, 5, 1 },
        //        x.RotateList(new[] { 1, 2, 3, 4, 5 }, -1));

        //    CollectionAssert.AreEqual(
        //        new[] { 3, 4, 5, 1, 2 },
        //        x.RotateList(new[] { 1, 2, 3, 4, 5 }, -2));

        //    CollectionAssert.AreEqual(
        //        new[] { 3, 4, 1, 2 },
        //        x.RotateList(new[] { 1, 2, 3, 4 }, -2));

        //    CollectionAssert.AreEqual(
        //        new[] { 3, 1, 2 },
        //        x.RotateList(new[] { 1, 2, 3 }, -2));

        //    CollectionAssert.AreEqual(
        //        new[] { 1, 2, 3 },
        //        x.RotateList(new[] { 1, 2, 3 }, -3));

        //    CollectionAssert.AreEqual(
        //        new[] { 1, 2, 3 },
        //        x.RotateList(new[] { 1, 2, 3 }, -30));

        //    CollectionAssert.AreEqual(
        //        new[] { 4, 5, 1, 2, 3 },
        //        x.RotateList(new[] { 1, 2, 3, 4, 5 }, 2));

        //    CollectionAssert.AreEqual(
        //        new[] { 1, 2, 3, 4, 5 },
        //        x.RotateList(new[] { 1, 2, 3, 4, 5 }, 0));

        //    CollectionAssert.AreEqual(
        //        new[] { 5, 1, 2, 3, 4 },
        //        x.RotateList(new[] { 1, 2, 3, 4, 5 }, 1));

        //    CollectionAssert.AreEqual(
        //        new int[] { },
        //        x.RotateList(new int[] { }, 22));

        //    Assert.ThrowsException<ArgumentException>(() => x.RotateList(null, 0));

        public int ComputeSequence(int v, object sum)
        {
            throw new NotImplementedException();
        }
    }
}
