using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_controls : MonoBehaviour {

    public GameObject heart1, heart2, heart3,gameOver;
    public static bool isGameOver=false;
    public static int health;

    private GameObject ghost;
    // Use this for initialization
    void Start () {
        ghost = GameObject.FindGameObjectWithTag("ghost");
        ghost.SetActive(false);

        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.SetActive(false);
        isGameOver = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (health > 3)
            health = 3;
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.SetActive(true);
                isGameOver = true;
                Time.timeScale = 0;
                break;
        }
		
	}
}
