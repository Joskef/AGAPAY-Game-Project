using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateGlassX : MonoBehaviour
{
	public GameObject Target;

	void Start()
	{
		
	}

	public void UpdateX(float sliderValue)
	{
		Target.transform.position = new Vector3(sliderValue, Target.transform.position.y, Target.transform.position.z);
	}
}