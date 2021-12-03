using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISort<T> where T: IComparable
{

    List<T> SortIterative(List<T> input);

    List<T> SortRecursive(List<T> input);

}
