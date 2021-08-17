using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Checks weather or not the game is paused
    public static bool GameisPaused = false;

    // The Pause menu it self
   
    public GameObject NoteBookPage1;
    public GameObject NoteBookPage2;
    public GameObject NoteBookPage3;
    public GameObject NoteBookPage4;
    public GameObject NoteBookPage5;
    public GameObject NoteBookPage6;
    public GameObject Fade;

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
        NoteBookPage1.SetActive(false);
        NoteBookPage2.SetActive(false);
        NoteBookPage3.SetActive(false);
        NoteBookPage4.SetActive(false);
        NoteBookPage5.SetActive(false);
        NoteBookPage6.SetActive(false);
        Fade.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    void Pause()
    {
        NoteBookPage1.SetActive(true);
        Fade.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

}
