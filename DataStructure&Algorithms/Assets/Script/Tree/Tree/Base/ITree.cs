using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITree 
{
  ITreeNode Root { get; set; }
  List<ITreeNode> Nodes { get; }

  void AddNode(ITreeNode node);
  void RemoveNode(ITreeNode node);

  void Init(ITraversal traversal);
  string Traverse(ITreeNode root);

  ITreeNode Search(ITreeNode root);



}
