using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public static class ExpNeededForLevel
{
    public static int GetExpNeeded(int currentLevel)
    {
        return (int)Math.Floor(Math.Pow((float)(currentLevel + 1), 3.2f));
    }
}
