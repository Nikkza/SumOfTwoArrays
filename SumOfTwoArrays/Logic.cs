using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfTwoArrays
{
    public class Logic : ILogic
    {
        public (List<int>, int) CreateLIst(List<int> value, int counter)
        {
            var convertInt = Convert.ToInt32(string.Join("", value));
            List<int> listOfNumbers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < convertInt; i++)
                listOfNumbers.Add(random.Next(1, 9));

            return (listOfNumbers, counter);
        }

        public List<int> FirstList(List<int> list) => list.Take(list.Count / 2).Reverse().ToList();
        public List<int> SecondList(List<int> list) => list.Skip(list.Count / 2).Reverse().ToList();

        public List<int> SumValueFromLists(List<int> listNew, int number)
        {
            List<int> listSum = new List<int>();
            if (number != 0)
            {
                int sum = 0;
                int countWhileLoop = 0;
                List<int> firstList = FirstList(listNew);
                List<int> secondList = SecondList(listNew);
                int cntArrry1 = firstList.Count();
                int cntArrry2 = secondList.Count();

                while ((countWhileLoop < number))
                {
                    if (listSum.Count() != 0)
                        listSum.Clear();

                    for (int i = 0; i < cntArrry2; i++)
                    {
                        if (cntArrry1 > i)
                        {
                            sum = secondList[i] + firstList[i];
                            listSum.Add(sum);
                        }
                        else
                        {
                            sum = secondList[i];
                            listSum.Add(sum);
                        }
                    }
                    firstList = FirstList(listSum);
                    secondList = SecondList(listSum);

                    cntArrry1 = firstList.Count();
                    cntArrry2 = secondList.Count();
                    countWhileLoop++;
                }
            }

            return listSum;
        }
    }
}
