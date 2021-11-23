using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StringSubUtility
{
    public static string FindWordBetween(int startIndex, char startChar, string input, out int lastIndex)
    {
        string result = string.Empty;
        for (int i = startIndex + 1; i < input.Length; i++)
        {
            if (input[i] != startChar) result += input[i];
            else
            {
                lastIndex = i ;
                Debug.Log("Returned string IS:::" + result);
                return result;
            }
        }

        throw new ArgumentException();
    }


    public static string FindWholeNumber(int startIndex, string input, out int lastIndex)
    {
        string result = string.Empty;
        for (int i = startIndex; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]) || input[i] == '.')
            {
                result += input[i];
            }
            else
            {
                lastIndex = i-1 ;
                Debug.Log("Returned number Is:::" + result);
                return result;
            }
        }

        throw new ArgumentException();
    }
}