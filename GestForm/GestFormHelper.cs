using System;
using System.Collections.Generic;

namespace GestForm
{
    public static class GestFormHelper
    {
        /// <summary>
        /// Returns a random integer list between -1000 and 1000 of size 20.
        /// </summary>
        /// <returns>list of integers</returns>
        public static List<int> CreateRandomIntegerList()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i=0; i<Constants.ListLength; i++)
            {
                int randomInterger = rnd.Next(Constants.MinValue, Constants.MaxValue + 1);
                list.Add(randomInterger);
            }

            return list;
        }
    }
}
