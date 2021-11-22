using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVerySimpleJson
{


    string Serialize(object input);
    List<Token> Tokenize(string input);
    object Deserialize(string input);
    bool Validate(string input);

}
