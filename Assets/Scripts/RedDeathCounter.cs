using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedDeathCounter : MonoBehaviour
{
    private static int deathCountRed = 0;
    [SerializeField] private Text textUIDeathCountRed;
    
    public static RedDeathCounter deathCounterRed;

    void Start()
    {
        deathCounterRed = this;
    }

    public static void DrawTextRed()
    {
        deathCounterRed.textUIDeathCountRed.text = "Red Dead: "+ deathCountRed.ToString();
        Debug.Log("DrawTextCalled");
    }

    public static void resetDeathCountRed()
    {
        deathCountRed = 0;
        DrawTextRed();
    }

    public static void IncrementDeathCountRed()
    {
        deathCountRed++;
        DrawTextRed();
        Debug.Log("Incr called");
    }
}
