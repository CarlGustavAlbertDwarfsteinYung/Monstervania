using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying_enemy : MonoBehaviour {
	float moveSpeed = 1f;
	float frequency = 2f;
	float magnitude = 0.5f;

	bool facingRight = true;

	Vector3 pos, localScale;

	
    int shot_time;
    const int start_shot_time = 60;

	// Use this for initialization
	void Start () {
        shot_time = start_shot_time;
        pos = transform.position;
		localScale = transform.localScale;

		Physics2D.IgnoreLayerCollision(10, 31);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (game.start == true) {
				if (shot_time > 0) {
            shot_time--;
        } else {
            //RaycastHit2D hit = Physics2D.Raycast(transform.position,player.transform.position);
            //if(hit.collider!=null)
            //{
                //GameControlScript.health = GameControlScript.health - 1;
            //}

            //Quaternion q = Quaternion.FromToRotation(transform.position, player.position);
            //Quaternion q = Quaternion.LookRotation(transform.position);
            Instantiate(Resources.Load("fireball"), transform.position,Quaternion.identity);

           //>>>> Vector2 lookAt = player.transform.position - g.transform.position;
           // Vector2 mov = transform.forward * 5f;
            //g.transform.rotation = Quaternion.Slerp(g.transform.rotation, Quaternion.LookRotation(lookAt),Time.deltaTime);
           //>>>>>  g.transform.rotation = Quaternion.FromToRotation(new Vector2(Mathf.Abs(g.transform.position.x),g.transform.position.y), player.transform.position);
            //g.transform.rotation = Quaternion.LookRotation(lookAt);
            shot_time = start_shot_time;

            //print(transform.position + "   " + player.position +" "+ transform.position.magnitude);
        }

		CheckWhereToFace ();

		if (facingRight)
			MoveRight ();
		else
			MoveLeft ();
		}
	}

	void CheckWhereToFace()
	{
		if (pos.x < -2.7f)
			facingRight = true;
		
		else if (pos.x > 2.7f)
			facingRight = false;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;

	}

	void MoveRight()
	{
		pos += transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
	}

	void MoveLeft()
	{
		pos -= transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
	}
}
