using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Checks weather or not the game is paused
    public static bool GameisPaused = false;

    // The Pause menu it self
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetButtonDown("Pause")) {
              
            if (GameisPaused) {
                 Resume();
            } else {
                 Pause();
            }

        } 
    }

    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    void Pause()
    {
        Debug.Log("Call 2");
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

}
