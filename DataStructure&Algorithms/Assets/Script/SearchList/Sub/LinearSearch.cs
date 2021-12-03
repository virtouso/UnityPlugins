using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearSearch<T> :ISearchList<T> where T:IComparable
{
    public int Find(List<T> inputList,T element, bool isSorted)
    {

        for (int i = 0; i < inputList.Count; i++)
        {
            if (inputList[i].CompareTo(element) == 0)
                return i;
        }

        return -1;
    }
}
