using System;

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
                var (list, count) = _logic.CreateLIst(value);
                if (list.Count != 0)
                    Console.WriteLine($"SUM: {string.Join(",", _logic.SumValueFromLists(list, count))}");
            }
        }
    }
}
