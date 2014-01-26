using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	private Transform _player1;
	private Transform _player2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] p = GameObject.FindGameObjectsWithTag ("Player");
		_player1 = p [0].transform;
		_player2 = p [1].transform;
		Debug.Log (_player1.position);
		Debug.Log (_player2.position);
		float moyenneX = (_player1.position.x + _player2.position.x) / 2;
		float moyenneY = (_player2.position.y + _player1.position.y) / 2;
		Vector3 v = new Vector3 (moyenneX, moyenneY, -10);
		Debug.Log (moyenneX);
		Debug.Log (moyenneY);
		transform.position = v;
		float distance = Mathf.Sqrt (Mathf.Pow ((_player1.position.x - _player2.position.x), 2) + 
		                             (Mathf.Pow ((_player1.position.y - _player2.position.y), 2)));
		if (distance > 8 && distance < 25) {
			camera.orthographicSize =  (float)(distance / 1.7);
		} 
	}
}
