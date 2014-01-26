using UnityEngine;
using System.Collections;

public class EndMenu : MonoBehaviour {

	// Use this for initialization
	public GUIText g;
	void Start () {
		OnGui ();
	}
	void OnGui()
	{
		if (this.name == "s1") 
		{
			Debug.Log("teste");
			g.text = g.text + Observer.scoreJ1;
		}
		if (this.name == "s2") 
		{	
			g.text += Observer.scoreJ2;
		}
		if (this.name == "cloneBlue") 
		{
			g.text += Observer.nbBotJ1;
		}
		if (this.name == "cloneRed") 
		{
			g.text += Observer.nbBotJ2;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		
		Debug.Log ("avant test du nom");

		if (this.name == "Menu") 
		{

		Debug.Log ("apres test du nom");
			
			Application.LoadLevel("SceneMenu");
		}
		
		
	}


}
