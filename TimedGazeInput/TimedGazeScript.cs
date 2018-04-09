using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //You need to import this library to interact with the UI

public class TimedGazeScript : MonoBehaviour {

	public float MyTime = 0f;
	public Transform RadialProgress;


	// Use this for initialization
	void Start () {
		RadialProgress.GetComponent<Image> ().fillAmount = MyTime; 
	}

	// Update is called once per frame
	void Update () {
		MyTime += Time.deltaTime/2; //I am dividing by 2 to slow down the speed of the loading bar
		RadialProgress.GetComponent<Image> ().fillAmount = MyTime; // here I am setting the "fillAmount" property according to the variable "MyTime"
		if (MyTime >= 1.2f) { 
			Application.LoadLevel("YourLevelHere"); //Just a simple interaction, changing the level when the time is greater or equal to 1.2f
		}
	}

	public void Resetinator(){ // This method will reset our loading bar when the user leaves the trigger area.
		MyTime = 0f;
		RadialProgress.GetComponent<Image> ().fillAmount = MyTime;
	}
}
