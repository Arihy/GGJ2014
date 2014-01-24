using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	private Transform _transform;
	private float _speed;
	private float _timeToDie;

	// Use this for initialization
	void Start()
	{
		_transform = transform;
		_speed = 8f;
		_timeToDie = 3f;
	}
	
	// Update is called once per frame
	void Update()
	{
		if(Time.time > _timeToDie)
			Destroy(gameObject);
	}

	void FixedUpdate()
	{
	}
}
