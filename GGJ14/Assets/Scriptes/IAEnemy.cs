using UnityEngine;
using System.Collections;

public class IAEnemy : MonoBehaviour {

	int i;
	int etat;
	Vector2 movingTo;
	GameObject[] players;
	GameObject playerClose;
	int a;
	int speed;

	float maxX;
	float minX;
	float maxY;
	float minY;

	float randomX;
	float randomY;
	
	void Awake(){
		speed = 3;
		i = 0;
		etat = 1;
		players = GameObject.FindGameObjectsWithTag("Player");
		a = 1;

		maxX = 15.64033f;
		minX = -17.14744f;
		maxY = 18.98134f;
		minY = -11.89067f;




		
		movingTo = new Vector2((Random.Range(-a, a)) ,
		                       (Random.Range(-a, a)));//*/




	}

	void changeDirection(){

		randomX = Random.Range(-15.0f,15.0f); // with float parameters, a random float
		randomY = Random.Range(-15.0f,15.0f); //  between -2.0 and 2.0 is returned
		
		if (transform.position.x >= maxX || transform.position.x <= minX) {
			randomX = -randomX;
		}
		if (transform.position.y >= maxY || transform.position.y <= minY) {
			randomY = -randomY;
		}

		transform.Translate( new Vector3(randomX,randomY,0) * speed * Time.deltaTime);
		
		transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX),
									Mathf.Clamp(transform.position.y, minY, maxY));


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

			if(i % 20 == 0){
				changeDirection();
					
			}

			/*if( movingTo.magnitude < 1 ){
				Debug.Log("velovcity");
				movingTo = new Vector2((transform.position.x + Random.Range(-1.0f, -1.0f)),
				            (transform.position.y + Random.Range(-1.0f, -1.0f)));//*/

				//rigidbody2D.velocity = movingTo.normalized * speed;

			//}
			/*else{
			 movingTo = new Vector3(transform.position.x + Random.Range(-a, a) * Time.deltaTime,
				                    transform.position.y * Time.deltaTime + Random.Range(-a,a),
				                    0);
			}*/


			if(voitPlayer()){
				Debug.Log("voit joueur");
				etat = 2;
			}
		}

		if(etat == 2){

			/*transform.Translate(-playerClose.transform.position.x + Random.Range(-4, 4) * Time.deltaTime * speed,
			                    -playerClose.transform.position.y + Random.Range(-5, 5) * Time.deltaTime * speed,
			                    0);

			if(!voitPlayer()){
				etat = 1;
			}//*/
			Debug.Log("etat : " + etat);
		}

		/*if(etat == 3){
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
			else{
				etat = 1;
			}
		}//*/



	}

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Bullet")){

			etat = 3;
			gameObject.GetComponent<SpriteRenderer>().color = Color.red;
			//other.gameObject.GetComponent<SpriteRenderer>().color = 

		}
	}//*/
}	


