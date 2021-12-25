using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BlueDeath : MonoBehaviour
{
    /*public GameObject countBlue;
    public DeathCounterBlue actionTarget;*/

    public int currentLevel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("DeadBlue"))
        {
            SceneManager.LoadScene(currentLevel);
            ToolCounter.ResetCount();
            //Debug.Log("Blue Dead");
            //BlueDeathCounter.IncrementDeathCountBlue();
        }   
        if(collision.gameObject.tag.Equals("Dead"))  
        {
            SceneManager.LoadScene(currentLevel);
            ToolCounter.ResetCount();
            //Debug.Log("Blue dead too");
            //BlueDeathCounter.IncrementDeathCountBlue();
        }   
    }
}
