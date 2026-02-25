using System.Diagnostics;
using UnityEngine;

public static class globalSecret
{

    public static int secretCounter = 0;

    public static void changeSecretCounter(int amount)
    {
        secretCounter = secretCounter + amount;
        UnityEngine.Debug.Log(secretCounter);
        if (secretCounter == 5)
        {
            
            // secretEnding = true;
        }
    }
}
