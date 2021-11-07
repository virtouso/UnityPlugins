using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILogger
{
 void ShowNormalLog(string message, Color color);
 void ShowWarningLog(string message, Color color);
 void ShowErrorLog(string message, Color color);
}
