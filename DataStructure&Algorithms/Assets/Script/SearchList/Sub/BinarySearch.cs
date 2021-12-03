using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearch<T> : ISearchList<T> where T : IComparable
{
    public int Find(List<T> inputList, T element, bool isSorted)
    {
        //todo if not sorted, sort it
        return RecursiveFind(inputList, element, 0, inputList.Count-1);
    }


    private int RecursiveFind(List<T> inputList, T element, int min, int max)
    {
        bool biggerArray = element.CompareTo(inputList[max]) > 0;
        bool smallerArray = element.CompareTo(inputList[min]) < 0;
        if (biggerArray || smallerArray) return -1;

        int middleIndex = (min + max) / 2;
        int compare = element.CompareTo(inputList[middleIndex]);
        if (compare == 0)
            return middleIndex;
        else if (compare > 0)
            return RecursiveFind(inputList, element, middleIndex + 1, max);
        else
            return RecursiveFind(inputList, element, min, middleIndex - 1);
    }
}