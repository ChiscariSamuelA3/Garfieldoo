using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottonPower : MonoBehaviour {

	
	void OnTriggerEnter2D(Collider2D ob)
	{
		if(ob.tag=="Player")
		{
			forBarrier.disabled=true;
			
		}
	}
}
