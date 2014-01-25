using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Transform _transform;
	private float _speed;
	public Transform _bullet;

	// Use this for initialization
	void Start () {
		_transform = transform;
		_speed = 5f;
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
		Debug.Log("position mouse " + Camera.main.ScreenToWorldPoint(Input.mousePosition));

		if(Input.GetMouseButton(0))
		{
			//if(Time.time > nextFire)
			//{
				//nextFire = Time.time + fireRate;
			Instantiate(_bullet, _transform.position, _transform.rotation);
			//}
		}
	}

	void FixedUpdate()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
		rigidbody2D.velocity = new Vector2(_speed * horizontalInput, _speed * verticalInput);
	}
}
