using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public static bool game_over = false;
    public static float health = 10.0f;
    public static float height; //defines jumping
    public static float y = -1.184f;
    GameObject map;
    GameObject mountain;
    GameObject sky;
    Rigidbody2D rb;
    Camera cam;
    Collider2D col;
    Animator anim;
    float sidestep_speed = 0.4f;
    float jump_speed = 16.0f;
    //AudioSource sound;
    float hor;
    float ver;
    bool jump = false;

    const float move_speed = 0.008f;
    const float distance_speed = 0.00001f;
    const float sky_speed = 0.0025f;

    // Use this for initialization
    void Start () {
        map = GameObject.Find("map");
        mountain = GameObject.Find("mountain");
        sky = GameObject.Find("sky");

        anim = gameObject.GetComponentInChildren<Animator>();
        rb = gameObject.GetComponentInChildren<Rigidbody2D>();
        //sound = gameObject.GetComponentInChildren<AudioSource>();
        col = gameObject.GetComponentInChildren<Collider2D>();
        y = transform.position.y;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //cam.transform.position = new Vector3(transform.position.x, cam.transform.position.y, cam.transform.position.z);
       // hor = Input.GetAxisRaw("Horizontal");
       // jump = Input.GetAxisRaw("Vertical");

        anim.SetBool("jump", jump);
        anim.SetFloat("ver", ver);
        anim.SetFloat("hor", hor);

        height = col.transform.position.y;
        
        bool ground = col.IsTouchingLayers(LayerMask.GetMask("Ground"));

        // JUMP
        if (Input.GetKey(KeyCode.Space) && ground)
        {
            rb.AddForce(new Vector2(0,  jump_speed));
            jump = true;
        } 
        else if (jump && ground) {
            jump = false;
        }

        // FORWARD BACKWARDS
        if (Input.GetKey(KeyCode.W) && map.transform.position.y > -40)
        {
            map.transform.position = new Vector2(map.transform.position.x, map.transform.position.y - move_speed);
            mountain.transform.localScale = new Vector2(mountain.transform.localScale.x + distance_speed, mountain.transform.localScale.y + distance_speed);
            sky.transform.position = new Vector2(sky.transform.position.x, sky.transform.position.y + sky_speed);
            ver = 1;
        }
        else if (Input.GetKey(KeyCode.S) && map.transform.position.y < 0)
        {
            map.transform.position = new Vector2(map.transform.position.x, map.transform.position.y + move_speed);
            mountain.transform.localScale = new Vector2(mountain.transform.localScale.x - distance_speed, mountain.transform.localScale.y - distance_speed);
            sky.transform.position = new Vector2(sky.transform.position.x, sky.transform.position.y - sky_speed);
            ver = -1;
        } else if (ver != 0) {
            ver = 0;
        }

        // SIDESTEP
        if (Input.GetKey(KeyCode.D))
        {
       	    if (transform.position.x < 1.8f)
				transform.position += Vector3.right * sidestep_speed * Time.deltaTime;     
           
            hor = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.8f)
				transform.position += Vector3.left * sidestep_speed * Time.deltaTime;
            
            hor = -1;
        } else if (hor != 0) {
            hor = 0;
        }
    }

    public static bool compare_values(float f1, float f2, float f3) {
        Debug.Log(f1 + "    " + f2);
        if ((f1 <= (f2 + f3)) && (f1 >= (f2 - f3))) {
            return true;
        }

        return false;
    }
}
