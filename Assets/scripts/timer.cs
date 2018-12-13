using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour {

    public GameObject gameOver;
    float timeLeft = 180.0f;
    private string zero = "00:00"; 
    public Text TimerText;
    private void Start()
    {
       // TimerText.text = "Time: ";
    }
    void Update()
    {
        string timeString="";
        if (player.game_over)
        {
            //ssDebug.Log("inside");
            TimerText.text = "Time: " + timeString;

        }
        else
        {
            timeLeft -= Time.fixedDeltaTime;
            int seconds = (int)(timeLeft % 60);
            int minutes = (int)(timeLeft / 60) % 60;
             timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
            TimerText.text = "Time: " + timeString;
            if (timeString == zero)
            {
                timeLeft = 0.0f;
                gameOver.gameObject.SetActive(true);
                player.game_over = true;
                Time.timeScale = 0;

            }
        }
    }

}
