using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Transform _transform;
	private float _speed;
	private float _fireRate;
	private float _nextFire;

	public Transform _bullet;

	// Use this for initialization
	void Start () {
		_transform = transform;
		_speed = 5f;
		_fireRate = 0.3f;
		_nextFire = 0f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		/*
		Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit))
			_lookTarget = hit.point;
		*/
		Vector3 lookTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		lookTarget.z = 0;
		_transform.localRotation = Utils.lookAt(_transform.position, lookTarget, Vector3.up);

		if(Input.GetMouseButton(0))
		{
			if(Time.time > _nextFire)
			{
				_nextFire = Time.time + _fireRate;
				Instantiate(_bullet, _transform.position, _transform.rotation);
			}
		}
	}

	void FixedUpdate()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
		rigidbody2D.velocity = new Vector2(_speed * horizontalInput, _speed * verticalInput);
	}
}
