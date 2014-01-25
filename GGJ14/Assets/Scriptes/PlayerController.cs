using UnityEngine;
using System.Collections;

public class PlayerController : Players {

	// Use this for initialization
	public override void Start()
	{
		base.Start();
		_horizontal = "Horizontal";
		_vertical = "Vertical";
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

	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, Screen.width/6, Screen.height/4), "Player 1");
		GUI.Label(new Rect(20,40,80,20), "Health : " + _health);
		GUI.Label(new Rect(20,60,80,20), "Speed : " + _speed);
	}
	
}
