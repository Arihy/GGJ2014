using UnityEngine;
using System.Collections;

public class PlayerController2Bis : Players {
	private float _rotationSpeed;

    public GUIText health;
    public GUIText vitesse;

	// Use this for initialization
	public override void Start()
	{
		base.Start();
		_horizontal = "L_XAxis_1";
		_vertical = "L_YAxis_1";
		_rotationSpeed = 150.0f;
        _team = 2;
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
		float rotateX = Input.GetAxis("R_XAxis_1");
        float rotateY = Input.GetAxis("R_YAxis_1");

        float X = _transform.position.x + rotateX;
        float Y = _transform.position.y + rotateY;

        _transform.localRotation = Utils.lookAt(_transform.position, new Vector3(X, Y, 0), Vector3.up);

        health.text = "Health: " + _health;
        vitesse.text = "Speed: " + _speed;
	}
	
	public override void FixedUpdate()
	{
		base.FixedUpdate();
	}
}
