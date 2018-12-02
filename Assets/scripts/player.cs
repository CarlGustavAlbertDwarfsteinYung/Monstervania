using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    GameObject mountain;
    GameObject sky;


    // Use this for initialization
    void Start () {
        mountain = GameObject.FindGameObjectWithTag("mountain");
        sky = GameObject.FindGameObjectWithTag("sky");


    }
	
	// Update is called once per frame
	void FixedUpdate () {


        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.004f);
            mountain.transform.localScale = new Vector2(mountain.transform.localScale.x + 0.0001f, mountain.transform.localScale.y + 0.0001f);
            sky.transform.position = new Vector2(sky.transform.position.x, sky.transform.position.y + 0.0025f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.004f);
            mountain.transform.localScale = new Vector2(mountain.transform.localScale.x - 0.0001f, mountain.transform.localScale.y - 0.0001f);
            sky.transform.position = new Vector2(sky.transform.position.x, sky.transform.position.y - 0.0025f);
        }
		
	}
}
