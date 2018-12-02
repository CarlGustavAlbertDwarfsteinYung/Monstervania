using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusHeart : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("in plus");
            GameControlScript.health += 1;

        }
    }
}