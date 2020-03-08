using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Cam_Follow : MonoBehaviour
{

    public Transform player;

    private void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

}
