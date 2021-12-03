using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  interface ISearchList<T>
{

    int Find(List<T> inputList,T Element ,bool isSorted);


}
