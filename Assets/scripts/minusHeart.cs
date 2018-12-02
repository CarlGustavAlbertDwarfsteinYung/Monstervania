using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minusHeart : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "Player")
        {
            Debug.Log("in minus");
            GameControlScript.health -= 1;
        }
    }
}
