using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public bool isEndRed = false;
    public bool isEndBlue = false;
    public bool isAllTools = false;

    public void Update()
    {
        if(ToolCounter.toolCount>=5)
        {
            isAllTools = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D playersIn)
    {
        if  (playersIn.tag=="Blue")
        {
            isEndBlue = true;
        }

        if  (playersIn.tag=="Red")
        {
            isEndRed =  true;
        }
                        
        if  (isEndBlue&&isEndRed&&isAllTools)
        {
            
            LevelController.instance.isEndGame();
            //Debug.Log("Метод вызван");
        }
    }

    private void OnTriggerExit2D(Collider2D playersOut)
    {
        if (playersOut.tag=="Blue")
        {
            isEndBlue = false;
        }

        if (playersOut.tag=="Red")
        {
            isEndRed = false;
        }
    }

}
