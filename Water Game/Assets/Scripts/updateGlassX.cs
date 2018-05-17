using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateGlassX : MonoBehaviour
{
    //THIS SCRIPT IS BASICALLY OBSOLETE
	public GameObject Target;

	void Start()
	{
		
	}

	public void UpdateX(float sliderValue)
	{
		Target.transform.position = new Vector3(sliderValue, Target.transform.position.y, Target.transform.position.z);
	}

	public void UpdateY(float sliderValue)
	{
		Target.transform.position = new Vector3(Target.transform.position.x, sliderValue, Target.transform.position.z);
	}

	public void UpdateZ(float sliderValue)
	{
		Target.transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y, sliderValue);
	}
}