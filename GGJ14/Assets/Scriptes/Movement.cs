using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	public GameObject prefab;
	public Transform Map;
	//public Transform ObjMap;
	//public ArrayList listeObj;
	void Start () {
	
		//chercher un point aléa

		for(int i =0;i<30;i++)
		{
			Vector3 position = new Vector3(Random.Range(1.0F, 31.0F), Random.Range(-20.0F, 8.0F),0 );

			//foreach(Transform child in Map)
			//{
			//	if(!child.collider2D.bounds.Contains(position))		
					Instantiate(prefab, position, Quaternion.identity);
				
			//}
		//	Debug.Log(position.x+"/"+position.y);
		
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
