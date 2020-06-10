using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoArrays
{
    interface ILogic
    {
        List<int> FirstList(List<int> list);
        List<int> SecondList(List<int> list);
        (List<int> list,int count) CreateLIst(string value);
        List<int> SumValueFromLists(List<int> listNew,int countRoounds);
    }
}
