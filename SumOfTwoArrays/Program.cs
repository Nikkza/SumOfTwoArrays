using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic _logic = new Logic();
            while (true)
            {
                string value = Console.ReadLine();
                List<int> newList = _logic.CreateLIst(value);
                if (newList.Count() > 0)
                    Console.WriteLine($"SUM: {string.Join(",", _logic.SumValueFromLists(newList))}");
            }
        }
    }
}
