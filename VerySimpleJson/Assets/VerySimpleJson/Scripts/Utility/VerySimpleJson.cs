using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class VerySimpleJson : IVerySimpleJson
{
    private IVerySimpleJsonReferences _references;

    public VerySimpleJson(IVerySimpleJsonReferences references)
    {
        _references = references;
    }


    public string Serialize(object input)
    {
        throw new System.NotImplementedException();
    }

    public List<Token> Tokenize(string input)
    {
        List<Token> tokens = new List<Token>();

        for (int i = 0; i < input.Length; i++)
        {
            char current = input[i];
            Debug.Log( "current char::"+ current);

            if (input[i] == '{' || input[i] == '}')
            {
                tokens.Add(new Token(input[i].ToString(), TokenType.CurlyBracket));
            }

            else if (input[i] == '[' || input[i] == ']')
            {
                tokens.Add(new Token(input[i].ToString(), TokenType.Bracket));
            }

            else if (input[i] == ':')
            {
                tokens.Add(new Token(input[i].ToString(), TokenType.Colon));
            }

            else if (input[i] == ',')
            {
                tokens.Add(new Token(input[i].ToString(), TokenType.Comma));
            }

            else if (input[i] == '"')
            {
                tokens.Add(new Token(StringSubUtility.FindWordBetween(i, '"', input, out int lastIndex),
                    TokenType.String));
                i = lastIndex;
            }

            else if (char.IsDigit(input[i]))
            {
                tokens.Add(new Token(StringSubUtility.FindWholeNumber(i, input, out int lastIndex), TokenType.Int));
                i = lastIndex;
            }
        }

        return tokens;
    }

    public object Deserialize(string input)
    {
        {
            throw new System.NotImplementedException();
        }
    }

    public bool Validate(string input)
    {
        {
            return Regex.IsMatch(input, _references.JsonPattern);
        }
    }
}