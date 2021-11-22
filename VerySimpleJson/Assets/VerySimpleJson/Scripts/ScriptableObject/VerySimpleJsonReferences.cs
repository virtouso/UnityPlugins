using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SimpleJsonReferences", menuName = "VerySimpleJson/References")]
public class VerySimpleJsonReferences : ScriptableObject,IVerySimpleJsonReferences
{
    [SerializeField] private string _jsonPattern;
    public string JsonPattern { get; }
}
