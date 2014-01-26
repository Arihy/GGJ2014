using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

	// Use this for initialization
	public bool isPause;
	public GUITexture MenuPause;
	public GUIText Reprendre;
	public GUIText Menu;

	void Start () {
		isPause = false;
		MenuPause.enabled = false;
		Reprendre.enabled = false;
		Menu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if((!isPause)&&(Input.GetKeyUp(KeyCode.Escape)))
		{

			Time.timeScale = 0.0F;
			isPause = true;
			MenuPause.enabled = true;
			Reprendre.enabled = true;
			Menu.enabled = true;

			if(MenuPause.enabled)
				Debug.Log("true");
		}

		else if((isPause)&&(Input.GetKeyUp(KeyCode.Escape)))
		{
			Time.timeScale = 1.0F;
			isPause = false;
			MenuPause.enabled = false;
			Reprendre.enabled = false;
			Menu.enabled = false;

			if(!MenuPause.enabled)
				Debug.Log("false");
		}
		else;

	}

}
