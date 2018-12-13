using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulder : MonoBehaviour {
	float y;
	float speed = 0.28f;
	bool pl_hit;

	void Start() {
		y = transform.position.y;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (game.start == true) {
			//transform.position = new Vector2(transform.position.x, y);

			transform.position += Vector3.down * speed * Time.deltaTime; 

			if (transform.position.y < -2) {
				Destroy(gameObject);
				Debug.Log("hello");
			} 

			pl_hit = GetComponent<Collider2D>().IsTouchingLayers(LayerMask.GetMask("Player"));


			if (player.compare_values(player.y, transform.position.y, 0.02f) && pl_hit) {
				if (player.height < 0.1f) {
					Destroy(gameObject);
					player.health -= 1;
				}
			}
		}
	}
}
