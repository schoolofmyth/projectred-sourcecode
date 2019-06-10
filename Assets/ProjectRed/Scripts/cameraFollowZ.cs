using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowZ : MonoBehaviour {

	/// Target of the camera
	public Transform target;

	/// Minimum position of camera
	public float minPosition = -10.0f;

	/// Maximum position of camera
	public float maxPosition = 10.0f;

	/// Movement speed of camera
	public float moveSpeed = 2.0f;

	// Distance away from player
	public float distanceAway = 15f;

	// Update is called once per frame
	void Update () {
		if (target == null) {
			return;
		}
		var newPosition = Vector3.Lerp(transform.position, target.position, moveSpeed * Time.deltaTime);

		newPosition.x = Mathf.Clamp(newPosition.x, minPosition, maxPosition);
//		newPosition.y = Mathf.Clamp(newPosition.y, minPosition, maxPosition);
//		newPosition.z = Mathf.Clamp(newPosition.z, minPosition, maxPosition);

		newPosition.y = transform.position.y;
		newPosition.z = target.position.z - distanceAway;

		transform.position = newPosition;
	}
}
