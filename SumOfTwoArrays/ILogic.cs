using System.Collections.Generic;

namespace SumOfTwoArrays
{
    interface ILogic
    {
        (List<int> firstList, List<int> secondList) Split(List<int> list);
        (List<int> list, int count) CreateLIst(string value);
        List<int> SumValueFromLists(List<int> listNew, int countRoounds);
    }
}
