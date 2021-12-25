using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public static LevelMenu instance = null;
    public List <Button> Buttons;

    int levelComplete;

    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        
        for (int i = 0; i<Buttons.Count; i++)
        {
            Buttons[i].interactable = false;
        }
        
        for (int i = 0; i<levelComplete; i++) //Спасибо Саньку за эту строчку 
        {
            Buttons[i].interactable = true;  
        }         
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
        ToolCounter.ResetCount();
        //ToolCounter.toolCount = 0;
    }

    public void Reset()
    {
        for (int i = 0; i<Buttons.Count; i++)
        {
            Buttons[i].interactable = false;
        }
        
        PlayerPrefs.DeleteAll();
        ToolCounter.ResetCount();
        //ToolCounter.toolCount = 0;
    }

    
}
