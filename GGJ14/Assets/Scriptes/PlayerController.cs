using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Transform _transform;
	private float _speed;

	// Use this for initialization
	void Start () {
		_transform = transform;
		_speed = 3f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
	}
}
