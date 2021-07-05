using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class activateMenu : MonoBehaviour {

	// Use this for initialization
	public Button mm;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void loadMainMenu()
	{
		SceneManager.LoadScene("mainManu");
	}
}
