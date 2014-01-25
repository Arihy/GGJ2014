using UnityEngine;
using System.Collections;

public class Players : MonoBehaviour {
	protected Transform _transform;
	protected float _speed;
	protected float _fireRate;
	protected float _nextFire;
	
	
	protected int _health;
	
	public Transform _bullet;

	// Use this for initialization
	public virtual void Start () {
		_transform = transform;
		_speed = 5f;
		_fireRate = 0.3f;
		_nextFire = 0f;
		
		_health = 100;
	}
	
	// Update is called once per frame
	public virtual void Update () {
		Vector3 lookTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		lookTarget.z = 0;
		_transform.localRotation = Utils.lookAt(_transform.position, lookTarget, Vector3.up);
	}
}
