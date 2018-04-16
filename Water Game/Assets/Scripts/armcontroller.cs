using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armcontroller : MonoBehaviour {
	public GameObject upper_arm;
	public GameObject lower_arm;
	public GameObject serial_child;
	public double[] values;
	// Use this for initialization
	void Start () {
		//gameObject.GetComponent<finger_control> ()
	}
	
	// Update is called once per frame
	void Update () {
		//values = serial_child.GetComponent<serial_com> ().values().Clone;
		//Debug.Log(serial_child.GetComponent<serial_com> ().values[0]);
		values=serial_child.GetComponent<serial_com> ().values;


		manualcontrol ();

		float army = (float)(73-values [0]);
		float armx = (float)(62-values [1]);
		float armz = (float)(151-values [2]);
		float elbow = (float)(34-values [3]);
		upper_arm.transform.localEulerAngles = new Vector3(army,armx,-armz); 
		lower_arm.transform.localEulerAngles = new Vector3(0,0,elbow);
	}




	public void manualcontrol(){

			if(Input.GetAxis("Mouse Y")<0){
				//Code for action on mouse moving left
				upper_arm.transform.Rotate(0,0,-1*Input.GetAxis("Mouse Y"));

			}
			if(Input.GetAxis("Mouse Y")>0){
				//Code for action on mouse moving right
				upper_arm.transform.Rotate(0,0,-1*Input.GetAxis("Mouse Y"));
			}
			if(Input.GetAxis("Mouse X")<0){
				//Code for action on mouse moving left
				upper_arm.transform.Rotate(0,1*Input.GetAxis("Mouse X"),0);
			}
			if(Input.GetAxis("Mouse X")>0){
				//Code for action on mouse moving right
				upper_arm.transform.Rotate(0,1*Input.GetAxis("Mouse X"),0);
			}
			if (Input.GetAxis ("Mouse ScrollWheel") > 0) {
				lower_arm.transform.Rotate(0,0,30*Input.GetAxis ("Mouse ScrollWheel"));
			}
			if (Input.GetAxis ("Mouse ScrollWheel") < 0) {
				lower_arm.transform.Rotate(0,0,30*Input.GetAxis ("Mouse ScrollWheel"));
			}
	
	}
}
