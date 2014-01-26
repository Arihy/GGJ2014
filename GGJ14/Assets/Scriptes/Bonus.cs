using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			other.gameObject.SendMessage ("addbag", gameObject);
			Destroy(other.gameObject);
		}
	}

}
