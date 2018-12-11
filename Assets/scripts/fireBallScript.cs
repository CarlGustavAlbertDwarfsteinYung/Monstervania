using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallScript : MonoBehaviour {

    private float timeBtwnShots;
    public float startTimeBtwnShots;

    public GameObject projectile;
    private Transform player;
	// Use this for initialization
	void Start () {
        timeBtwnShots = startTimeBtwnShots;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
	
	// Update is called once per frame
	void Update () {
		if(timeBtwnShots<=0)
        {

            //RaycastHit2D hit = Physics2D.Raycast(transform.position,player.transform.position);
            //if(hit.collider!=null)
            //{
                //GameControlScript.health = GameControlScript.health - 1;
            //}

            //Quaternion q = Quaternion.FromToRotation(transform.position, player.position);
            //Quaternion q = Quaternion.LookRotation(transform.position);
            GameObject g= Instantiate(projectile, transform.position,Quaternion.identity);

            Vector2 lookAt = player.transform.position - g.transform.position;
            Vector2 mov = transform.forward * 5f;
            //g.transform.rotation = Quaternion.Slerp(g.transform.rotation, Quaternion.LookRotation(lookAt),Time.deltaTime);
             g.transform.rotation = Quaternion.FromToRotation(new Vector2(Mathf.Abs(g.transform.position.x),g.transform.position.y), player.transform.position);
            //g.transform.rotation = Quaternion.LookRotation(lookAt);
            timeBtwnShots = startTimeBtwnShots;

            //print(transform.position + "   " + player.position +" "+ transform.position.magnitude);
        }
        else
        {
            timeBtwnShots = timeBtwnShots - Time.deltaTime;
        }
	}
}
