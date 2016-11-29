using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	public GameObject enemy;
	public Vector3 position;
	public Quaternion rotation;
	void Start () {
		InvokeRepeating ("Spawn", 1, 5);
	}

	// Update is called once per frame
	void Update () {

	}

	void Spawn()
	{
		Instantiate (enemy, position, rotation);
	}
}
