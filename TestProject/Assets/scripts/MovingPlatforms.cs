using UnityEngine;
using System.Collections;

public class MovingPlatforms : MonoBehaviour {
    public GameObject Platform;
    public float speed = 8;
    public float min;
    public float max;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x <= min)
        {
            Platform.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if(transform.position.x >= max)
        {
            Platform.transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }
    }

}
