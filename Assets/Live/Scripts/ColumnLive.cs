using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnLive : MonoBehaviour {
	private void OnTriggerEnter2D(Collider2D other)
	{	
		if(other.GetComponent<BirdLive> () != null){
			GameController.instance.BirdScored();
		}
	}
}
