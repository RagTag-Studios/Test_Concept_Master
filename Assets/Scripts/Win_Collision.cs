using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_Collision : MonoBehaviour
{

    private float player1;
    private float player2;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Left_Character")
        {
            if (player1 == 0)
            {
                Level_Script.finish = Level_Script.finish + 1;
                player1 = 1;
            }
        }

        if (col.gameObject.name == "Right_Character")
        {
            if (player2 == 0)
            {
                Level_Script.finish = Level_Script.finish + 1;
                player2 = 1;
            }
        }
    }

}
