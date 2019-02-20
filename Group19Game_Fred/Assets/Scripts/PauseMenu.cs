using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    
    public static bool paused = false;
    public GameObject PauseUI;

    //acts as an escape menu, when esc is pushed, time freezes and menu shows

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
        
        
    }

    public void Paused()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;

    }




}
