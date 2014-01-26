using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	private Transform _transform;
	private float _speed;
	private float _timeToDie;
	private float _nextTime;
	public Transform particule;

	/*
	public AudioClip Impact;
*/
	// Use this for initialization
	void Start()
	{
		_transform = transform;
		_speed = 20f;
		_timeToDie = 0.5f;
		_nextTime = Time.time;
	}
	
	// Update is called once per frame
	void Update()
	{
		_transform.Translate(0 , _speed * Time.deltaTime, 0);
		/*
		if (_timeToDie == 0) {
				audio.Play();
		}
*/
		if(Time.time > _timeToDie + _nextTime){
			//Destroy(gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(gameObject);

		if((other.name != "Player2") && (other.name != "Player"))
			Instantiate(particule,this.transform.position, this.transform.rotation);
	}
}
