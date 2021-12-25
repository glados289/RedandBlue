using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToolCounter : MonoBehaviour
{
    public static int toolCount = 0;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }
    
    void Update()
    {
        text.text = "Tools " + toolCount.ToString() + " /5";
    }

    public static void ResetCount()
    {
        toolCount = 0;
    }


}
