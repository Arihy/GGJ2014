using UnityEngine;
using System.Collections;

public class Chrono : MonoBehaviour {

	public int chronoInitiale;//chrono initiale
	private int chronoCourant ;//= chronoInitiale;//chrono courant, qui change tous les secondes
	public GUIText textChrono;//conposant qui affiche le chrono
	private int minutes;//contient la convertion en minute du chrono
	private int secondes;//contient la convertion en seconde du chrono
	private bool isEndChrono = false;// vraie si le chrono est finie faux sinon



	void Awake(){

		chronoCourant = chronoInitiale;

		//on récupère le composant dans lequel on affiche le chrono
		//textChrono = GameObject.Find("Interface/FondMenuHaut/Chrono").GetComponent<GUIText>();
		//on récupère le GUIText fin de match
		//affichageFinMatch = GameObject.Find("Interface/FinDeMatch").GetComponent<GUIText>();

		//mise à jour de l'affichage du chrono
		UpdateTimerText();

		//décrémente le chrono
		StartCoroutine(TimerTick());
	}


	void Start () {

	}
	

	void Update () {
	
	}

	//convertie le chrono en minutes et secondes
	void convertion(){
		minutes = chronoCourant / 60;
		secondes = chronoCourant % 60;
	}

	// Mise à jour de l'affichage du chrono
	void UpdateTimerText()
	{
		convertion();


		if(secondes == 0){
			textChrono.text = minutes.ToString() + ":" + secondes.ToString() + "0";	
		}
		else if(secondes < 10){
			textChrono.text = minutes.ToString() + ":" + "0" + secondes.ToString();	
		}
		else{
			textChrono.text = minutes.ToString() + ":" + secondes.ToString();
		}
	}





	IEnumerator TimerTick()
	{
		// tant que le chrono n'est pas à 0
		while(chronoCourant > 0)
		{
			// attend 1 seconde
			yield return new WaitForSeconds(1);


			// décrémente le chrono
			chronoCourant--;

			//convertion();
			UpdateTimerText();
		}

		if( chronoCourant == 0 ){
			isEndChrono = true;
			Application.LoadLevel("Fin");
		}
	}

	bool getIsEndChrono(){
		return isEndChrono;
	}
}
