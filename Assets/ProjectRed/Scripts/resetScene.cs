using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetScene : MonoBehaviour {

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			RestartGame ();
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			Restart2 ();
		}
		
	}

	public void RestartGame()
	{
		SceneManager.LoadScene("OutsideBar");
	}

	public void Restart2()
	{
		SceneManager.LoadScene("InsideBar");
	}
}
