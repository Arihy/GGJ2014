using UnityEngine;
using System.Collections;

public class IAEnemy2 : MonoBehaviour {

	public Transform[] pathPoint;
	GameObject[] players;
	GameObject playerClose;
	private int currentPathPoint;
	float speed;
	int etat;
	int i;
	int direction;

	float maxX;
	float minX;
	float maxY;
	float minY;

	float randomX;
	float randomY;

	void Awake(){
		pathPoint[0] = transform;	
		speed = 3.0f;
		etat = 1;
		players = GameObject.FindGameObjectsWithTag("Player");

		i = 0;

		maxX = 15.64033f;
		minX = -17.14744f;
		maxY = 18.98134f;
		minY = -11.89067f;
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

	void changeDirection(){
		direction = Random.Range(0, 4);
		if(direction == 0)
		{
			//en bas
			randomX = 0.0f; 
			randomY = -10.0f; //  
		}
		if(direction == 1)
		{
			//en haut
			randomX = 0.0f;
			randomY = 10.0f;
		}
		if(direction == 2)
		{
			// à gauche
			randomX = -10.0f;
			randomY = 0.0f;
		}
		if(direction == 3)
		{
			// à droite
			randomX = 10.0f;
			randomY = 0.0f;
		}
		/*if(direction == 4)
		{
			// à droite
			randomX = 5.0f;
			randomY = 5.0f;
		}
		if(direction == 5)
		{
			// à droite
			randomX = 5.0f;
			randomY = -5.0f;
		}
		if(direction == 6)
		{
			// à droite
			randomX = -5.0f;
			randomY = 5.0f;
		}
		if(direction == 7)
		{
			// à droite
			randomX = -5.0f;
			randomY = 5.0f;
		}//*/
		
		//randomX = 0.0f;
		//randomY = -15.0f;
		//randomX = Random.Range(-15.0f,15.0f); // with float parameters, a random float
		//randomY = Random.Range(-15.0f,15.0f); //  between -2.0 and 2.0 is returned
		
		
		//transform.Translate( new Vector2(randomX,randomY) * speed * Time.deltaTime);
		rigidbody2D.velocity = new Vector2(randomX,randomY) * 0.5f;
		
		if (transform.position.x >= maxX || transform.position.x <= minX) {
			randomX = -randomX;
		}
		if (transform.position.y >= maxY || transform.position.y <= minY) {
			randomY = -randomY;
		}
		
		transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX),
		                                 Mathf.Clamp(transform.position.y, minY, maxY));
		
		
	}

	// Update is called once per frame
	void Update () {
		i++;

		if(etat == 1){
			if( currentPathPoint < pathPoint.Length ){
				Vector3 zone = pathPoint[currentPathPoint].position;	
				Vector3 movingTo = zone - transform.position;
				if(movingTo.magnitude < 1){
					currentPathPoint++;
				}

				else{
					rigidbody2D.velocity = movingTo.normalized * speed;
				}
			}
			else{
				if(true){
					currentPathPoint = 0;
				}
				else{
					rigidbody2D.velocity = Vector2.zero;
				}
			}

			/*if(voitPlayer()){
				Debug.Log("etat : " + etat);
				Debug.Log("voit joueur");
				etat = 2;
			}//*/
		}


		/*if(etat == 2){

			Vector2 v = new Vector2(-playerClose.transform.position.x * 0.5f, -playerClose.transform.position.y * 0.5f);
			rigidbody2D.velocity = v ;
			/*transform.Translate(-playerClose.transform.position.x * Time.deltaTime ,
			                    -playerClose.transform.position.y * Time.deltaTime ,
			                    0);
			
			if (transform.position.x >= maxX || transform.position.x <= minX) {
				randomX = -randomX;
			}
			if (transform.position.y >= maxY || transform.position.y <= minY) {
				randomY = -randomY;
			}
			
			
			if(!voitPlayer()){
				etat = 1;
			}
			Debug.Log("etat : " + etat);
		
		}//*/

		if(etat == 3){
			if( i % 20 == 0 ){
				changeDirection();
				
			}

			/*if(voitPlayer()){
				etat = 2;
			}
			else{
				etat = 1;
			}//*/

		}


	}


	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Bullet")){
			
			etat = 3;
			gameObject.GetComponent<SpriteRenderer>().sprite = other.transform.parent.gameObject.GetComponent<SpriteRenderer>().sprite;
			//other.gameObject.GetComponent<SpriteRenderer>().color = 
			//Debug.Log(other.transform.parent.gameObject.name);
			
		}
	}//*/
}
