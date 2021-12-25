using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RedDeath : MonoBehaviour
{
    public int currentLevel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("DeadRed"))
        {
            SceneManager.LoadScene(currentLevel);
            ToolCounter.ResetCount();
            //RedDeathCounter.IncrementDeathCountRed();
            //Debug.Log("Red Dead");
        }   
        if(collision.gameObject.tag.Equals("Dead"))  
        {
            SceneManager.LoadScene(currentLevel);
            ToolCounter.ResetCount();
            //RedDeathCounter.IncrementDeathCountRed();
            //Debug.Log("Red dead too");
        }   
    }
}
