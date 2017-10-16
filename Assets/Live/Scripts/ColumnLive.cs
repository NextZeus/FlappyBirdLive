using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnLive : MonoBehaviour {
	private void OnTriggerEnter2D(Collider2D other)
	{	
		Debug.Log("OnTriggerEnter2D");
		
		if(other.GetComponent<BirdLive> () != null){
			Debug.Log("scores update");
			GameController.instance.BirdScored();
		}
	}
}
