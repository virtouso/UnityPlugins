using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort<T> : ISort<T> where T : IComparable
{
    public List<T> SortIterative(List<T> input)
    {
        int n = input.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (input[j].CompareTo(input[j + 1]) > 0)
                {
                    // new way of swapping. dont get scared. 
                    (input[j], input[j + 1]) = (input[j + 1], input[j]);
                }
            }
        }

        return input;
    }

    public List<T> SortRecursive(List<T> input)
    {
        //there is recursive version but ignorable
        throw  new NotImplementedException();
    }
}