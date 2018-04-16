using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finger_control : MonoBehaviour {
	public GameObject[] pinky;
	public GameObject[] index;
	public GameObject[] middle;
	public GameObject[] ring;
	public GameObject[] thumb;
	// Use this for initialization

	public int x;
	public int rate;
	void Start () {
	 x = 0;	
		rate = 2;
	}
	
	// Update is called once per frame
	void Update () {
		int value = 100;

		if (Input.GetKey ("z")) {
			grab (pinky, x);
			grab(index, x);
			grab (middle, x);
			grab (ring, x);
			grab (thumb, x);
				x+=rate;
		}
		if(Input.GetKey ("c")) {
			grab (pinky, x);
			grab(index, x);
			grab (middle, x);
			grab (ring, x);
			grab (thumb, x);
				x-=rate;
		}

	//	Debug.Log (x);
		if (Input.GetKey ("v")) {
			pinch (pinky, x);
			pinch(index, x);
			pinch (middle, x);
			pinch (ring, x);
			pinch (thumb, x);
			x+=rate;
		}
		if(Input.GetKey ("n")) {
			pinch (pinky, x);
			pinch(index, x);
			pinch (middle, x);
			pinch (ring, x);
			pinch (thumb, x);
			x-=rate;
		}


		if (x > 100) {
			x = 100;
		}
		if(x<0){
			x=0;
		}

	}




	void grab(GameObject[] fingers, float value){

		fingers [0].transform.localEulerAngles = new Vector3(0,-(90*value/100),0); 
		fingers [1].transform.localEulerAngles = new Vector3 (0, -(60*value/100), 0);//new Vector3(fingers[1].transform.eulerAngles.x, fingers[1].transform.eulerAngles.y, fingers[1].transform.eulerAngles.z); 
		if(fingers.Length>2)
		fingers [2].transform.localEulerAngles =new Vector3 (0, -(60*value/100), 0);// new Vector3(fingers[2].transform.eulerAngles.x, fingers[2].transform.eulerAngles.y, fingers[2].transform.eulerAngles.z); 


	}


	void pinch(GameObject[] fingers, float value){

		fingers [0].transform.localEulerAngles = new Vector3(0,-(90*value/100),0); 
		fingers [1].transform.localEulerAngles = new Vector3 (0, -(10*value/100), 0);//new Vector3(fingers[1].transform.eulerAngles.x, fingers[1].transform.eulerAngles.y, fingers[1].transform.eulerAngles.z); 
		if(fingers.Length>2)
		fingers [2].transform.localEulerAngles =new Vector3 (0, -(10*value/100), 0);// new Vector3(fingers[2].transform.eulerAngles.x, fingers[2].transform.eulerAngles.y, fingers[2].transform.eulerAngles.z); 


	}







}
