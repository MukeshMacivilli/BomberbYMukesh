using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceMyPos : MonoBehaviour 
{
	void OnTriggerEnter(Collider col)
	{
		print ("deleting");
		//PowerUpManager.Instance.Spawn = false;
		PowerUpManager.mbRegenarate = false;
		Destroy (gameObject);
	}

	void CheckDelay(GameObject obj)
	{
		
	}
}
