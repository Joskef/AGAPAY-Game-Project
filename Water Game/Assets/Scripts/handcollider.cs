using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handcollider : MonoBehaviour {
	public int x;
	public GameObject picked_item;
	public bool touching;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x = gameObject.GetComponent<finger_control> ().x;
		//Debug.Log (touching);

		if (x >= 50&&touching) {
			picked_item.transform.SetParent (gameObject.transform);
			//Destroy(collision.gameObject,2.0f);
			picked_item.GetComponent<Rigidbody> ().useGravity = false;
			picked_item.GetComponent<Rigidbody> ().detectCollisions=false;

		} 
		if (picked_item != null&&x<=50) {
			picked_item.transform.SetParent (null);
			//Destroy(collision.gameObject,2.0f);
			picked_item.GetComponent<Rigidbody> ().useGravity = true;
			picked_item.GetComponent<Rigidbody> ().detectCollisions = true;
			//picked_item = null;
		}
	}


	void OnCollisionEnter(Collision collision)
	{
		touching = true;
		picked_item = collision.gameObject;

	}




}
