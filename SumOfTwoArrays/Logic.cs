using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfTwoArrays
{
    public class Logic : ILogic
    {
        public (List<int> list, int count) CreateLIst(string value)
        {
            List<int> list = new List<int>();
            int count = 0;
            var splitValue = value.Split(',');
            if (splitValue.Count() == 2)
            {
                if ((int.TryParse(splitValue[0], out int number) && (int.TryParse(splitValue[1], out int counter))))
                {
                    List<int> listOfNumbers = new List<int>();
                    Random random = new Random();
                    for (int i = 0; i < number; i++)
                    {
                        listOfNumbers.Add(random.Next(1, 9));
                    }
                    count = counter;
                    list = listOfNumbers;
                }
                else
                    Console.WriteLine("Value must be a number from 1 - 9");

            }
            else
                Console.WriteLine("Value can not be empty input ex: 10,2");

            return (list, count);
        }


        public (List<int> firstList, List<int> secondList) Split(List<int> list)
        {
            var firstList = list.Take(list.Count / 2).Reverse().ToList();
            var secondList = list.Skip(list.Count / 2).Reverse().ToList();
            return (firstList, secondList);
        }

        public List<int> SumValueFromLists(List<int> listNew, int number)
        {
            List<int> listSum = new List<int>();
            if (number != 0)
            {
                int sum = 0;
                int countWhileLoop = 0;
                var (firstList, secondList) = Split(listNew);

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
                    (firstList, secondList) = Split(listSum);

                    cntArrry1 = firstList.Count();
                    cntArrry2 = secondList.Count();
                    countWhileLoop++;
                }
            }

            return listSum;
        }
    }
}
