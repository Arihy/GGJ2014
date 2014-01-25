using UnityEngine;
using System.Collections;

public class chrono : MonoBehaviour {
	
	float time = 10.0f;

	public AudioClip FinTemps;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update()
	{
		time -= Time.deltaTime;

		if (time < 1) {
			audio.PlayOneShot(FinTemps, 1);
		}

	}

	void OnGUI()
	{
		GUI.Box(new Rect(820,17,75,25), time.ToString());
		//GUI.Label(new Rect(900,20,50,50), time.ToString());
	}

}
