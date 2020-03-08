using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Script : MonoBehaviour
{

    public static float finish;
    private Text countdown;
    float timer = 15;

    private void Start()
    {
        countdown = GameObject.Find("Countdown_Text").GetComponent<Text>();
        StartCoroutine(countDown());
    }

    IEnumerator countDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timer = timer - 1;
            countdown.text = timer.ToString();
        }
    }
    void Update()
    {
        if (finish == 2)
        {
            SceneManager.LoadScene("Win_Screen");
            finish = 0;
        }

        if (timer == 0)
        {
            SceneManager.LoadScene("Lose_Screen");
        }
    }
}
