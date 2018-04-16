using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO.Ports;


public class serial_com : MonoBehaviour {
	SerialPort serial_arm;
	public double[] values;
	public string[] labels;

	// Use this for initialization
	void Start () {
		serial_arm = new SerialPort ("COM4", 38400);
		serial_arm.Open ();
		//serial_arm.ReadTimeout=1;
	}
	
	// Update is called once per frame
	void Update () {

		try{
		values [0] = convert_to_floatdegrees(serial_arm.ReadLine());
		values [1] = convert_to_floatdegrees(serial_arm.ReadLine());
		values [2] = convert_to_floatdegrees(serial_arm.ReadLine());
		values [3] = convert_to_floatdegrees(serial_arm.ReadLine());
		}
		catch(Exception e){
		
		}


	}




	public double convert_to_floatdegrees(string x){

		return (double.Parse (x)/2.861);
		

		}



}
