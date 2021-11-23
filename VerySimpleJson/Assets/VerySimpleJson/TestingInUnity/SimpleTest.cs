using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTest : MonoBehaviour
{

    [SerializeField] private string _testJson;







    private void Start()
    {
        IVerySimpleJson json = new VerySimpleJson(new VerySimpleJsonReferences());

        var tokens = json.Tokenize(_testJson);
        int x = 0;
    }
}
