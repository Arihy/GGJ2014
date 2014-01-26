using UnityEngine;
using System.Collections;

public class Pause2 : MonoBehaviour {

	// Use this for initialization

	public GUITexture MenuPause;
	public GUIText Reprendre;
	public GUIText Menu;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		if( this.name == "menu") 
		{
			Debug.Log("menu");
			Application.LoadLevel("SceneMenu");
		}
		
		if( this.name == "pauseTexte") 
		{
			Time.timeScale = 1.0f;
			MenuPause.enabled = false;
			Reprendre.enabled = false;
			Menu.enabled = false;
			Debug.Log("reprendre");
		}
	}
}
