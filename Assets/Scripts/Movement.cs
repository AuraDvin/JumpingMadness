using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public isGrounded;
    private float movementspd = 40f;
    public CharacterController2D controller2D;
    float horizontalMove = 0f;
    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       horizontalMove = Input.GetAxisRaw("Horizontal") * movementspd; // A = -1 and D = 1
        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire2") ) { 
            jump = true;
            //Debug.Log("Jumped lol ");
        }
        else jump = false;

    }

    void FixedUpdate(){
        //Movement of the character (in the Character controller script)
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
    }
}
