using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITreeNode<T>
{
  T Data { get; set; }
  
  ITreeNode<T> Parent { get; set; }
    
  List<ITreeNode<T>> Children { get; set; }

  void SetParent(ITreeNode<T> parent);
  void AddChild(ITreeNode<T> child);


}
