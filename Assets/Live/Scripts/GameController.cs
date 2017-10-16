﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
    public static GameController instance;
    public GameObject gameOverText;
    public Text scoreText;

    public float scrollSpeed = -1.5f;
    public bool gameOver = false;
    private int score = 0;

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

    public void BirdScored(){
        if(gameOver){
            return;
        }
        score ++;
        scoreText.text = "Score: " + score.ToString();
    }
    public void BirdDied(){
        Debug.Log("bird died!");
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
