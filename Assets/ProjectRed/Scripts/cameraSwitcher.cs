using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitcher : MonoBehaviour {

	public GameObject cameraOne;
	public GameObject cameraTwo;

	AudioListener cameraOneAudioLis;
	AudioListener cameraTwoAudioLis;

	// Use this for initialization
	void Start()
	{

		//Get Camera Listeners
		cameraOneAudioLis = cameraOne.GetComponent<AudioListener>();
		cameraTwoAudioLis = cameraTwo.GetComponent<AudioListener>();
		cameraTwo.SetActive(false);

	}

	//Is the player touching a collision trigger?
	bool canSwitch;
	[SerializeField] private Transform player;

	void OnTriggerEnter (Collider  other) 
	{
		cameraTwo.SetActive(true);
		cameraTwoAudioLis.enabled = true;

		cameraOneAudioLis.enabled = false;
		cameraOne.SetActive(false);
	}

	void OnTriggerExit (Collider  other) 
	{
		cameraOne.SetActive(true);
		cameraOneAudioLis.enabled = true;

		cameraTwoAudioLis.enabled = false;
		cameraTwo.SetActive(false);
	}
}