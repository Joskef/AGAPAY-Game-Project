using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handcontrol : MonoBehaviour {
	public GameObject wrist;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey ("w")) {
			wrist.transform.Rotate(0,1,0);
		}
		if (Input.GetKey ("s")) {
			wrist.transform.Rotate(0,-1,0);
		}
		if (Input.GetKey ("a")) {
			wrist.transform.Rotate(-1,0,0);
		}
		if (Input.GetKey ("d")) {
			wrist.transform.Rotate(1,0,0);
		}


	}
}
