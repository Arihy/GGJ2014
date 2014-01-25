﻿using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float _myTimer = 30;
	private int _min;
	private int _sec;
	private bool actualize = false;
	private float wait = 0.2f;
	private GUIText _text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!actualize) {
			StartCoroutine (Pause());			
		}
	}

	IEnumerator Pause() {
		actualize = true;
		yield return new WaitForSeconds (wait);
		_myTimer--;
		Convert ();
		UpdateText ();
		actualize = false;
	}

	//Covert the Timer into minutes and seconds
	void Convert(){
		_min = (int)_myTimer / 60;
		_sec = (int)_myTimer % 60;
	}

	//Création de text
	void UpdateText(){
		if (_sec <= 10) {
			if (_min <= 10) {
				_text.text = "0" + _min.ToString () + " : " + "0" + _sec.ToString ();
			} 
			else {
				_text.text = _min.ToString () + " : " + "0" + _sec.ToString ();
			}
		} 
		else{
			if (_min <= 10) {
				_text.text = "0" + _min.ToString () + " : " + _sec.ToString ();
			} 
			else{
				_text.text = _min.ToString () + " : " + _sec.ToString ();
			}
		}
	}



}
