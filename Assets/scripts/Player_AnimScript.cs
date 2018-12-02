using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AnimScript : MonoBehaviour {
    public Camera cam;
    Collider2D playerCollider;
    public Animator playAnim;
    public Rigidbody2D rb;
    public float speed = 10f;
    AudioSource sound;
    public float hor;
    public float ver;
    // Use this for initialization
    void Start () {
        playAnim = gameObject.GetComponentInChildren<Animator>();
        rb = gameObject.GetComponentInChildren<Rigidbody2D>();
        sound = gameObject.GetComponentInChildren<AudioSource>();
        playerCollider = gameObject.GetComponentInChildren<PolygonCollider2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        cam.transform.position = new Vector3(transform.position.x, cam.transform.position.y, cam.transform.position.z);
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");
        playAnim.SetFloat("straightWalk", ver);
        playAnim.SetFloat("sideWalk", hor);
        if (Input.GetKey(KeyCode.D))
        {
            hor = hor + 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            hor = hor - 1;
        }
        Vector2 mov = new Vector2(hor, 0);
        rb.velocity = (mov * speed ) / 2;
        if(hor==0 && ver == 0)
        {
            sound.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playAnim.SetTrigger("jumpTrigger");
            Debug.Log("HereJump");
            rb.AddForce(new Vector2(0, 30), ForceMode2D.Impulse);
            //gameObject.GetComponentInChildren<CapsuleCollider2D>().enabled = false;
            //rb.velocity = Vector2.up * 20;
        }

    }
}
