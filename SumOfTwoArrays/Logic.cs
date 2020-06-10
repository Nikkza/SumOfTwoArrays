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
            int number = 0;
            int counter = 0;
            var splitValue = value.Split(',');
            if (splitValue.Count() == 2)
            {
                try
                {
                    number = int.Parse(splitValue[0]);
                    counter = int.Parse(splitValue[1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Value must be a number from 1 - 9");
                }

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
                Console.WriteLine("Value can't be empty you must write like this ex 8,2");

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
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            if (number != 0)
            {
                int countWhileLoop = 0;
                (firstList, secondList) = Split(listNew);

                int cntArrry1 = firstList.Count();
                int cntArrry2 = secondList.Count();

                while ((countWhileLoop < number))
                {
                    for (int i = 0; i < cntArrry2; i++)
                    {
                        if (cntArrry1 > i)
                            secondList[i] += firstList[i];
                        else
                        {
                            int temp = 0;
                            secondList[i] += temp;
                        }
                    }
                    countWhileLoop++;
                    if (countWhileLoop < number)
                    {
                        (firstList, secondList) = Split(secondList);

                        cntArrry1 = firstList.Count();
                        cntArrry2 = secondList.Count();
                    }
                }
            }
            return secondList;
        }
    }
}
