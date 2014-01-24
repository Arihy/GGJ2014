using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Transform _transform;
	private float _speed;

	// Use this for initialization
	void Start () {
		_transform = transform;
		_speed = 5f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		_transform.localRotation = Utils.lookAt(_transform.position, Input.mousePosition, Vector3.up);
	}

	void FixedUpdate()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
		rigidbody2D.velocity = new Vector2(_speed * horizontalInput, _speed * verticalInput);
	}
}
