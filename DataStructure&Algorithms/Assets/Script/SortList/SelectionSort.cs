using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSort<T> : ISort<T> where T : IComparable
{
    public List<T> SortIterative(List<T> input)
    {
        int n = input.Count;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
                if (input[j].CompareTo(input[minIndex]) < 0)
                    minIndex = j;

          
            (input[minIndex], input[i]) = (input[i], input[minIndex]);
        }

        return input;
    }

    public List<T> SortRecursive(List<T> input)
    {
        throw new NotImplementedException();
    }
}