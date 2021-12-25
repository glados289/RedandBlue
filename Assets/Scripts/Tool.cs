using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D tool)
    {
        if(tool.CompareTag("Blue")||tool.CompareTag("Red"))
        {
            ToolCounter.toolCount++;
            Destroy(gameObject);
        }
    }
}
