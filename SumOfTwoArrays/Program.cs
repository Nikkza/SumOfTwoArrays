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
                string count = Console.ReadLine();
                List<int> intList = new List<int>();
                if (int.TryParse(value, out int listItem) && (int.TryParse(count, out int numberOfLoops)))
                {
                    intList = listItem.ToString().Select(x => Convert.ToInt32(x.ToString())).ToList();
                    var k = _logic.CreateLIst(intList, numberOfLoops);
                    Console.WriteLine($"SUM: {string.Join(",", _logic.SumValueFromLists(k.Item1, k.Item2))}");
                }
            }
        }
    }
}
