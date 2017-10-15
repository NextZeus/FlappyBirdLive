﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {
    public static GameController instance;
    public GameObject gameOverText;


    public float scrollSpeed = -1.5f;
    public bool gameOver = false;

    void Awake()
    {
        if( instance == null)
        {
            instance = this;
        } else if(instance != this)
        {
            Destroy(gameObject);
        }
            
    }
	
	// Update is called once per frame
	void Update () {
		if(gameOver && Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void BirdDied(){
        Debug.Log("bird died!");
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
