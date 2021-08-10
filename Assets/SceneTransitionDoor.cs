using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionDoor : MonoBehaviour
{
    // Reference the scene that is going to be transisioned to
    public string SceneToLoad;

    public void MoveScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
