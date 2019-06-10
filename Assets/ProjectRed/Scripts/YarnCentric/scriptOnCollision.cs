using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using Yarn.Unity.Example;
using Yarn.Unity;

public class scriptOnCollision : MonoBehaviour {

	public DialogueRunner dialoguerunner;

	public string characterName = "";

	[FormerlySerializedAs("startNode")]
	public string talkToNode = "";

//	[Header("Optional")]
//	public TextAsset scriptToLoad;

	public void Start(){
		dialoguerunner = GetComponent<DialogueRunner> ();
	}

	public void OnTriggerEnter(Collider other)
	{
//		dialoguerunner.StartDialogue ("FallDeath");
		dialoguerunner.StartDialogue (talkToNode);
	}
}