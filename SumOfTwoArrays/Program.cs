using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", NewArray()));
            Console.ReadLine();
        }
        static List<int> FirstArray(List<int> array) => array.Take(array.Count / 2).ToList();
        static List<int> SecondArray(List<int> array) => array.Skip(array.Count / 2).ToList();

        static List<int> NewArray()
        {
            int sum = 0;
            int index = 0;
            List<int> arraySum = new List<int>();
            var arrayNew = new List<int>() { 1, 2, 1, 2 };

            List<int> firstArray = FirstArray(arrayNew);
            List<int> secondArray = SecondArray(arrayNew);

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
