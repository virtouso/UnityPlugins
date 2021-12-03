using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLiveTest : MonoBehaviour
{
  private void Start()
  {
    List<int> list= new List<int>() { 1, 2, 4, 6, 8, 10, 12, 15, 17, 19, 25 };

    ISearchList<int> searcher = new BinarySearch<int>();
    
    Debug.Log(searcher.Find(list,1,true));
    Debug.Log(searcher.Find(list,2,true));
    Debug.Log(searcher.Find(list,4,true));
    Debug.Log(searcher.Find(list,6,true));
    Debug.Log(searcher.Find(list,8,true));
    Debug.Log(searcher.Find(list,10,true));
    Debug.Log(searcher.Find(list,12,true));
    Debug.Log(searcher.Find(list,15,true));
    Debug.Log(searcher.Find(list,17,true));
    Debug.Log(searcher.Find(list,19,true));
    Debug.Log(searcher.Find(list,25,true));
    Debug.Log(searcher.Find(list,0,true));
    Debug.Log(searcher.Find(list,28,true));
    Debug.Log(searcher.Find(list,9,true));
  }
}
