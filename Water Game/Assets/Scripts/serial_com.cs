using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO.Ports;


public class serial_com : MonoBehaviour {
	SerialPort serial_arm;
	SerialPort serial_hand;
	public double[] values;
	public string[] labels;

	// Use this for initialization
	void Start () {
		serial_arm = new SerialPort ("COM4", 38400);
		serial_arm.Open ();
		//serial_arm.ReadTimeout=1;

		//serial_hand = new SerialPort ("COM5", 19200);
		//serial_hand.Open ();
	}
	
	// Update is called once per frame
	void Update () {

		set_arm_values ();


	}

	public void set_hand_values(){
		try{

		}
		catch(Exception e){

		}
	
	}

	public void set_arm_values(){
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
	public double map(double x, double in_min, double in_max, double out_min, double out_max)
	{
		return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
	}



}
