using UnityEngine;
using System.Collections;

public class IAEnemy : MonoBehaviour {

	int i;
	int etat;
	Transform movingTo;
	GameObject[] players;
	GameObject playerClose;

	void Awake(){
		i = 0;
		etat = 1;
		players = GameObject.FindGameObjectsWithTag("Player");
	}

	// Use this for initialization
	void Start () {
		
	}

	bool voitPlayer(){
		bool res = false;
		for(int j = 0; j < players.Length; j++){
			if( Vector3.Distance(players[j].transform.position, transform.position) < 10 ){
				res = true;
				playerClose = players[j];
			}
		}
		return res;
	}
	
	// Update is called once per frame
	void Update () {
		if(etat == 1){
			if( i % 500 == 0 ){
				transform.Translate(Random.Range(-11,0) *  Time.deltaTime, Random.Range(-11,0) *  Time.deltaTime, 0);
			}
			if(voitPlayer()){
				Debug.Log("voit joueur");
				etat = 2;
			}
		}

		if(etat == 2){
			transform.Translate(playerClose.transform.position.x, playerClose.transform.position.y, 0);
		}

		if(etat == 3){

		}
	}
}
