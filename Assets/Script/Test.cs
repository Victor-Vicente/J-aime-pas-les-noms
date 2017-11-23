using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	

	public Animator succesAnimator;
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown("j"))
		{
			if(succesAnimator.GetBool("IsSucces") == false)//Booléen passe en ON
			{
				succesAnimator.SetBool("IsSucces",true);
			}
			else if (succesAnimator.GetBool("IsSucces") == true)//Booléen passe en Off
			{
				succesAnimator.SetBool("IsSucces",false);
			}
		}
	}
}
