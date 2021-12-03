using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort<T> : ISort<T> where T : IComparable
{
    public List<T> SortIterative(List<T> input)
    {
        throw new NotImplementedException();
    }

    public List<T> SortRecursive(List<T> input)
    {
        throw new NotImplementedException();
    }

    private int partition(int[] item, int left, int right)
    {
        int pivot = item[left];
        while (true)
        {
            while (item[left] < pivot)
                left++;

            while (item[right] > pivot)
                right--;


            if (left < right)
            {
                int tem;
                tem = item[left];
                item[left] = item[right];
                item[right] = tem;
            }
            else
            {
                return right;
            }
        }
    }

    private void quicksort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = partition(arr, left, right);
            if (pivot > 1)
            {
                quicksort(arr, left, pivot - 1);
            }

            if (pivot + 1 < right)
            {
                quicksort(arr, pivot + 1, right);
            }
        }
        

    }
}
