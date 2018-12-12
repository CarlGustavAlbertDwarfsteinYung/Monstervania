using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public float speed;
    //private Transform player;
    private Vector2 target;
    GameObject pl;
    // Use this for initialization
    void Start()
    {
        pl = GameObject.Find("player");
        target = new Vector2(pl.transform.position.x, pl.transform.position.y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    // damage player and leave
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.name == "player_body")
        {
            Destroy(gameObject);
            player.health -= 1;
        }

    }
}
