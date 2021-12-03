using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertionSort<T> : ISort<T> where T : IComparable
{
    public List<T> SortIterative(List<T> input)
    {
        int n = input.Count;
        for (int i = 1; i < n; ++i)
        {
            T key = input[i];
            int j = i - 1;
            
            while (j >= 0 && input[j].CompareTo(key) > 0)
            {
                input[j + 1] = input[j];
                j = j - 1;
            }

            input[j + 1] = key;
        }

        return input;
    }

    public List<T> SortRecursive(List<T> input)
    {
        throw new NotImplementedException();
    }
}