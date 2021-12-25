using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void LevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
        ToolCounter.ResetCount();
        ToolCounter.toolCount = 0;
    }

    public void Play()
    {
        SceneManager.LoadScene("Level1");
        ToolCounter.ResetCount();
        ToolCounter.toolCount = 0;
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Quit()
    {
        Application.Quit();
        ToolCounter.ResetCount();
        ToolCounter.toolCount = 0;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        ToolCounter.ResetCount();
        ToolCounter.toolCount = 0;
    }
}
