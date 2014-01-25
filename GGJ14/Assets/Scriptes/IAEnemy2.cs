using UnityEngine;
using System.Collections;

public class IAEnemy2 : MonoBehaviour {

	public Transform[] pathPoint;
	private int currentPathPoint;
	float speed;

	void Awake(){
		pathPoint[0] = transform;	
		speed = 3.0f;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
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

		//rigidbody2D.velocity
	}
}
