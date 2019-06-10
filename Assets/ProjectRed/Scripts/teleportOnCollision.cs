using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportOnCollision : MonoBehaviour 
{
	[SerializeField] private Transform player;
	[SerializeField] private Transform teleportPoint;

	void OnTriggerEnter(Collider other)
	{
		player.transform.position = teleportPoint.transform.position;
	}

}