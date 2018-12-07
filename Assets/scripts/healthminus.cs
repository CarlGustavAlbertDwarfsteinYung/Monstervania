using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthminus : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("in plus");
            game_controls.health += 1;

        }
    }
}