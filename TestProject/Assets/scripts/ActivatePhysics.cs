using UnityEngine;
using System.Collections;

public class ActivatePhysics : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		other.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 1;
		Destroy (gameObject);
	}
}
