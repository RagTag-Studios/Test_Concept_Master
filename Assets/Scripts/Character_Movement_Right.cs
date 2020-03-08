using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement_Right : MonoBehaviour
{

    private Collider2D player;
    private Collider2D ground;

    public CharacterController2D_Right controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;

    bool jump = false;

    private void Start()
    {
        player = GameObject.Find("Right_Character").GetComponent<Collider2D>();
        ground = GameObject.Find("level1").GetComponent<Collider2D>();
    }


    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal_Right") * runSpeed;
      
        if (Input.GetButtonDown("Jump_Right"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {

        if (player.IsTouching(ground))
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        }
        else
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
        }

        jump = false;
    }
}
