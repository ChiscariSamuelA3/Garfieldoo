using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forBarrier : MonoBehaviour {

	public GameObject barrier;
	public static bool disabled = false;
	
	// Update is called once per frame
	void Update () {
		if(disabled)
			barrier.SetActive(false);
		else barrier.SetActive(true);
		
	}
}
