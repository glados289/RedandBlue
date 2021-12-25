using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueDeathCounter : MonoBehaviour
{   
    private static int deathCountBlue = 0;
    [SerializeField] private Text textUIDeathCountBlue;
    
    public static BlueDeathCounter deathCounterBlue;

    void Start()
    {
        deathCounterBlue = this;
    }

    public static void DrawTextBlue()
    {
        deathCounterBlue.textUIDeathCountBlue.text = "Blue Dead: "+ deathCountBlue.ToString();
        Debug.Log("DrawTextCalled");
    }

    public static void resetDeathCountBlue()
    {
        deathCountBlue = 0;
        DrawTextBlue();
    }

    public static void IncrementDeathCountBlue()
    {
        deathCountBlue++;
        DrawTextBlue();
        Debug.Log("Incr called");
    }
}
