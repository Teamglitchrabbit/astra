using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDoorTransition : MonoBehaviour
{

    private bool isinDoor = false;

    SceneTransitionCode Transitioning_Script;



    public void OnTriggerExit2D(Collider2D other)
    {
        isinDoor = false;
    }

   public void OnTriggerEnter2D(Collider2D DoorInfo)
    {
        Transitioning_Script = DoorInfo.GetComponent<SceneTransitionCode>();
        isinDoor = true;
    }

    public void Update()
    {
        if (isinDoor && Transitioning_Script != null && Input.GetButtonDown("Interaction"))
        {
            SceneManager.LoadScene(Transitioning_Script.SceneCode);
        }
    }


}
