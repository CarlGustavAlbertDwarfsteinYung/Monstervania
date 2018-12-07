using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    GameObject mountain;
    GameObject sky;
    
    public float speed = 0.004f;
    public float distance_speed = 0.00001f;
    public float sky_speed = 0.0025f;


    // Use this for initialization
    void Start () {
        mountain = GameObject.FindGameObjectWithTag("mountain");
        sky = GameObject.FindGameObjectWithTag("sky");
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
            mountain.transform.localScale = new Vector2(mountain.transform.localScale.x + distance_speed, mountain.transform.localScale.y + distance_speed);
            sky.transform.position = new Vector2(sky.transform.position.x, sky.transform.position.y + sky_speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
            mountain.transform.localScale = new Vector2(mountain.transform.localScale.x - distance_speed, mountain.transform.localScale.y - distance_speed);
            sky.transform.position = new Vector2(sky.transform.position.x, sky.transform.position.y - sky_speed);
        }
		
	}
}
