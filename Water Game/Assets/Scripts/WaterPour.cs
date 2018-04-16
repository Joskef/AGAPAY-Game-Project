using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class WaterPour : MonoBehaviour {

    // Use this for initialization
    public GameObject water;
    double waterLevel, originalLevel;
    double waterScore;

    public double threshhold=20;

    public double origOrientation;
    
	void Start () {
        waterLevel = water.transform.localScale.z;
        originalLevel = waterLevel;
        waterScore = 100;
        origOrientation = 270;
    }
	
	// Update is called once per frame
	void Update () {

        if (waterScore > 0) { 
        waterLevel = originalLevel * (waterScore / 100);
        water.transform.localScale = new Vector3(water.transform.localScale.x, water.transform.localScale.y, (float)waterLevel);
        }
        else
        {
            waterScore = 0;
        }

        if (Math.Abs(origOrientation - transform.rotation.eulerAngles.x) > threshhold)
            waterScore--;

        threshhold = 20 + (1-waterScore / 100) *90;
        
    }
}
