using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoorTransition : MonoBehaviour
{

    private bool isinDoor = false;

    GameObject Transitioning;

    SceneTransitionDoor Transitioning_Script;



    public void OnTriggerExit2D(Collider2D other)
    {
        isinDoor = false;
    }

   public void OnTriggerEnter2D(Collider2D DoorInfo)
    {
        Transitioning_Script = DoorInfo.GetComponent<SceneTransitionDoor>();
        isinDoor = true;
    }

    public void Update()
    {
        if (isinDoor && Input.GetButtonDown("Interaction"))
        {
            Transitioning_Script.MoveScene();
        }
    }


}
