using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = new Vector2(transform.position.x, transform.position.y - 0.004f);
	
		if (transform.position.y < -10) {
			Destroy(gameObject);
		}

		bool pl_hit = GetComponent<Collider2D>().IsTouchingLayers(LayerMask.GetMask("Player"));

		if (pl_hit) {
			if (player.compare_values(GameObject.Find("player_body").transform.position.y + GameObject.Find("player").transform.position.y, transform.position.y, 0.1f)) {
				Destroy(gameObject);
				player.health -= 1;
			}
		}

	}
}
