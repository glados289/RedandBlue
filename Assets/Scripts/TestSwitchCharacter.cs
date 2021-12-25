using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSwitchCharacter : MonoBehaviour
{
    public Transform character;
    public List<Transform> possibleCharacters;
    public int whichCharacter;
    public Button JumpButtonBlue;
    public Button JumpButtonRed;
    public Button SwitchButton;
    

    void Start()
    {
        if(character==null && possibleCharacters.Count >= 1)
        {
        character = possibleCharacters[0];
        }
        
        Swap();

        JumpButtonRed.interactable = false;
        
    }

        void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.S))
       {
                    
         if(whichCharacter == 0)
            {
                whichCharacter = possibleCharacters.Count - 1;
            }
            else
            {
             whichCharacter -= 1;
            }
            Swap();
       }*/
        if(whichCharacter == 0)
        {
            JumpButtonRed.interactable = false;
            JumpButtonBlue.interactable = true;
        }

        if (whichCharacter == 1)
        {
            JumpButtonRed.interactable = true;
            JumpButtonBlue.interactable = false;
        }
    }
   
    public void Swap()
    {
        character = possibleCharacters[whichCharacter];
        character.GetComponent<TestPlayersControl>().enabled = true;
        
        for (int i = 0; i<possibleCharacters.Count; i++)
        {
            if(possibleCharacters[i] != character)
            {
                possibleCharacters[i].GetComponent<TestPlayersControl>().enabled = false;
            }
        }
    }
    
    public void Switch()
    {
        if(whichCharacter == 0)
        {
            whichCharacter = possibleCharacters.Count - 1;
        }
        else
        {
            whichCharacter -= 1;
            
            
        } 
        Swap();
    }
}
