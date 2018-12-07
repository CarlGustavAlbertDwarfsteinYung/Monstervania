using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaling : MonoBehaviour {

    Sprite sprite;
    float x;
    float y;
    float prev_y;

    Collider2D scaleCol;
    // Use this for initialization
    void Start() {
        //sprite = GetComponent<Sprite>();
        x = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position.y >= -1.3 && transform.position.y <= 0)
        {
            transform.localScale = new Vector2(1, 1) * Mathf.Abs(transform.position.y) * 0.83333f;

            transform.position = new Vector3(x * transform.position.y, transform.position.y);


            //gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0, transform.position.y);
        }
        else
        {
            transform.localScale = new Vector2(0, 0);
        }

    }
}
