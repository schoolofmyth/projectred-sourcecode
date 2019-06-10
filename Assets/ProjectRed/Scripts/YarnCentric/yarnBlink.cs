using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class yarnBlink : MonoBehaviour {
//	public static blink instance;
	public float blinkTime = .5f;

	private Image image;

	void Start () {
//		instance = this;
		image = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.P))
//			blink ();
			
	}
	[YarnCommand("blink")]
	public void blink() {
		StartCoroutine(startBlink());
	}

	private IEnumerator startBlink() {

		var color = image.color;
		color.a = 1;
		image.color = color;

		yield return new WaitForSeconds (blinkTime);

		color.a = 0;
		image.color = color;
	}
		
}
