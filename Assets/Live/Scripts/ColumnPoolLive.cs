using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPoolLive : MonoBehaviour {

	public int columnPoolSize = 5;
	private GameObject[] columns;
	public GameObject columnPrefab;
	private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
	private float timeSinceLastSpawned;
	public float spawnRate = 4f;
	public float columnMin = -2f;
	public float columnMax = 2f;
	private float spawnXPosition = 10f;
	private int currentColumn = 0;
	void Start () {
		columns = new GameObject[columnPoolSize];
		for (int i = 0; i < columnPoolSize; i++)
		{
			columns[i] = (GameObject) Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
		}
	}
	
	void Update () {
		timeSinceLastSpawned += Time.deltaTime;
		if(!GameController.instance.gameOver &&  timeSinceLastSpawned >= spawnRate){
			timeSinceLastSpawned = 0;
			float spawnYPosition = Random.Range(columnMin, columnMax);
			columns[currentColumn % 5].transform.position = new Vector2(spawnXPosition, spawnYPosition);
			currentColumn ++;
		}
	}
}
