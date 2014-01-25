using UnityEngine;
using System.Collections;

public class IAEnemy : MonoBehaviour {

	int i;
	int etat;
	Vector3 movingTo;
	GameObject[] players;
	GameObject playerClose;
	int a;
	int speed;
	void Awake(){
		speed = 3;
		i = 0;
		etat = 1;
		players = GameObject.FindGameObjectsWithTag("Player");
		a = 100;
<<<<<<< HEAD
		movingTo = new Vector3(transform.position.x + Random.Range(-a, a) * speed,
		                       transform.position.y + Random.Range(-a, a) * speed,
=======
		movingTo = new Vector3(transform.position.x + Random.Range(-1, 1) * speed,
		                       transform.position.y + Random.Range(-1, 1) * speed,
>>>>>>> 5581f7f4bd87773082cd505ebddbbdc7781fc3d5
		                       0);//*/


	}

	// Use this for initialization
	void Start () {
		
	}

	bool voitPlayer(){
		bool res = false;
		for(int j = 0; j < players.Length; j++){
			if( Vector3.Distance(players[j].transform.position, transform.position) < 5 ){
				res = true;
				playerClose = players[j];
			}
		}
		return res;
	}

		// Update is called once per frame
	void Update () {

		i++;

		Debug.Log("etat : " + etat);
		if(etat == 1){
			if( i % 15 == 0 ){
<<<<<<< HEAD
				transform.Translate(Random.Range(-a,a) *  Time.deltaTime, Random.Range(-a,a) *  Time.deltaTime, 0);
=======
				transform.Translate(transform.position.x + Random.Range(-a,a) *  Time.deltaTime,
				                    transform.position.x + Random.Range(-a,a) *  Time.deltaTime,
				                    0);
>>>>>>> 5581f7f4bd87773082cd505ebddbbdc7781fc3d5

			}
			else{
			 movingTo = new Vector3(transform.position.x + Random.Range(-a, a) * Time.deltaTime,
				                    transform.position.y * Time.deltaTime + Random.Range(-a,a),
				                    0);
			}


			if(voitPlayer()){
				Debug.Log("voit joueur");
				etat = 2;
			}
		}

		if(etat == 2){

			transform.Translate(-playerClose.transform.position.x + Random.Range(-4, 4) * Time.deltaTime * speed,
			                    -playerClose.transform.position.y + Random.Range(-5, 5) * Time.deltaTime * speed,
			                    0);

			if(!voitPlayer()){
				etat = 1;
			}
			Debug.Log("etat : " + etat);
		}

		if(etat == 3){
			if( i % 15 == 0 ){
				transform.Translate(Random.Range(-a,a) *  Time.deltaTime, Random.Range(-a,a) *  Time.deltaTime, 0);
				
			}
			else{
				movingTo = new Vector3(transform.position.x + Random.Range(-a, a) * Time.deltaTime,
				                       transform.position.y * Time.deltaTime + Random.Range(-a,a),
				                       0);
			}

			if(voitPlayer()){
				etat = 2;
			}
		}//*/



	}

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Bullet")){
			//if(etat == 2){
				etat = 3;
				other.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
			//}
			//else if(etat == 3){
			//	SpriteRenderer.color = "green";
			//}
		}
	}//*/
}	


