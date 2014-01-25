using UnityEngine;
using System.Collections;


public class PlayerController : Players {

	// Use this for initialization
	public override void Start()
	{
		base.Start();
	}
	
	// Update is called once per frame
	public override void Update ()
	{
		base.Update();
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

	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, Screen.width/6, Screen.height/4), "Player info");
		GUI.Label(new Rect(20,40,80,20), "Health : " + _health);
		GUI.Label(new Rect(20,60,80,20), "Speed : " + _speed);
	}
}
