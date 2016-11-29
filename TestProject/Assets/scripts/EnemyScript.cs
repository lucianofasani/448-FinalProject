﻿using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public float speed;
	public int direction = -1;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-Vector2.right * speed * Time.deltaTime*direction);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.name == "BackWall" || col.gameObject.name == "KillWall") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "wall") {
			direction = direction * -1;
		}
    }
}
