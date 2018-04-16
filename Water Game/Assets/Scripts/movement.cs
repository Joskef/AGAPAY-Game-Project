using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public float mover;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () {
		

		if (Input.GetKey ("up")) {
			this.transform.Translate(0,0,mover);
		}
		if (Input.GetKey ("down")) {
			this.transform.Translate(0,0,-mover);
		}
		if (Input.GetKey ("left")) {
			this.transform.Translate(-mover,0,0);
		}
		if (Input.GetKey ("right")) {
			this.transform.Translate(mover,0,0);
		}

	}
}
