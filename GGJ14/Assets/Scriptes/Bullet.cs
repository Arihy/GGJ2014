using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	private Transform _transform;
	private float _speed;
	private float _timeToDie;
	private float _nextTime;

	// Use this for initialization
	void Start()
	{
		_transform = transform;
		_speed = 8f;
		_timeToDie = 3f;
		_nextTime = Time.time;
	}
	
	// Update is called once per frame
	void Update()
	{
		if(Time.time > _timeToDie + _nextTime)
			Destroy(gameObject);
	}

	void FixedUpdate()
	{
	}
}
