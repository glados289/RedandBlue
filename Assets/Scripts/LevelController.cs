using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    
    int sceneIndex;
    int levelComplete;
    
    void Start()
    {
        if(instance == null) 
        {
            instance = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");

    }

    public void isEndGame ()
    {
        Debug.Log("isEndGame");
        
        if (sceneIndex == 22)
        {
            SceneManager.LoadScene("LevelMenu");
            ToolCounter.ResetCount();
            ToolCounter.toolCount = 0;
            //Debug.Log("должен войти в меню уровней");
        }
        else
        {
            if(levelComplete < sceneIndex)
            {
                PlayerPrefs.SetInt("LevelComplete", sceneIndex);
            }
            Invoke("NextLevel", 1f);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex+1);
        ToolCounter.ResetCount();
        //Debug.Log("NextLevel");
    }

    void LoadMainMenu ()
    {
        SceneManager.LoadScene("LevelMenu");
        ToolCounter.ResetCount();
        ToolCounter.toolCount = 0;
    }
}
