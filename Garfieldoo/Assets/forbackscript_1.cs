using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class forBackScript : MonoBehaviour {

	public void back()
	{
		SceneManager.LoadScene("first");
	}
}
