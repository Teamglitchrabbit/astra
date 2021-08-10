using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleClick : MonoBehaviour {

    private float firstClickTime;
    private float timeBetweenClicks;
    private bool coroutineAllowed;
    private int clickCounter;

    public bool whenDoubleClick = false;

    // Start is called before the first frame update
    void Start()
    {
        firstClickTime = 0f;
        timeBetweenClicks = 0.3f;
        clickCounter = 0;
        coroutineAllowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Starts looking for double clicks
        if (Input.GetButtonUp("Horizontal"))
            clickCounter += 1;

        if (clickCounter == 1 && coroutineAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DoubleClickDetection());
        }
    }

    private IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;
        while (Time.time < firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {
                whenDoubleClick = true;
                Debug.Log("Double Click");
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }
}
