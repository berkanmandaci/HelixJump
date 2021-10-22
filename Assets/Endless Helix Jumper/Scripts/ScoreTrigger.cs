using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour {


	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			//score
			LevelController.instance.SetScore();
			//SetColliders(false);
			
		}
		
	}

}

