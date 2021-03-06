﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Players : MonoBehaviour {
	protected Transform _transform;
	protected float _speed;
	protected float _fireRate;
	protected float _nextFire;
	protected List<Bonus> _bag;

	protected int _health;
	
	public Transform _bullet;

	//config controller
	protected string _horizontal;
	protected string _vertical;

    protected int _team;


	public Transform particule;

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
        if(_health <= 0)
        {
            Application.LoadLevel("Fin");
        }

	}

	public virtual void FixedUpdate()
	{
		float horizontalInput = Input.GetAxis(_horizontal);
		float verticalInput = Input.GetAxis(_vertical);
		rigidbody2D.velocity = new Vector2(_speed * horizontalInput, _speed * verticalInput);
	}

	public virtual void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Bullet") && other.gameObject.transform.parent != this.gameObject)
		{
			_health -= 10;
			Instantiate(particule,this.transform.position, this.transform.rotation);
			Destroy(other.gameObject);
		}
	}

	void AddBonus(Bonus B){
		_bag.Add (B);
	}

    public int getTeam()
    {
        return _team;
    }
}
