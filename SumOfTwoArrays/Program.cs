using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string value = Console.ReadLine();
                List<int> newList = CreateLIst(value);
                if (newList.Count() > 0)
                    Console.WriteLine($"SUM: {string.Join(",", newList)}");
            }
        }

        static List<int> FirstArray(List<int> array) => array.Take(array.Count / 2).ToList();
        static List<int> SecondArray(List<int> array) => array.Skip(array.Count / 2).ToList();

        static List<int> CreateLIst(string value)
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

        static List<int> SumValueFromLists(List<int> listNew)
        {
            int sum = 0;
            int index = 0;
            List<int> arraySum = new List<int>();


            List<int> firstArray = FirstArray(listNew);
            List<int> secondArray = SecondArray(listNew);

            int cntArrry1 = firstArray.Count();
            int cntArrry2 = secondArray.Count();

            while ((cntArrry1 >= 1) && (cntArrry2 >= 1))
            {
                if (arraySum.Count() != 0)
                {
                    arraySum.Clear();
                    index = 0;
                }

                for (int i = 0; i < cntArrry2; i++)
                {
                    if (!(cntArrry2 - 1 == index))
                    {
                        sum = secondArray[i] + firstArray[index];
                        arraySum.Add(sum);
                    }
                    else if ((cntArrry2 == 1) && (cntArrry1 == 1))
                    {
                        sum = secondArray[0] + firstArray[0];
                        arraySum.Add(sum);
                    }
                    else
                    {
                        sum = secondArray[i];
                        arraySum.Add(sum);
                    }
                    index++;
                }
                firstArray = FirstArray(arraySum);
                secondArray = SecondArray(arraySum);

                cntArrry1 = firstArray.Count();
                cntArrry2 = secondArray.Count();
            }
            return arraySum;
        }
    }
}
