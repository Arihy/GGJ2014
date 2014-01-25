using UnityEngine;
using System.Collections;

public class IAEnemy : MonoBehaviour {

	int i;
	Transform movingTo;


	void Awake(){
		i = 0;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if( i % 500 == 0 ){
			transform.Translate(Random.Range(1,11) *  Time.deltaTime, Random.Range(1,11) *  Time.deltaTime, 0);
		}
	}
}
