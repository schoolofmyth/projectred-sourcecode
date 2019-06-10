using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_Animator : MonoBehaviour 
{

	private Animator charAnimator;
	// Use this for initialization
	void Start () 
	{
		charAnimator = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
//		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)|| Input.GetKey (KeyCode.LeftArrow)|| Input.GetKey (KeyCode.RightArrow)) 
		if (Input.GetAxis("Horizontal") != 0 || (Input.GetAxis("Vertical") != 0))
		{
			charAnimator.SetBool("bWalk", true);
		}
        else
            charAnimator.SetBool("bWalk", false);

		if (Input.GetKey(KeyCode.J))
        {
            charAnimator.SetBool("bJump", true);
            charAnimator.SetBool("bWalk", false);
//			Debug.Log ("bJump TRUE");
        }
        else
        {
            charAnimator.SetBool("bJump", false);
//			Debug.Log ("bJump FALSE");
        }

    }
}
