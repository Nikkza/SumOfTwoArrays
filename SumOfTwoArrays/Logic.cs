using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfTwoArrays
{
    public class Logic : ILogic
    {
        public List<int> FirstList(List<int> list) => list.Take(list.Count / 2).ToList();
        public List<int> SecondList(List<int> list) => list.Skip(list.Count / 2).ToList();

        public List<int> CreateLIst(string value)
        {
            List<int> listOfNumbers = new List<int>();
            if (int.TryParse(value, out int numbers))
            {
                if (numbers > 1)
                {
                    Random random = new Random();
                    for (int i = 0; i < numbers; i++)
                        listOfNumbers.Add(random.Next(1, 9));
                }
                else
                    Console.WriteLine("Number must be greater than 1");
            }
            else
                Console.WriteLine("You must type in a number from 1 - 9");

            return listOfNumbers;
        }

        public List<int> SumValueFromLists(List<int> listNew)
        {
            int sum = 0;
            int index = 0;
            List<int> listSum = new List<int>();

            List<int> firstList = FirstList(listNew);
            List<int> secondList = SecondList(listNew);

            int cntArrry1 = firstList.Count();
            int cntArrry2 = secondList.Count();

            while ((cntArrry1 >= 1) && (cntArrry2 >= 1))
            {
                if (listSum.Count() != 0)
                {
                    listSum.Clear();
                    index = 0;
                }

                for (int i = 0; i < cntArrry2; i++)
                {
                    if (!(cntArrry2 - 1 == index))
                    {
                        sum = secondList[i] + firstList[index];
                        listSum.Add(sum);
                    }
                    else if ((cntArrry2 == 1) && (cntArrry1 == 1))
                    {
                        sum = secondList[0] + firstList[0];
                        listSum.Add(sum);
                    }
                    else
                    {
                        sum = secondList[i];
                        listSum.Add(sum);
                    }
                    index++;
                }
                firstList = FirstList(listSum);
                secondList = SecondList(listSum);

                cntArrry1 = firstList.Count();
                cntArrry2 = secondList.Count();
            }
            return listSum;
        }
    }
}
