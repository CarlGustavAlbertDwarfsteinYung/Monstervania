using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallMove : MonoBehaviour
{

    public float speed;

    private Transform player;
    private Vector2 target;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //print("HitPlayer");
            game_controls.health = game_controls.health - 1;
        }
    }
}
