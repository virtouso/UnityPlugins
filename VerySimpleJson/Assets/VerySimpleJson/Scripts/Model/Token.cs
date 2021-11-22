using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token
{
  public string Value;
  public TokenType Type;

  public Token(string value, TokenType type)
  {
    Value = value;
    Type = type;
  }
}


public enum TokenType
{
  String,
  Int,
  Float,
  Object,
  Array,
  Bracket,
  CurlyBracket,
  Colon,
  Comma
}