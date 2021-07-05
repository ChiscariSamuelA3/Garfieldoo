using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public Transform character;
	Vector3 distance;
	void Start () {
		distance=transform.position-character.position;
	}
	
	
	void Update () {
		transform.position=character.position+distance;
	}
}
