using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collect : MonoBehaviour {

	public float rotation = 5f;
	
	void Start () {
		
	}
	
	
	void Update () {
		transform.Rotate(0,rotation,0);
		
	}
	void OnTriggerEnter2D(Collider2D ob)
	{
		if(ob.tag == "Player")
		{
			gameObject.SetActive(false);
			Manager.score=Manager.score+1;
			
		}
	}
		
}
