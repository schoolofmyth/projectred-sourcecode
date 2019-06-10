using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadOnCollision : MonoBehaviour {


	void OnTriggerEnter(Collider other)
	{
		// Create a temporary reference to the current scene.
		Scene currentScene = SceneManager.GetActiveScene ();

		// Retrieve the name of this scene.
		string sceneName = currentScene.name;

		if (sceneName == "OutsideBar")
		SceneManager.LoadScene("InsideBar");

		else if (sceneName == "InsideBar")
			SceneManager.LoadScene("End");
	}
}
