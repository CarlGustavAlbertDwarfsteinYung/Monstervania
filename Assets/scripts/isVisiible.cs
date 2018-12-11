using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isVisiible : MonoBehaviour {
    Renderer m_Renderer;
    private GameObject ghost;
    // Use this for initialization
    void Start () {
        m_Renderer = GetComponent<SpriteRenderer>();
        ghost = GameObject.FindGameObjectWithTag("ghost");
    }
	
	// Update is called once per frame
	void Update () {
		if(m_Renderer.isVisible)
        {
            print("I am on screen now");
            ghost.SetActive(true);
        }
	}

    void OnBecameVisible()
    {
        print("I am on screen now");
    }
}
