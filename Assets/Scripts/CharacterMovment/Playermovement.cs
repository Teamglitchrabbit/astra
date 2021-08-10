using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {

    // refrences the character controller
    public CharacterController2D controller;

    DoubleClick SpecialClick;

    // Movement varibles
    public float runSpeed = 40f;
    public float dashSpeed;
    public float slideSpeed;

    public float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public bool isSliding = false;


    void Start()
    {
        SpecialClick = GetComponent<DoubleClick>();
    }

    public void Flip()
    {
        SpecialClick.whenDoubleClick = false;
    }

    // Update is called once per frame
    void Update() {
        
        // Side movement input
        if (SpecialClick.whenDoubleClick && !isSliding) {

            horizontalMove = Input.GetAxisRaw("Horizontal") * dashSpeed;

        } else if (SpecialClick.whenDoubleClick && crouch && !isSliding) 
        {

            StartCoroutine(Slide());

        } else {


            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        }
       

       // Jump input
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            isSliding = false;
        }
        

        // Crouch input
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;

        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    IEnumerator Slide ()
    {
        isSliding = true;

        horizontalMove = Input.GetAxisRaw("Horizontal") * slideSpeed;
        yield return new WaitForSeconds(1);
        isSliding = false;
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

    // Update is called regardless of the frame
    void FixedUpdate ()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }
}
