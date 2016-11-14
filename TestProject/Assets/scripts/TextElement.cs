using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class AddText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void addText (GameObject myObject, string name, string message) {
		myObject.transform.SetParent (this.transform);
	
	}
		
}
