using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_Movement : MonoBehaviour
{

    private Collider2D player;
    private Collider2D ground;

    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;

    bool jump = false;

    private void Start()
    {
        player = GameObject.Find("Left_Character").GetComponent<Collider2D>();
        ground = GameObject.Find("level1").GetComponent<Collider2D>();
    }

    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
      
        if (Input.GetButtonDown("Jump"))
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
