using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*void OnGUI()
	{
		GUI.Box(new Rect(0, 0, Screen.width/20, Screen.height/8), "Play");
		//GUI.Label(new Rect(20,40,80,20), "Health : " + _health);
		//GUI.Label(new Rect(20,60,80,20), "Speed : " + _speed);
	}*/

	void OnMouseDown() {

		GameObject cam = GameObject.Find("Main Camera");

		if( this.name == "Play") 
		{
			Debug.Log ("play");
			Application.LoadLevel("level1");
		}

		if( this.name == "Help") 
		{
			Debug.Log ("help");
			// transform.Translate(Vector3.forward * Time.deltaTime);
			cam.transform.Translate(-40,0,0);
		}

		if( this.name == "Quit") 
		{
			Debug.Log ("quit");
			Application.Quit();
		}

		if( this.name == "Back") 
		{
			Debug.Log ("return");
			cam.transform.Translate(40,0,0);
		}


	}
}
