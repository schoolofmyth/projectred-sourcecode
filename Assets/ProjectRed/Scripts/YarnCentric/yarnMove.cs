using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class yarnMove : MonoBehaviour {

[SerializeField] private Transform movableObject;
[SerializeField] private Transform moveTo;

	[YarnCommand("move")]
	public void Move(string destinationName) {

		// move to the destination
		movableObject.transform.position = moveTo.transform.position;
	}
}