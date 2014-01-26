using UnityEngine;
using System.Collections;

public class PlayerController2 : Players {
	private float _rotationSpeed;

	// Use this for initialization
	public override void Start()
	{
		base.Start();
		_horizontal = "L_XAxis_1";
		_vertical = "L_YAxis_1";
		_rotationSpeed = 150.0f;
	}
	
	// Update is called once per frame
	public override void Update ()
	{
		base.Update();
		if(Input.GetButtonDown("RB_1"))
		{
			if(Time.time > _nextFire)
			{
				_nextFire = Time.time + _fireRate;
				Transform bullet = Instantiate(_bullet, _transform.position, _transform.rotation) as Transform;
				bullet.GetChild(0).particleSystem.startColor = Color.blue;
				bullet.parent = _transform;
			}
		}
		float rotate = Input.GetAxis("R_XAxis_1");
		_transform.Rotate(new Vector3(0, 0, -_rotationSpeed * rotate * Time.deltaTime));
	}
	
	public override void FixedUpdate()
	{
		base.FixedUpdate();
	}
	
	void OnGUI()
	{
		GUI.Box(new Rect(Screen.width/2, 0, Screen.width/6, Screen.height/4), "Player 2");
		GUI.Label(new Rect(Screen.width/2 + 20,40,80,20), "Health : " + _health);
		GUI.Label(new Rect(Screen.width/2 + 20,60,80,20), "Speed : " + _speed);
	}
}
