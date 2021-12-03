using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITraversal 
{
  string Traverse(ITreeNode root, string currentTraverse);
}
