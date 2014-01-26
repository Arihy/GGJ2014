using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PlayerControllerBis : Players {
    public GUIText health;
    public GUIText vitesse;

	// Use this for initialization
	public override void Start()
	{
		base.Start();
		_horizontal = "Horizontal";
		_vertical = "Vertical";
        _team = 1;
	}
	
	// Update is called once per frame
	public override void Update ()
	{
		base.Update();
		Vector3 lookTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		lookTarget.z = 0;
		_transform.localRotation = Utils.lookAt(_transform.position, lookTarget, Vector3.up);
		if(Input.GetMouseButton(0))
		{
			if(Time.time > _nextFire)
			{
				_nextFire = Time.time + _fireRate;
				Transform bullet = Instantiate(_bullet, _transform.position, _transform.rotation) as Transform;
				bullet.parent = _transform;
			}
		}

        health.text = "Health: " + _health;
        vitesse.text = "Speed: " + _speed;
		// Quand il sera fatigué ...
/*
		if (_health < 25) {
			audio.Play();
		}
*/
	}

	public override void FixedUpdate()
	{
		base.FixedUpdate();
	}
}
