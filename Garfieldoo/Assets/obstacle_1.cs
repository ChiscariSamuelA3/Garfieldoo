using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour {
	
	
 	void OnTriggerEnter2D(Collider2D ob)
	{
		if(ob.tag=="Player")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			forBarrier.disabled=false;
		}
	}
	
}
