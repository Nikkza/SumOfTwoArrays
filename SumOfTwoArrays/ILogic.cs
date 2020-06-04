using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoArrays
{
    interface ILogic
    {
        List<int> FirstArray(List<int> array);
        List<int> SecondArray(List<int> array);
        List<int> CreateLIst(string value);
        List<int> SumValueFromLists(List<int> listNew);
    }
}
