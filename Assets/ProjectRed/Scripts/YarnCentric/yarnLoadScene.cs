using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class yarnLoadScene : MonoBehaviour
{
	[YarnCommand("load")]
	public void load(string sceneName) 
	{
	SceneManager.LoadScene(sceneName);
	}
}