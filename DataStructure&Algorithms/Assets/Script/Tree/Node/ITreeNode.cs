using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITreeNode
{
  ITreeNode Parent { get; set; }
    
  List<ITreeNode> Children { get; set; }

  void SetParent(ITreeNode parent);
  void AddChild(ITreeNode child);


}
